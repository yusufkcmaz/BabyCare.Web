using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.AboutDto;
using BabyCare.Web.Dtos.ContactDtos;
using BabyCare.Web.Dtos.ServicesDtos;
using BabyCare.Web.Services.AboutServices;
using BabyCare.Web.Services.ContactServices;
using BabyCare.Web.Services.MessageService;
using BabyCare.Web.Services.ServicesService;
using Humanizer;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Controllers
{
    public class UINavbarController(IMapper _mapper , IContactService _contactService , IMessageService _messageService , IAboutService _aboutService , IServicesService _servicesService): Controller
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

        public async Task<IActionResult> About()
        {
            var abouts = await _aboutService.GetAllAsync();
            var dto = _mapper.Map<List<ResultAboutDto>>(abouts);
            return View(dto);
        }


        public async Task<IActionResult> Service()
        {
            var service = await _servicesService.GetAllAsync();
            var dto = _mapper.Map<List<ResultServicesDto>>(service);
            return View(dto);
        }


    }
}
