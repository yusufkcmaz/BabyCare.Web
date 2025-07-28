using AutoMapper;
using BabyCare.Web.Dtos.InstructorDtos;
using BabyCare.Web.Services.InstructorServices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;

namespace BabyCare.Web.ViewComponents.Default
{
    public class _TeamComponent(IMapper _mapper  , IInstructorService _ınstructorService) : ViewComponent

    {
        public async  Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _ınstructorService.GetAllInstructorAsync();
            var dto = _mapper.Map<List<ResultInstructorDto>>(values);
            return View(dto);
        }
    }
}
