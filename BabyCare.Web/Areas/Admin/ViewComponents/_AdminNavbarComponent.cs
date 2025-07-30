using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.ViewComponents
{
    public class _AdminNavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
