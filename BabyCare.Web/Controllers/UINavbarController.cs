using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.ContactDtos;
using BabyCare.Web.Services.ContactServices;
using BabyCare.Web.Services.MessageService;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Controllers
{
    public class UINavbarController(IMapper _mapper , IContactService _contactService , IMessageService _messageService ): Controller
    {
        public async Task<IActionResult> Contact()
        {
            var con = await _contactService.GetAllAsync();
            var dto = _mapper.Map<List<ResultContactDto>>(con);
            return View(dto);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SendMessage(Message message)
        {
            message.CreatedAt = DateTime.UtcNow;
            await _messageService.AddAsync(message);
            TempData["Success"] = "Mesajınız alındı, teşekkür ederiz!";
            return RedirectToAction("Contact");
        }


    }
}
