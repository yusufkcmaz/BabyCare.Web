using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.EventDtos;
using BabyCare.Web.Services.EventService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class EventController (IEventService _eventService , IMapper _mapper): Controller
    {
        public async Task<IActionResult> Index()
        {
            var values = await _eventService.GetAllAsync();
            var dto = _mapper.Map<List<ResultEventDto>>(values);
            return View(dto);
        }

        [HttpGet]
        public async Task<IActionResult> UpdadeEvent(string id)
        {
            var evet = await _eventService.GetByIdAsync(id);
            var  dto = _mapper.Map<UpdateEventDto>(evet);
            return View(dto);
        }

        [HttpPost]
        public async Task<IActionResult> UpdadeEvent(UpdateEventDto updateEvent)
        {
            var events = _mapper.Map<Event>(updateEvent);
            await _eventService.UpdateAsync(events.EventId , events);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> AddEvent()
        {
            return View();  
        }

        [HttpPost]
        public async Task<IActionResult> AddEvent(CreateEventDto eventDto)
        {
            var events = _mapper.Map<Event>(eventDto);
            await _eventService.AddAsync(events);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> DeleteEvent(string id)
        {
            await _eventService.DeleteAsync(id);
            return RedirectToAction("Index");

        }
    }
}
