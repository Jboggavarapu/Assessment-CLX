using Assessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Interfaces
{
    public interface IAlarmData
    {
        public List<AlarmModel> GetAllAlarms();
         void AddAlarm(AlarmModel employee);
         AlarmModel GetAlarmData(string id);
         void UpdateAlarm(AlarmModel employee);
         void DeleteAlarm(string id);
    }
}
