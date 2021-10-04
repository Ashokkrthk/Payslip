using BusinessLayer;
using BusinessLayer.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaySlip.Controllers
{
    public class SalaryDetailsController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly SalaryBusinessLayer inputRequest;

        public SalaryDetailsController(IConfiguration config)
        {
            this.configuration = config;
            inputRequest = new SalaryBusinessLayer(configuration.GetConnectionString("ISODataBaseConnection"));
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Index()
        {

            //UserBusinessLayer layer = new UserBusinessLayer();
            //List<User> list = UserBusinessLayer.Users.ToList();
            //return View(list);

            List<SalaryDetails> list = inputRequest.Details();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(SalaryDetails salaryObj)
        {
            if (ModelState.IsValid)
            {
                inputRequest.AddSalaryDetails(salaryObj);
                return RedirectToAction("Index", "salary");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            SalaryDetails salary = inputRequest.Details().Single(emp => emp.ID == id);

            return View(salary);
        }
        [HttpPost]
        public ActionResult Edit(SalaryDetails salaryObj)
        {
            if (ModelState.IsValid)
            {
                inputRequest.UpdateSalaryDetails(salaryObj);
                return RedirectToAction("Index", "SalaryDetails");
            }
            return View();
        }
        [HttpGet]
        public ActionResult delete(int id)
        {

            inputRequest.DeleteUser(id);
            return RedirectToAction("index", "user");
        }
        public ActionResult details(int id)
        {
            SalaryDetails salary = inputRequest.Details().Single(emp => emp.ID == id);
            return View(salary);
        }


    }
}
