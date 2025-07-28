using AutoMapper;
using BabyCare.Web.Dtos.EventDtos;
using BabyCare.Web.Services.EventService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.ViewComponents.Default
{
    public class _EventComponent (IMapper _mapper , IEventService _eventService): ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values =  await _eventService.GetAllAsync();
            var dto = _mapper.Map<List<ResultEventDto>> (values);
            return View(dto);  
        }
    }
}
