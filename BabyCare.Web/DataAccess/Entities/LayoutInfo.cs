using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.DataAccess.Entities
{
    public class LayoutInfo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Description { get; set; }
        public string Location  { get; set; }
        public string PhoneNumber  { get; set; }
        public string Email  { get; set; }
        public string Service  { get; set; }

        public string WeekdayHours { get; set; }
        public string SaturdayHours { get; set; }


        public string FacebookUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string LinkedinUrl { get; set; }
    }
}
