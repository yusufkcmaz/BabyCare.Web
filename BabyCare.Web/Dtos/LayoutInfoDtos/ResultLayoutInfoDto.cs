namespace BabyCare.Web.Dtos.LayoutInfoDtos
{
    public class ResultLayoutInfoDto
    {
        public string Id { get; set; } 
        public string Description { get; set; }
        public string Location { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Service { get; set; }

        public string WeekdayHours { get; set; }
        public string SaturdayHours { get; set; }


        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedinUrl { get; set; }
    }
}
