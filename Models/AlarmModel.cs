using MongoDB.Bson;
using MongoDB.Bson.IO;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assessment.Models
{
    public class AlarmModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
       
        public string Id { get; set; }
        public DateTime Time { get; set; }
        public string Alarm { get; set; }
        public string Equipment { get; set; }
        public AlarmModel()
        {
            Time = DateTime.Now;
        }
    }

   
}
