using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.BannerDto;
using BabyCare.Web.Dtos.TestimonialDtos;
using BabyCare.Web.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TestimonialController(IMapper _mapper , ITestimonialService _testimonialService ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _testimonialService.GetAllAsync();
            var dto = _mapper.Map<List<ResultTestimonialDto>>(values);
            return View(dto);
        }

        public async Task<IActionResult> DeleteTest(string id)
        {
            await _testimonialService.DeleteAsync(id);
                return RedirectToAction("Index");
        }

        public async Task<IActionResult> UpdateTest(string id)
        {
            var testi = await _testimonialService.GetByIdAsync(id);

            var dto = _mapper.Map<UpdateTestimonialDto>(testi);
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateTest(UpdateTestimonialDto testimonialDto)
        {
            var testi = _mapper.Map<Testimonial>(testimonialDto);
            await _testimonialService.UpdateAsync(testi.TestimonialId, testi);
            return RedirectToAction("Index");


        }

        public async Task<IActionResult> CreateTest()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateTest(CreateTestimonialDto createTestimonial)
        {
            var banner = _mapper.Map<Testimonial>(createTestimonial);
            await _testimonialService.AddAsync(banner);
            return RedirectToAction("Index");
        }
    }
}
