using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.DataAccess.Entities
{
    public class Event
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string EventId { get; set; }
        public string Title { get; set; }
        public DateTime Eventdate { get; set; }
        public string EventName { get; set; }
        public string Imageurl { get; set; }
        public string Description { get; set; }
    }
}
