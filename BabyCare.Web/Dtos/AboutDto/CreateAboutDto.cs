﻿namespace BabyCare.Web.Dtos.AboutDto
{
    public class CreateAboutDto
    {
        public string? ImageUrl { get; set; }
        public string? VideoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
