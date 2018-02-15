using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace IUERM_RRS.Repositories
{
    public class MainRepositoryImpl : IMainRepository
    {
        private IUERM_RSchedEntities context = new IUERM_RSchedEntities();

        #region AreaScope
        public List<AreaScope> GetAllAreaScopes()
        {
            return context.AreaScopes.ToList();
        }
        public AreaScope GetAreaScopeById(int id)
        {
            return context.AreaScopes.Where(o => o.AS_Id == id).FirstOrDefault();
        }
        public void InsertAreaScope(AreaScope areaScope)
        {
            context.AreaScopes.Add(areaScope);
            context.SaveChanges();
        }

        public void UpdateAreaScope(AreaScope areaScope)
        {
            context.AreaScopes.Attach(areaScope);
            context.Entry(areaScope).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteAreaScope(AreaScope areaScope)
        {
            context.AreaScopes.Remove(areaScope);
            context.SaveChanges();
        }
        #endregion

        #region DispositionOptions

        public List<DispositionOption> GetAllDispositionOptions()
        {
            return context.DispositionOptions.ToList();
        }
        public DispositionOption GetDispositionOptionsById(int id)
        {
            return context.DispositionOptions.Where(o => o.DOP_Id == id).FirstOrDefault();
        }
        public void InsertDispositionOption(DispositionOption dispositionOption)
        {
            context.DispositionOptions.Add(dispositionOption);
            context.SaveChanges();
        }
        public void DeleteDispositionOption(DispositionOption dispositionOption)
        {
            context.DispositionOptions.Remove(dispositionOption);
            context.SaveChanges();
        }
        public void UpdateDispositionOption(DispositionOption dispositionOption)
        {
            context.DispositionOptions.Attach(dispositionOption);
            context.Entry(dispositionOption).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region EventCodes
        public List<EventCode> GetAllEventCodes()
        {
            return context.EventCodes.ToList();
        }
        public EventCode GetEventCodesByCode(string code)
        {
            return context.EventCodes.Where(o => o.ECD_Code == code).FirstOrDefault();
        }
        public void InsertEventCodes(EventCode eventCode)
        {
            context.EventCodes.Add(eventCode);
            context.SaveChanges();
        }
        public void DeleteEventCodes(EventCode eventCode)
        {
            context.EventCodes.Remove(eventCode);
            context.SaveChanges();
        }
        public void UpdateEventCodes(EventCode eventCode)
        {
            context.EventCodes.Attach(eventCode);
            context.Entry(eventCode).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region GoverningPolicies

        public List<GoverningPolicy> GetAllGoverningPolicies()
        {
            return context.GoverningPolicies.ToList();
        }
        public GoverningPolicy GetGoverningPolicyById(int id)
        {
            return context.GoverningPolicies.Where(o => o.GPO_Id == id).FirstOrDefault();
        }
        public void InsertGoverningPolicy(GoverningPolicy governingPolicy)
        {
            context.GoverningPolicies.Add(governingPolicy);
            context.SaveChanges();
        }
        public void DeleteGoverningPolicy(GoverningPolicy governingPolicy)
        {
            context.GoverningPolicies.Remove(governingPolicy);
            context.SaveChanges();
        }
        public void UpdateGoverningPolicy(GoverningPolicy governingPolicy)
        {
            context.GoverningPolicies.Attach(governingPolicy);
            context.Entry(governingPolicy).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region GoverningRegulations
        public List<GoverningRegulation> GetAllGoverningRegulations()
        {
            return context.GoverningRegulations.ToList();
        }
        public GoverningRegulation GetGoverningRegulationById(int id)
        {
            return context.GoverningRegulations.Where(o => o.GRE_Id == id).FirstOrDefault();
        }
        public void InsertGoverningRegulation(GoverningRegulation governingRegulation)
        {
            context.GoverningRegulations.Add(governingRegulation);
            context.SaveChanges();
        }
        public void DeleteGoverningRegulation(GoverningRegulation governingRegulation)
        {
            context.GoverningRegulations.Remove(governingRegulation);
            context.SaveChanges();
        }
        public void UpdateGoverningRegulation(GoverningRegulation governingRegulation)
        {
            context.GoverningRegulations.Attach(governingRegulation);
            context.Entry(governingRegulation).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region GoverningStatutes
        public List<GoverningStatute> GetAllGoverningStatutes()
        {
            return context.GoverningStatutes.ToList();
        }
        public GoverningStatute GetGoverningStatuteById(int id)
        {
            return context.GoverningStatutes.Where(o => o.GST_Id == id).FirstOrDefault();
        }
        public void InsertGoverningStatutes(GoverningStatute governingStatute)
        {
            context.GoverningStatutes.Add(governingStatute);
            context.SaveChanges();
        }
        public void DeleteGoverningStatutes(GoverningStatute governingStatute)
        {
            context.GoverningStatutes.Remove(governingStatute);
            context.SaveChanges();
        }
        public void UpdateGoverningStatutes(GoverningStatute governingStatute)
        {
            context.GoverningStatutes.Attach(governingStatute);
            context.Entry(governingStatute).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region OfficeOfRecords
        public List<OfficeOfRecord> GetAllOfficeOfRecords()
        {
            return context.OfficeOfRecords.ToList();
        }
        public OfficeOfRecord GetOfficeOfRecordById(int id)
        {
            return context.OfficeOfRecords.Where(o => o.OOR_Id == id).FirstOrDefault();
        }
        public void InsertOfficeOfRecord(OfficeOfRecord officeOfRecord)
        {
            context.OfficeOfRecords.Add(officeOfRecord);
            context.SaveChanges();
        }
        public void DeleteOfficeOfRecord(OfficeOfRecord officeOfRecord)
        {
            context.OfficeOfRecords.Remove(officeOfRecord);
            context.SaveChanges();
        }
        public void UpdateOfficeOfRecord(OfficeOfRecord officeOfRecord)
        {
            context.OfficeOfRecords.Attach(officeOfRecord);
            context.Entry(officeOfRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region OfficialRecordMedium
        public List<OfficialRecordMedium> GetAllOfficialRecordMediums()
        {
            return context.OfficialRecordMediums.ToList();
        }
        public OfficialRecordMedium GetOfficialRecordMediumById(int id)
        {
            return context.OfficialRecordMediums.Where(o => o.ORM_Id == id).FirstOrDefault();
        }
        public void InsertOfficialRecordMedium(OfficialRecordMedium officialRecordMedium)
        {
            context.OfficialRecordMediums.Add(officialRecordMedium);
            context.SaveChanges();
        }
        public void DeleteOfficialRecordMedium(OfficialRecordMedium officialRecordMedium)
        {
            context.OfficialRecordMediums.Remove(officialRecordMedium);
            context.SaveChanges();
        }
        public void UpdateOfficialRecordMedium(OfficialRecordMedium officialRecordMedium)
        {
            context.OfficialRecordMediums.Attach(officialRecordMedium);
            context.Entry(officialRecordMedium).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region Retainers

        public List<Retainer> GetAllRetainers()
        {
            return context.Retainers.ToList();
        }
        public Retainer GetRetainerById(int id)
        {
            return context.Retainers.Where(o => o.RET_Id == id).FirstOrDefault();
        }
        public void InsertRetainer(Retainer retainer)
        {
            context.Retainers.Add(retainer);
            context.SaveChanges();
        }
        public void DeleteRetainer(Retainer retainer)
        {
            context.Retainers.Remove(retainer);
            context.SaveChanges();
        }
        public void UpdateRetainer(Retainer retainer)
        {
            context.Retainers.Attach(retainer);
            context.Entry(retainer).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region Retention
        public List<Retention> GetAllRetentions()
        {
            return context.Retentions.ToList();
        }
        public Retention GetRetentionById(int id)
        {
            return context.Retentions.Where(o => o.RET_Id == id).FirstOrDefault();
        }
        public void InsertRetention(Retention retention)
        {
            context.Retentions.Add(retention);
            context.SaveChanges();
        }
        public void DeleteRetention(Retention retention)
        {
            context.Retentions.Remove(retention);
            context.SaveChanges();
        }
        public void UpdateRetention(Retention retention)
        {
            context.Retentions.Attach(retention);
            context.Entry(retention).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}