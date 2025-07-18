using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.AboutDto;
using BabyCare.Web.Dtos.BannerDto;
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



        public async Task<IActionResult> UpdateAbout(string id)
        {
            var about = await _aboutService.GetByIdAsync(id);
            //Banner kaydını getirir

            var dto = _mapper.Map<UpdateAboutDto>(about);
            //Viewde Dto kullanmak için entity dto ya çevirdik.

            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateAbout(UpdateAboutDto updateAbout)
        {
            var about = _mapper.Map<About>(updateAbout);
            await _aboutService.UpdateAsync(about.AboutId , about);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteAbout(string id)
        {
            await _aboutService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}

