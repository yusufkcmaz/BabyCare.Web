using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Controllers
{//Test-1
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
