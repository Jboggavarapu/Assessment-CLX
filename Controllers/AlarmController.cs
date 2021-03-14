using Assessment.Interfaces;
using Assessment.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class AlarmController : Controller
    {
        private readonly IAlarmData objAlarm;

        public AlarmController(IAlarmData _objalarm)
        {
            objAlarm = _objalarm;
        }
        public IActionResult Index()
        {
            var model = Get();
            return View(model);
        }

        [HttpGet]
        public IEnumerable<AlarmModel> Get()
        {
            return objAlarm.GetAllAlarms();
        }

        [HttpPost]
        public void Post([FromBody] AlarmModel alarm)
        {
            objAlarm.AddAlarm(alarm);
           
        }

        [HttpGet("{id}")]
        public AlarmModel Get(string id)
        {
            return objAlarm.GetAlarmData(id);
        }


        [HttpPut]
        public void Put([FromBody] AlarmModel alarm)
        {
            objAlarm.UpdateAlarm(alarm);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            objAlarm.DeleteAlarm(id);
        }

    }
}




