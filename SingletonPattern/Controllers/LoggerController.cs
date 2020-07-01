using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SingletonPattern.Controllers
{
    public class LoggerController : Controller
    {
        // GET: Logger
        Singleton obj1 = Singleton.GetInstance;
        
        public ActionResult Index()
        {
            obj1.Logger("");
            return View();
        }
    }
}