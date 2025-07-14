using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Layout
{
    public class _NavbarComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
