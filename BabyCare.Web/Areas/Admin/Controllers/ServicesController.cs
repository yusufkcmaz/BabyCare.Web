using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.GallaryDtos;
using BabyCare.Web.Dtos.ServicesDtos;
using BabyCare.Web.Services.ServicesService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    public class ServicesController(IMapper _mapper , IServicesService _servicesService ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var servıs = await _servicesService.GetAllAsync();
            var dto = _mapper.Map<List<ResultServicesDto>>(servıs);

            return View(dto);

        }

        public async Task<IActionResult> AddService()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(CreateServicesDto createServices)
        {
            var servıs = _mapper.Map<BabyCare.Web.DataAccess.Entities.Services>(createServices);
            var values = _servicesService.AddAsync(servıs);
            return View(values);
        }
        public async Task<IActionResult> UpdateService(string id)
        {
            var servıs = await _servicesService.GetByIdAsync(id);
            var dto = _mapper.Map<UpdateServicesDto>(servıs);

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> UpdateServıce(UpdateServicesDto servicesDto)
        {
            var servıs = _mapper.Map<BabyCare.Web.DataAccess.Entities.Services>(servicesDto);
            await _servicesService.UpdateAsync(servıs.ServicesId , servıs);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteServıce(string id)
        {
            await _servicesService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
