using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.BannerDto;
using BabyCare.Web.Services.BannerService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BannerController(IMapper _mapper , IBannerService _bannerService ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values =  await _bannerService.GetAllAsync();
            var dto = _mapper.Map < List<ResultBannerDto>>(values);
            return View(dto);
        }

        public async Task<IActionResult> AddBanner()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>AddBanner(CreateBannerDto createBanner)
        {
            var banner = _mapper.Map<Banner>(createBanner);
            await _bannerService.AddAsync(banner);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateBanner(string id)
        {
            var banner = await _bannerService.GetByIdAsync(id);
            //Banner kaydını getirir

            var dto = _mapper.Map<UpdateBannerDto>(banner);
            //Viewde Dto kullanmak için entity dto ya çevirdik.

            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateBanner(UpdateBannerDto updateBanner)
        {
            var banner = _mapper.Map<Banner>(updateBanner);
            await _bannerService.UpdateAsync(banner.BannerId , banner);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteBanner(string id)
        {
            await _bannerService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
