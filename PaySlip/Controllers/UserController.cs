using BusinessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PaySlip.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaySlip.Controllers
{
    public class UserController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly UserBusinessLayer inputRequest;        

        public UserController(IConfiguration config)
        {
            this.configuration = config;

            inputRequest = new UserBusinessLayer(configuration.GetConnectionString("ISODataBaseConnection"));
            
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            //var user = _context.Users.SingleOrDefault(x => x.UserName == model.UserName && x.Password == model.Password);
            User userDetail = inputRequest.Login(model.UserName, model.Password);
            if (userDetail.UserType == 1)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("UserDetail", userDetail);
            }            
        }

        public ActionResult Index()
        {

            //UserBusinessLayer layer = new UserBusinessLayer();
            //List<User> list = UserBusinessLayer.Users.ToList();
            //return View(list);

            List<User> list = inputRequest.Users();
            return View(list);
        }
        [HttpGet]
        public ActionResult Create()
        {
            
            return View();
        }

        #region Create
        [HttpPost]
        public ActionResult Create(User userObj)
        {
            if (ModelState.IsValid)
            {
                inputRequest.AddUser(userObj);
                return RedirectToAction("Index", "User");
            }
            return View();
        }
        #endregion

        #region Get User by Id
        [HttpGet]
        public ActionResult Edit(int id)
        {
            User user = inputRequest.Users().Single(emp => emp.ID == id);

            return View(user);
        }
        #endregion


        [HttpPost]
        public ActionResult Edit(User userObj)
        {
            if (ModelState.IsValid)
            {
                inputRequest.UpdateUser(userObj);
                return RedirectToAction("Index", "User");
            }
            return View();
        }


        [HttpGet]
        public ActionResult delete(int id)
        {

            inputRequest.DeleteUser(id);
            return RedirectToAction("Index", "User");
        }

        public ActionResult details(int id)
        {
            User user = inputRequest.Users().Single(emp => emp.ID == id);
            return View(user);
        }


        [HttpGet]
        public ActionResult BankDetails(int id)
        {
            return RedirectToAction("Create", "BankDetails", new { id = id });
        }


        public ActionResult BankEdit(int id)
        {
            return RedirectToAction("Edit", "BankDetails", new { id = id });
        }

    }
}
