using AutoMapper;
using BabyCare.Web.Dtos.ServicesDtos;
using BabyCare.Web.Services.ServicesService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Default
{
    public class _ServiceComponent (IServicesService _servicesService , IMapper _mapper):ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var servıcess = await _servicesService.GetAllAsync();
            var dto = _mapper.Map<List<ResultServicesDto>>(servıcess);
            return View(dto);
        }
    }
}
