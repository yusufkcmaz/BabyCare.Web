using AutoMapper;
using BabyCare.Web.Dtos.AboutDto;
using BabyCare.Web.Services.AboutServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Default
{
    public class _AboutComponent (IMapper _mapper , IAboutService _aboutService): ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _aboutService.GetAllAsync();
            var dto = _mapper.Map<List<ResultAboutDto>>(values);

            return View(dto);
        }
    }
}
