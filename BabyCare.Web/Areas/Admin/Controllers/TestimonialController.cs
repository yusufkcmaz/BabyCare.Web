using AutoMapper;
using BabyCare.Web.Dtos.TestimonialDtos;
using BabyCare.Web.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    public class TestimonialController(IMapper _mapper , ITestimonialService _testimonialService ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _testimonialService.GetAllAsync();
            var dto = _mapper.Map<List<ResultTestimonialDto>>(values);
            return View(dto);
        }
    }
}
