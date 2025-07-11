﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace BabyCare.Web.DataAccess.Entities
{
    public class About
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string AboutId { get; set; }
        public string ?ImageUrl { get; set; }
        public string ?VideoUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
      
    }
}
