using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using IUERM_RRS.ViewModels;

namespace IUERM_RRS.Repositories
{
    public class ScheduleRepositoryImpl : IScheduleRepository
    {
        private IUERM_RSchedEntities context = new IUERM_RSchedEntities();

        public List<ScheduleViewModel> GetAllRecords()
        {
            List<ScheduleViewModel> response = context.Schedules
                .Select(o => new ScheduleViewModel
                {
                    SCH_ID = o.SCH_ID,
                    SCH_StewardDomain = o.SCH_StewardDomain,
                    SCH_RetentionArea = o.SCH_RetentionArea,
                    SCH_RetentionSubArea = o.SCH_RetentionSubArea,
                    SCH_RetentionAreaDescription = o.SCH_RetentionAreaDescription,
                    SCH_Type = o.SCH_Type,
                    SCH_Coordinator = o.SCH_Coordinator,
                    SCH_RecordSeries = o.SCH_RecordSeries,
                    SCH_RecordSeriesCode = o.SCH_RecordSeriesCode,
                    SCH_Description = o.SCH_Description,
                    SCH_Active = (o.SCH_Active != null) ? (bool)o.SCH_Active : false,
                    SCH_Vital = (o.SCH_Vital != null) ? (bool)o.SCH_Vital : false,
                    SCH_Reason = o.SCH_Reason,
                    SCH_RquiresCertDestruction = o.SCH_RquiresCertDestruction,
                    SCH_CreationDate = o.SCH_CreationDate,
                }).ToList();
            return response;
        }

        public ScheduleViewModel GetScheduleById(string id)
        {
            return context.Schedules
                .Where(o => o.SCH_ID == Guid.Parse(id))
                .Select(o => new ScheduleViewModel
                {
                    SCH_ID = o.SCH_ID,
                    SCH_StewardDomain = o.SCH_StewardDomain,
                    SCH_RetentionArea = o.SCH_RetentionArea,
                    SCH_RetentionSubArea = o.SCH_RetentionSubArea,
                    SCH_RetentionAreaDescription = o.SCH_RetentionAreaDescription,
                    SCH_Type = o.SCH_Type,
                    SCH_Coordinator = o.SCH_Coordinator,
                    SCH_RecordSeries = o.SCH_RecordSeries,
                    SCH_RecordSeriesCode = o.SCH_RecordSeriesCode,
                    SCH_Description = o.SCH_Description,
                    SCH_Active = (o.SCH_Active!= null)? (bool)o.SCH_Active: false,
                    SCH_Vital = (o.SCH_Vital != null) ? (bool)o.SCH_Vital : false,
                    SCH_Reason = o.SCH_Reason,
                    SCH_RquiresCertDestruction = o.SCH_RquiresCertDestruction,
                    SCH_CreationDate = o.SCH_CreationDate
                }).FirstOrDefault();
        }

        public void Insert(ScheduleViewModel schedule)
        {
            Schedule s = new Schedule
            {
                SCH_ID = schedule.SCH_ID,
                SCH_StewardDomain = schedule.SCH_StewardDomain,
                SCH_RetentionArea = schedule.SCH_RetentionArea,
                SCH_RetentionSubArea = schedule.SCH_RetentionSubArea,
                SCH_RetentionAreaDescription = schedule.SCH_RetentionAreaDescription,
                SCH_Type = schedule.SCH_Type,
                SCH_Coordinator = schedule.SCH_Coordinator,
                SCH_RecordSeries = schedule.SCH_RecordSeries,
                SCH_RecordSeriesCode = schedule.SCH_RecordSeriesCode,
                SCH_Description = schedule.SCH_Description,
                SCH_Active = schedule.SCH_Active,
                SCH_Vital = schedule.SCH_Vital,
                SCH_Reason = schedule.SCH_Reason,
                SCH_RquiresCertDestruction = schedule.SCH_RquiresCertDestruction,
                SCH_CreationDate = schedule.SCH_CreationDate
            };
            context.Schedules.Add(s);
            context.SaveChanges();
        }

        public void Delete(ScheduleViewModel schedule)
        {
            Schedule s = new Schedule
            {
                SCH_ID = schedule.SCH_ID,
                SCH_StewardDomain = schedule.SCH_StewardDomain,
                SCH_RetentionArea = schedule.SCH_RetentionArea,
                SCH_RetentionSubArea = schedule.SCH_RetentionSubArea,
                SCH_RetentionAreaDescription = schedule.SCH_RetentionAreaDescription,
                SCH_Type = schedule.SCH_Type,
                SCH_Coordinator = schedule.SCH_Coordinator,
                SCH_RecordSeries = schedule.SCH_RecordSeries,
                SCH_RecordSeriesCode = schedule.SCH_RecordSeriesCode,
                SCH_Description = schedule.SCH_Description,
                SCH_Active = schedule.SCH_Active,
                SCH_Vital = schedule.SCH_Vital,
                SCH_Reason = schedule.SCH_Reason,
                SCH_RquiresCertDestruction = schedule.SCH_RquiresCertDestruction,
                SCH_CreationDate = schedule.SCH_CreationDate
            };
            context.Schedules.Attach(s);
            context.Schedules.Remove(s);
            context.SaveChanges();
        }

        public void Update(ScheduleViewModel schedule)
        {
            Schedule s = new Schedule
            {
                SCH_ID = schedule.SCH_ID,
                SCH_StewardDomain = schedule.SCH_StewardDomain,
                SCH_RetentionArea = schedule.SCH_RetentionArea,
                SCH_RetentionSubArea = schedule.SCH_RetentionSubArea,
                SCH_RetentionAreaDescription = schedule.SCH_RetentionAreaDescription,
                SCH_Type = schedule.SCH_Type,
                SCH_Coordinator = schedule.SCH_Coordinator,
                SCH_RecordSeries = schedule.SCH_RecordSeries,
                SCH_RecordSeriesCode = schedule.SCH_RecordSeriesCode,
                SCH_Description = schedule.SCH_Description,
                SCH_Active = schedule.SCH_Active,
                SCH_Vital = schedule.SCH_Vital,
                SCH_Reason = schedule.SCH_Reason,
                SCH_RquiresCertDestruction = schedule.SCH_RquiresCertDestruction,
                SCH_CreationDate = schedule.SCH_CreationDate
            };
            context.Schedules.Attach(s);
            context.Entry(s).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}