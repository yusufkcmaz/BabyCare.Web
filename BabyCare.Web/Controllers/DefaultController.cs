using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
