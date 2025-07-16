using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.BannerDto;
using BabyCare.Web.Dtos.GallaryDtos;
using BabyCare.Web.Services.GallaryServices;
using Microsoft.AspNetCore.Mvc;
using ZstdSharp.Unsafe;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    public class GallaryController(IMapper _mapper , IGallaryService _gallaryService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var galery = await _gallaryService.GetAllAsync();
            var dto = _mapper.Map<List<ResultGallaryDto>>(galery);

            return View(dto);
        }

        [HttpGet]
        public async Task<IActionResult> AddGallary()
        {
            return  View();
        }
                       
        
        [HttpPost]
        public async Task<IActionResult> AddGallary(CreateGallaryDto createGallary) 
        {
            var gallery = _mapper.Map<Gallary>(createGallary);
            var values = _gallaryService.AddAsync(gallery);
            return View(gallery);
        }

        public async Task<IActionResult> UpdateGallary(string id)
        {
            var gallery = await _gallaryService.GetByIdAsync(id);
            var dto = _mapper.Map<UpdateGallaryDto>(gallery);

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UpdateGallary(UpdateGallaryDto updateGallary)
        {
            var Gallery = _mapper.Map<Gallary>(updateGallary);
            await _gallaryService.UpdateAsync(Gallery.GallaryId , Gallery );
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteGallery(string id)
        {
            await _gallaryService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}

