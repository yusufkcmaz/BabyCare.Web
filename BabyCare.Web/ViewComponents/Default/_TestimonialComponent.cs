using AutoMapper;
using BabyCare.Web.Dtos.TestimonialDtos;
using BabyCare.Web.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Default
{
    public class _TestimonialComponent(IMapper _mapper , ITestimonialService _testimonialService) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _testimonialService.GetAllAsync();
            var dto = _mapper.Map<List<ResultTestimonialDto>>(values);
            return View(dto);
        }
    }
}
