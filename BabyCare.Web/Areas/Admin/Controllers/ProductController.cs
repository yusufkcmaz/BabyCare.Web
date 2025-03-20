using BabyCare.Web.Dtos.ProductDtos;
using BabyCare.Web.Services.InstructorServices;
using BabyCare.Web.Services.ProductServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Permissions;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController(IProductService _productservice ,IInstructorService _ınstructorService) : Controller
    {

        public async Task<IActionResult> Index()
        {
            var values = await _productservice.GetAllAsync();

            return View(values);
        }


        public async Task<IActionResult> DeleteProduct(string id)
        {
            await _productservice.DeleteAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> CreateProduct()
        {
            var ınstructors = await _ınstructorService.GetAllInstructorAsync();
            ViewBag.ınstructors = (from x in ınstructors
                                   select new SelectListItem
                                   {
                                       Text = x.FullName,
                                       Value = x.FullName
                                   }).ToList();
            return View();
        }

        [HttpPost]  
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)

        {
            await _productservice.CreateAsync(createProductDto);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> UpdateProduct(string id)
        {
            var ınstructors = await _ınstructorService.GetAllInstructorAsync();
            ViewBag.ınstructors = (from x in ınstructors
                                   select new SelectListItem
                                   {
                                       Text = x.FullName,
                                       Value = x.FullName
                                   }).ToList();

            var values = await _productservice.GetById(id);
            return View(values);

        }

        [HttpPost]

        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto) 
        {
            await _productservice.UpdateAsync(updateProductDto);
            return RedirectToAction("Index");
        }
    }

}
