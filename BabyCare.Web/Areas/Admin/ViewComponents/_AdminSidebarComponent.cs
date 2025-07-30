using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.ViewComponents
{
    public class _AdminSidebarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
            
    }
}
