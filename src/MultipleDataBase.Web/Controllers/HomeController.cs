using Microsoft.AspNetCore.Mvc;

namespace MultipleDataBase.Web.Controllers
{
    public class HomeController : MultipleDataBaseControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}