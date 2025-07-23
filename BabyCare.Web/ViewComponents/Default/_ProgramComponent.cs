using AutoMapper;
using BabyCare.Web.Dtos.ProductDtos;
using BabyCare.Web.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Default
{
    public class _ProgramComponent(IMapper _mapper , IProductService _product) : ViewComponent

    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _product.GetAllAsync();
            var dto = _mapper.Map<List<ResultProductDto>>(values);
            return View(dto);
        }
    }
}
