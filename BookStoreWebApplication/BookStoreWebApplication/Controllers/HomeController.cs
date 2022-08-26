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

        public string Index() 
        {
            return "returning from HomeController Index action method";
        }
    }
}
