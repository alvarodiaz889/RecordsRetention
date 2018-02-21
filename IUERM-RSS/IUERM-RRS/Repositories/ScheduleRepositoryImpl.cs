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
        private static Func<Schedule, ScheduleViewModel> GetModelFunc = EntityToModel;
        private static Func<Schedule,string, bool> GetByIdFunc = CompareById;
        private IMainRepository mainRepository = new MainRepositoryImpl();

        public List<ScheduleViewModel> GetAllRecords()
        {
            List<ScheduleViewModel> response = context.Schedules
                .OrderByDescending(o => o.SCH_CreationDate)
                .Select(GetModelFunc)
                .ToList();
            return response;
        }

        public ScheduleViewModel GetScheduleById(string id)
        {
            ScheduleViewModel model = context.Schedules
                .Where(o => o.SCH_ID.ToString() == id)
                .Select(GetModelFunc)
                .FirstOrDefault();
            if (model != null)
            {
                model.AreaScopes = mainRepository.GetAllAreaScopesDDL();
                model.DispositionOptions = mainRepository.GetAllDispositionOptionsDDL();
                model.GoverningPolicies = mainRepository.GetAllGoverningPoliciesDDL();
                model.GoverningRegulations = mainRepository.GetAllGoverningRegulationsDDL();
                model.GoverningStatutes = mainRepository.GetAllGoverningStatutesDDL();
                model.OfficeOfRecords = mainRepository.GetAllOfficeOfRecordsDDL();
                model.OfficialRecordMediums = mainRepository.GetAllOfficialRecordMediumsDDL();
                model.Retainers = mainRepository.GetAllRetainersDDL();
                model.Retentions = mainRepository.GetAllRetentionsDDL();
            }

            return model;
        }

        public void Insert(ScheduleViewModel svm)
        {
            Schedule schedule = ModelToEntity(svm);
            schedule.SCH_ID = Guid.NewGuid();
            schedule.SCH_CreationDate = DateTime.Now;
            context.Schedules.Add(schedule);
            context.SaveChanges();
        }

        public void Delete(ScheduleViewModel svm)
        {
            Schedule schedule = ModelToEntity(svm);
            context.Schedules.Attach(schedule);
            context.Schedules.Remove(schedule);
            context.SaveChanges();
        }

        public void Update(ScheduleViewModel svm)
        {
            Schedule schedule = ModelToEntity(svm);
            context.Schedules.Attach(schedule);
            context.Entry(schedule).State = EntityState.Modified;
            context.SaveChanges();
        }

        private static ScheduleViewModel EntityToModel(Schedule s)
        {
            return new ScheduleViewModel
            {
                SCH_ID = s.SCH_ID,
                SCH_StewardDomain = s.SCH_StewardDomain,
                SCH_RetentionArea = s.SCH_RetentionArea,
                SCH_RetentionSubArea = s.SCH_RetentionSubArea,
                SCH_AreaScopeId = s.SCH_AreaScopeId,
                SCH_RetentionAreaDescription = s.SCH_RetentionAreaDescription,
                SCH_Type = s.SCH_Type,
                SCH_OfficeId = s.SCH_OfficeId,
                SCH_Coordinator = s.SCH_Coordinator,
                SCH_RecordSeries = s.SCH_RecordSeries,
                SCH_RecordSeriesCode = s.SCH_RecordSeriesCode,
                SCH_Description = s.SCH_Description,
                SCH_RetentionId = s.SCH_RetentionId,
                SCH_Active = s.SCH_Active,
                SCH_Vital = s.SCH_Vital,
                SCH_GoverningStatutesId = s.SCH_GoverningStatutesId,
                SCH_GoverningRegulationsId = s.SCH_GoverningRegulationsId,
                SCH_GoverningPoliciesId = s.SCH_GoverningPoliciesId,
                SCH_Reason = s.SCH_Reason,
                SCH_RecordMedium = s.SCH_RecordMedium,
                SCH_RetainerId = s.SCH_RetainerId,
                SCH_DispositionId = s.SCH_DispositionId,
                SCH_RquiresCertDestruction = s.SCH_RquiresCertDestruction,
                SCH_CreationDate = s.SCH_CreationDate
            };
        }

        private static Schedule ModelToEntity(ScheduleViewModel svm)
        {
            return new Schedule
            {
                SCH_ID = svm.SCH_ID,
                SCH_StewardDomain = svm.SCH_StewardDomain,
                SCH_RetentionArea = svm.SCH_RetentionArea,
                SCH_RetentionSubArea = svm.SCH_RetentionSubArea,
                SCH_AreaScopeId = svm.SCH_AreaScopeId,
                SCH_RetentionAreaDescription = svm.SCH_RetentionAreaDescription,
                SCH_Type = svm.SCH_Type,
                SCH_OfficeId = svm.SCH_OfficeId,
                SCH_Coordinator = svm.SCH_Coordinator,
                SCH_RecordSeries = svm.SCH_RecordSeries,
                SCH_RecordSeriesCode = svm.SCH_RecordSeriesCode,
                SCH_Description = svm.SCH_Description,
                SCH_RetentionId = svm.SCH_RetentionId,
                SCH_Active = svm.SCH_Active,
                SCH_Vital = svm.SCH_Vital,
                SCH_GoverningStatutesId = svm.SCH_GoverningStatutesId,
                SCH_GoverningRegulationsId = svm.SCH_GoverningRegulationsId,
                SCH_GoverningPoliciesId = svm.SCH_GoverningPoliciesId,
                SCH_Reason = svm.SCH_Reason,
                SCH_RecordMedium = svm.SCH_RecordMedium,
                SCH_RetainerId = svm.SCH_RetainerId,
                SCH_DispositionId = svm.SCH_DispositionId,
                SCH_RquiresCertDestruction = svm.SCH_RquiresCertDestruction,
                SCH_CreationDate = svm.SCH_CreationDate
            };
        }

        private static bool CompareById(Schedule s,string id)
        {
            if (s.SCH_ID.ToString() == id)
                return true;
            else return false;
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}