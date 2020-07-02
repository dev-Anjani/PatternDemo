using Logger;
using System.Web.Mvc;

namespace SingletonPattern.Controllers
{
    public class LoggerController : BaseController
    {
        public ActionResult Index()
        {
            throw new System.Exception();
        }
    }
}