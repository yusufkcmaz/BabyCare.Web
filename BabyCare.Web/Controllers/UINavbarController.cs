﻿using AutoMapper;
using BabyCare.Web.DataAccess.Entities;
using BabyCare.Web.Dtos.ContactDtos;
using BabyCare.Web.Services.ContactServices;
using Microsoft.AspNetCore.Mvc;

namespace BabyCare.Web.Controllers
{
    public class UINavbarController(IMapper _mapper , IContactService _contactService ): Controller
    {
        public async Task<IActionResult> Contact()
        {
            var con = await _contactService.GetAllAsync();
            var dto = _mapper.Map<List<ResultContactDto>>(con);
            return View(dto);
        }
    }
}
