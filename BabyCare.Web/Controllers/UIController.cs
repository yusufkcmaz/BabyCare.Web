using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Controllers
{
    public class UIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
