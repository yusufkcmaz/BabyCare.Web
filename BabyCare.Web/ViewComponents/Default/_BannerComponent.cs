using AutoMapper;
using BabyCare.Web.Dtos.BannerDto;
using BabyCare.Web.Services.BannerService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Default
{
    public class _BannerComponent (IMapper _mapper , IBannerService _bannerService ):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var banners = await _bannerService.GetAllAsync();
            var dto = _mapper.Map<List<ResultBannerDto>>(banners);
            return View(dto);
        }
    }
}
 