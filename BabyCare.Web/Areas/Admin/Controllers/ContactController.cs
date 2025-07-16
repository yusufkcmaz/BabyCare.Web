using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.ContactDtos;
using BabyCare.Web.Services.BannerService;
using BabyCare.Web.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactController(IMapper _mapper , IContactService _contactService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var value = await _contactService.GetAllAsync();
            var dto = _mapper.Map<List<ResultContactDto>>(value);
            return View(dto);
        }

        public async Task<IActionResult> AddContact()
        {
            return  View();
        }
        [HttpPost]
        public async Task<IActionResult> AddContact(CreateContactDto contactDto)
        {
            var contact = _mapper.Map<Contact>(contactDto);
            await _contactService.AddAsync(contact);
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> UpdateContact(string id )
        {
            var contact = await _contactService.GetByIdAsync(id);
            var dto = _mapper.Map<UpdateContactDto>(contact);
            return View(dto);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContact)
        {
            var contact = _mapper.Map<Contact>(updateContact);
            await _contactService.UpdateAsync(updateContact.ContactId, contact);
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> DeleteContact(string id)
        {
            await _contactService.DeleteAsync(id);
            return RedirectToAction("Index");
        }

    }

}
