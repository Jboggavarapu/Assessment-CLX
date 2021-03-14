using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using System.Text;
namespace Assessment.Models
{
    public class AlarmsDBContext
    {
        private readonly IMongoDatabase _mongoDatabase;
        public AlarmsDBContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _mongoDatabase = client.GetDatabase("AssessmentDataBase");
        }
        public IMongoCollection<AlarmModel> AlarmRecords
        {
            get
            {
                return _mongoDatabase.GetCollection<AlarmModel>("Alarms");
            }
        }
    }
}


