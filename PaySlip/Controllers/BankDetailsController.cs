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
    public class BankDetailsController : Controller
    {
        private readonly IConfiguration configuration;
        
        private readonly BankBusinessLayer _bankRequest;

        public BankDetailsController(IConfiguration config)
        {
            this.configuration = config;
            _bankRequest = new BankBusinessLayer(configuration.GetConnectionString("ISODataBaseConnection"));
        }

        public IActionResult Index()
        {
            List<BankDetails> list = _bankRequest.Details();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create(int id)
        {

            return View();
        }
        [HttpPost]
        public ActionResult Create(BankDetails bankObj)
        {
            if (ModelState.IsValid)
            {
                _bankRequest.AddBankDetails(bankObj);
                return RedirectToAction("Index", "BankDetails");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            BankDetails details = _bankRequest.Details().Single(emp => emp.ID == id);

            return View(details);
        }
        [HttpPost]
        public ActionResult Edit(BankDetails bankObj)
        {
            if (ModelState.IsValid)
            {
                _bankRequest.EditBankDetails(bankObj);
                return RedirectToAction("Index", "BankDetails");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {

            //_bankRequest.DeleteBankDetails(id);
            return RedirectToAction("Index", "BankDetails");
        }
        public ActionResult Details(int id)
        {
            BankDetails details = _bankRequest.Details().Single(emp => emp.ID == id);
            return View(details);
        }

    }
}
