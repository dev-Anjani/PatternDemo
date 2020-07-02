using FactoryPattern.Classes;
using FactoryPattern.Factory;
using FactoryPattern.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryPattern.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IIcecreamFactory factory = new IcecreamFactory();
            try
            {
                IIcecream icecream = factory.GetIcecream("Vwani");
                var price = icecream.GetPrice();
                ViewBag.Message = $"Icecream Price is {price}.";
            }
            catch(ArgumentException ArgEx)
            {
                if (ArgEx.Message =="Item Invalid")
                {
                    ViewBag.Message = "Invalid Item";
                }
            }

            //throw exception for demo
            throw new Exception("This is unhandled exception");

            //return View("Index1");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //[CustomValidation]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}