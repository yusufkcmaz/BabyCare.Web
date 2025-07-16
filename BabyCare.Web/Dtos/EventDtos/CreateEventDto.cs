namespace BabyCare.Web.Dtos.EventDtos
{
    public class CreateEventDto
    {
     
        public string Title { get; set; }
        public DateTime Eventdate { get; set; }
        public string EventName { get; set; }
        public string Imageurl { get; set; }
        public string Description { get; set; }
    }
}
