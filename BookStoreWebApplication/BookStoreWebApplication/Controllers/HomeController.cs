using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreWebApplication.Controllers
{
    public class HomeController: Controller
    {
        //all methods inside the HomeContriller are known as action method
        //public string Index() 
        //{
        //    return "returning from HomeController Index action method";
        //}

        // add a new view() into the application
        //public ViewResult Index()
        //{
        //    return View();
        //}

        // add anothor view into the application
        public ViewResult AboutUs()
        {
            return View();
        }

        // viwe inside the shared folder
        // if you have a view which is common then only you can put that view inside the shared folder
        public ViewResult ContactUs()
        {
            return View();
        }

        // return a view which is not same as the action method
        //public ViewResult Index()
        //{
        //    return View("AboutUs");
        //}

        // return a view with data model
        //public ViewResult Index()
        //{
        //    //model obj
        //    var obj = new { id = 10, Name = "Prabir", MobileNo = 8944018462 };
        //    return View(obj);
        //}

        // return a view with data model and which is not same as the action method 
        //public ViewResult Index()
        //{
        //    //data model
        //    var obj = new { id = 10, Name = "Prabir", MobileNo = 8944018462 };
        //    return View("ContactUs", obj);
        //}

        // Return a view from other location(TempView) instade of Views folder
        // 1st approuch
        //public ViewResult Index()
        //{
        //    return View("~/TempView/PrabirTemp.cshtml");
        //}
        //2nd approuch
        public ViewResult Index()
        {
            return View("../../TempView/PrabirTemp");
        }
    }
}
