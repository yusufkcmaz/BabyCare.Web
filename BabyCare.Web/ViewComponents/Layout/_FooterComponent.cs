using AutoMapper;
using BabyCare.Web.Dtos.LayoutInfoDtos;
using BabyCare.Web.Services.LayoutInfoService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Layout
{
    public class _FooterComponent(ILayoutInfoService _layoutInfoService , IMapper _mapper) : ViewComponent

    {
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var values = await _layoutInfoService.GetAllAsync();
            var value = _mapper.Map<List<ResultLayoutInfoDto>>(values);
            return View(value);
        }
    }
}
