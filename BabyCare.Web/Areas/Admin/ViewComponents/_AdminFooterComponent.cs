using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Pkcs;

namespace BabyCare.Web.Areas.Admin.ViewComponents
{
    public class _AdminFooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
