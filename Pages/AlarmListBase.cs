using Assessment.DataAccess;
using Assessment.Interfaces;
using Assessment.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Pages
{
    public class AlarmListBase : ComponentBase
    {
        public List<AlarmModel> Alarms;

        public IAlarmData alarmService { get; set; }
        // private readonly IAlarmData _alarmData;

        public AlarmListBase()
        {
            alarmService = new AlarmDataAccess();
        }
        protected override  async Task  OnInitializedAsync()
        {
            Alarms = new List<AlarmModel>();
            Alarms = alarmService.GetAllAlarms();
            //GetAlarmList();
            // return base.OnInitializedAsync();
            //return results;
        }

        //private void GetAlarmList()
        //{
        //    var alarm1 = new AlarmModel
        //    {
        //        Id = "1",
        //        Alarm = "Test1",
        //        Time = DateTime.Now.AddDays(-2),
        //        Equipment = "Door"

        //    };
        //    var alarm2 = new AlarmModel
        //    {
        //        Id = "2",
        //        Alarm = "Test2",
        //        Time = DateTime.Now.AddDays(-1),
        //        Equipment = "House"

        //    };
        //    Alarms = new List<AlarmModel> { alarm1, alarm2 };
        //}
       
    }
}
