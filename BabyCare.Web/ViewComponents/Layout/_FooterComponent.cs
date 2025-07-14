using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Layout
{
    public class _FooterComponent : ViewComponent

    {
        public IViewComponentResult Invoke ()
        {
            return View();
        }
    }
}
