using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.AboutDto;
using BabyCare.Web.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AboutController(IAboutService _aboutService ,IMapper _mapper) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _aboutService.GetAllAsync();
            var dtolist = _mapper.Map<List<ResultAboutDto>>(values);
            return View(dtolist);
        }

        public IActionResult CreateAbout()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CreateAbout(CreateAboutDto aboutdto)
        {
            var about = _mapper.Map<About>(aboutdto);
            await _aboutService.AddAsync(about);
            return RedirectToAction("Index");
        }
    }
}
