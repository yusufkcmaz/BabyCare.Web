using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.AboutDto;
using BabyCare.Web.Dtos.LayoutInfoDtos;
using BabyCare.Web.Services.AboutServices;
using BabyCare.Web.Services.LayoutInfoService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FooterController(IMapper _mapper, ILayoutInfoService _layoutInfoService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _layoutInfoService.GetAllAsync();
            var dtolist = _mapper.Map<List<ResultLayoutInfoDto>>(values);
            return View(dtolist);
        }

        public IActionResult CreateFooter()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> CreateFooter(CreateLayouInfoDto createLayout)
        {
            var Footer = _mapper.Map<LayoutInfo>(createLayout);
            await _layoutInfoService.AddAsync(Footer);
            return RedirectToAction("Index");
        }



        public async Task<IActionResult> UpdateFooter(string id)
        {
            var Footer = await _layoutInfoService.GetByIdAsync(id);
            //kaydını getirir

            var dto = _mapper.Map<UpdateLayoutInfoDto>(Footer);
            //Viewde Dto kullanmak için entity dto ya çevirdik.

            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateFooter(UpdateLayoutInfoDto layoutInfoDto)
        {
            var Footer = _mapper.Map<LayoutInfo>(layoutInfoDto);
            await _layoutInfoService.UpdateAsync(Footer.Id ,Footer);
            return RedirectToAction("Index");
        }


        public async Task<IActionResult> DeleteFooter(string id)
        {
            await _layoutInfoService.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}


