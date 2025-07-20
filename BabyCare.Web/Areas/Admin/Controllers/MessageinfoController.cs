using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Services.MessageService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageinfoController(IMessageService _messageService , IMapper _mapper ) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _messageService.GetAllAsync();
            var dto = _mapper.Map<List<Message>>(value);
            return View(dto);
        }

        public async Task<IActionResult> DeleteMessage(string id)
        {
            await _messageService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }
}
