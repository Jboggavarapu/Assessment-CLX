using Assessment.Interfaces;
using Assessment.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Assessment.DataAccess
{
    public class AlarmDataAccess : IAlarmData
    {
        private readonly HttpClient _httpClient;
        AlarmsDBContext db = new AlarmsDBContext();
        //public AlarmDataAccess(HttpClient httpClient)
        //{
        //    _httpClient = httpClient;
        //}
        public List<AlarmModel> GetAllAlarms()
        {
            try
            {
                return db.AlarmRecords.Find(_ => true).ToList();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AddAlarm(AlarmModel alarm)
        {
            try
            {
                db.AlarmRecords.InsertOne(alarm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public AlarmModel GetAlarmData(string id)
        {
            try
            {
                FilterDefinition<AlarmModel> filterAlarmData = Builders<AlarmModel>.Filter.Eq("Id", id);
                return db.AlarmRecords.Find(filterAlarmData).FirstOrDefault();
            }
            catch { throw; }
        }
        public void UpdateAlarm(AlarmModel alarm)
        {
            try
            {
                db.AlarmRecords.ReplaceOne(filter: g => g.Id == alarm.Id, replacement: alarm);
            }
            catch { throw; }
        }
        public void DeleteAlarm(string id)
        {
            try
            {
                FilterDefinition<AlarmModel> alarmData = Builders<AlarmModel>.Filter.Eq("ID", id);
                db.AlarmRecords.DeleteOne(alarmData);
            }
            catch { throw; }
        }
    }
}

