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
            return RedirectToAction("Index", "User");
            //List<SalaryDetails> list = inputRequest.Details();
            //return View(list);
        }
        [HttpGet]
        public ActionResult Create(int id)
        {
            var salryObj = new SalaryDetails();
            salryObj.Userid = id;
            salryObj.Conveyance_Allowances = 1600;
            salryObj.Medical_Allowances = 1250;
            return View(salryObj);
        }
        [HttpPost]
        public ActionResult Create(SalaryDetails salaryObj)
        {
            if (ModelState.IsValid)
            {
                inputRequest.AddSalaryDetails(salaryObj);
                return RedirectToAction("Index", "User");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id, int userType = 0)
        {
            SalaryDetails salary = inputRequest.Details().Where(emp => emp.Userid == id).FirstOrDefault();
            
                return View(salary);
            
            
        }
        public ActionResult ViewSalary(int id, int userId)
        {
            SalaryDetails salary = inputRequest.Details().Where(emp => emp.Userid == userId && emp.ID == id).ToList().FirstOrDefault();
            if (salary == null)
            {
                // Throw File notfound
            }
            return View(salary);
            
        }
        public ActionResult ViewSalaryDetails(int id)
        {
            List<SalaryDetails> salary = inputRequest.Details().Where(emp => emp.Userid == id).ToList();
            if (salary == null)
            {
                // Throw File notfound
            }
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

        public ActionResult GeneratePayslip(int Id, int userId)
        {
            if (ModelState.IsValid)
            {
                var payslip = inputRequest.GeneratePayslip(Id, userId, 0, 0);
                return View(payslip.FirstOrDefault());
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
