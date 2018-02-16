using IUERM_RRS.ViewModels;
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
        public List<AreaScopeViewModel> GetAllAreaScopes()
        {
            return context.AreaScopes
                .Select(o => new AreaScopeViewModel { Id = o.AS_Id, Name = o.AS_Scope })
                .OrderBy(o => o.Name)
                .ToList();
        }
        public AreaScopeViewModel GetAreaScopeById(int id)
        {
            return context.AreaScopes.Where(o => o.AS_Id == id)
                .Select(o => new AreaScopeViewModel { Id = o.AS_Id, Name = o.AS_Scope })
                .FirstOrDefault();
        }
        public void InsertAreaScope(AreaScopeViewModel areaScopeVM)
        {
            AreaScope newRecord = new AreaScope { AS_Scope = areaScopeVM.Name };
            context.AreaScopes.Add(newRecord);
            context.SaveChanges();
        }

        public void UpdateAreaScope(AreaScopeViewModel areaScopeVM)
        {
            AreaScope newRecord = new AreaScope { AS_Id = areaScopeVM.Id, AS_Scope = areaScopeVM.Name };
            context.AreaScopes.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        public void DeleteAreaScope(AreaScopeViewModel areaScopeVM)
        {
            AreaScope newRecord = new AreaScope { AS_Id = areaScopeVM.Id, AS_Scope = areaScopeVM.Name };
            context.AreaScopes.Attach(newRecord);
            context.AreaScopes.Remove(newRecord);
            context.SaveChanges();
        }
        #endregion

        #region DispositionOptions

        public List<DispositionOptionViewModel> GetAllDispositionOptions()
        {
            return context.DispositionOptions
                .Select(o => new DispositionOptionViewModel { Id = o.DOP_Id, Name = o.DOP_Name })
                .OrderBy(o => o.Name)
                .ToList();
        }
        public DispositionOptionViewModel GetDispositionOptionsById(int id)
        {
            return context.DispositionOptions
                .Where(o => o.DOP_Id == id)
                .Select(o => new DispositionOptionViewModel { Id = o.DOP_Id, Name = o.DOP_Name})
                .FirstOrDefault();
        }
        public void InsertDispositionOption(DispositionOptionViewModel ovm)
        {
            DispositionOption newRecord = new DispositionOption { DOP_Id = ovm.Id , DOP_Name = ovm.Name };
            context.DispositionOptions.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteDispositionOption(DispositionOptionViewModel ovm)
        {
            DispositionOption newRecord = new DispositionOption { DOP_Id = ovm.Id, DOP_Name = ovm.Name };
            context.DispositionOptions.Attach(newRecord);
            context.DispositionOptions.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateDispositionOption(DispositionOptionViewModel ovm)
        {
            DispositionOption newRecord = new DispositionOption { DOP_Id = ovm.Id, DOP_Name = ovm.Name };
            context.DispositionOptions.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region EventCodes
        public List<EventCodeViewModel> GetAllEventCodes()
        {
            return context.EventCodes
                .Select(o => new EventCodeViewModel { Code = o.ECD_Code , Description = o.ECD_Description })
                .OrderBy(o => o.Description)
                .ToList();
        }
        public EventCodeViewModel GetEventCodesByCode(string code)
        {
            return context.EventCodes.Where(o => o.ECD_Code == code)
                .Select(o => new EventCodeViewModel { Code = o.ECD_Code, Description = o.ECD_Description })
                .FirstOrDefault();
        }
        public void InsertEventCodes(EventCodeViewModel ovm)
        {
            EventCode newRecord = new EventCode { ECD_Code = ovm.Code, ECD_Description = ovm.Description };
            context.EventCodes.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteEventCodes(EventCodeViewModel ovm)
        {
            EventCode newRecord = new EventCode { ECD_Code = ovm.Code, ECD_Description = ovm.Description };
            context.EventCodes.Attach(newRecord);
            context.EventCodes.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateEventCodes(EventCodeViewModel ovm)
        {
            EventCode newRecord = new EventCode { ECD_Code = ovm.Code, ECD_Description = ovm.Description };
            context.EventCodes.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region GoverningPolicies

        public List<IdNameViewModel> GetAllGoverningPolicies()
        {
            return context.GoverningPolicies
                .Select(o => new IdNameViewModel { Id = o.GPO_Id , Name = o.GPO_Name })
                .OrderBy(o => o.Name)
                .ToList();
        }
        public IdNameViewModel GetGoverningPolicyById(int id)
        {
            return context.GoverningPolicies.Where(o => o.GPO_Id == id)
                .Select(o => new IdNameViewModel { Id = o.GPO_Id, Name = o.GPO_Name })
                .FirstOrDefault();
        }
        public void InsertGoverningPolicy(IdNameViewModel ovm)
        {
            GoverningPolicy newRecord = new GoverningPolicy { GPO_Id = ovm.Id, GPO_Name = ovm.Name };
            context.GoverningPolicies.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteGoverningPolicy(IdNameViewModel ovm)
        {
            GoverningPolicy newRecord = new GoverningPolicy { GPO_Id = ovm.Id, GPO_Name = ovm.Name };
            context.GoverningPolicies.Attach(newRecord);
            context.GoverningPolicies.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateGoverningPolicy(IdNameViewModel ovm)
        {
            GoverningPolicy newRecord = new GoverningPolicy { GPO_Id = ovm.Id, GPO_Name = ovm.Name };
            context.GoverningPolicies.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region GoverningRegulations
        public List<IdNameViewModel> GetAllGoverningRegulations()
        {
            return context.GoverningRegulations
                .Select(o => new IdNameViewModel { Id = o.GRE_Id , Name = o.GRE_Name })
                .OrderBy(o => o.Name)
                .ToList();
        }
        public IdNameViewModel GetGoverningRegulationById(int id)
        {
            return context.GoverningRegulations.Where(o => o.GRE_Id == id)
                .Select(o => new IdNameViewModel { Id = o.GRE_Id, Name = o.GRE_Name })
                .FirstOrDefault();
        }
        public void InsertGoverningRegulation(IdNameViewModel ovm)
        {
            GoverningRegulation newRecord = new GoverningRegulation { GRE_Id = ovm.Id , GRE_Name = ovm.Name};
            context.GoverningRegulations.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteGoverningRegulation(IdNameViewModel ovm)
        {
            GoverningRegulation newRecord = new GoverningRegulation { GRE_Id = ovm.Id, GRE_Name = ovm.Name };
            context.GoverningRegulations.Attach(newRecord);
            context.GoverningRegulations.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateGoverningRegulation(IdNameViewModel ovm)
        {
            GoverningRegulation newRecord = new GoverningRegulation { GRE_Id = ovm.Id, GRE_Name = ovm.Name };
            context.GoverningRegulations.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region GoverningStatutes
        public List<IdNameViewModel> GetAllGoverningStatutes()
        {
            return context.GoverningStatutes
                .Select(o => new IdNameViewModel { Id = o.GST_Id , Name = o.GST_Name })
                .OrderBy(o => o.Name)
                .ToList();
        }
        public IdNameViewModel GetGoverningStatuteById(int id)
        {
            return context.GoverningStatutes.Where(o => o.GST_Id == id)
                .Select(o => new IdNameViewModel { Id = o.GST_Id, Name = o.GST_Name })
                .FirstOrDefault();
        }
        public void InsertGoverningStatutes(IdNameViewModel ovm)
        {
            GoverningStatute newRecord = new GoverningStatute { GST_Id = ovm.Id, GST_Name = ovm.Name };
            context.GoverningStatutes.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteGoverningStatutes(IdNameViewModel ovm)
        {
            GoverningStatute newRecord = new GoverningStatute { GST_Id = ovm.Id, GST_Name = ovm.Name };
            context.GoverningStatutes.Attach(newRecord);
            context.GoverningStatutes.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateGoverningStatutes(IdNameViewModel ovm)
        {
            GoverningStatute newRecord = new GoverningStatute { GST_Id = ovm.Id, GST_Name = ovm.Name };
            context.GoverningStatutes.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region OfficeOfRecords
        public List<OfficeOfRecordViewModel> GetAllOfficeOfRecords()
        {
            return context.OfficeOfRecords
                .Select(o => new OfficeOfRecordViewModel { Id = o.OOR_Id , Name = o.OOR_Name, Code = o.OOR_Code })
                .OrderBy(o => o.Code)
                .ToList();
        }
        public OfficeOfRecordViewModel GetOfficeOfRecordById(int id)
        {
            return context.OfficeOfRecords.Where(o => o.OOR_Id == id)
                .Select(o => new OfficeOfRecordViewModel { Id = o.OOR_Id, Name = o.OOR_Name, Code = o.OOR_Code })
                .FirstOrDefault();
        }
        public void InsertOfficeOfRecord(OfficeOfRecordViewModel ovm)
        {
            OfficeOfRecord newRecord = new OfficeOfRecord { OOR_Id = ovm.Id, OOR_Name = ovm.Name, OOR_Code = ovm.Code };
            context.OfficeOfRecords.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteOfficeOfRecord(OfficeOfRecordViewModel ovm)
        {
            OfficeOfRecord newRecord = new OfficeOfRecord { OOR_Id = ovm.Id, OOR_Name = ovm.Name, OOR_Code = ovm.Code };
            context.OfficeOfRecords.Attach(newRecord);
            context.OfficeOfRecords.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateOfficeOfRecord(OfficeOfRecordViewModel ovm)
        {
            OfficeOfRecord newRecord = new OfficeOfRecord { OOR_Id = ovm.Id, OOR_Name = ovm.Name, OOR_Code = ovm.Code };
            context.OfficeOfRecords.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region OfficialRecordMedium
        public List<IdNameViewModel> GetAllOfficialRecordMediums()
        {
            return context.OfficialRecordMediums
                .Select(o => new IdNameViewModel { Id = o.ORM_Id , Name = o.ORM_Name })
                .OrderBy(o => o.Name)
                .ToList();
        }
        public IdNameViewModel GetOfficialRecordMediumById(int id)
        {
            return context.OfficialRecordMediums.Where(o => o.ORM_Id == id)
                .Select(o => new IdNameViewModel { Id = o.ORM_Id, Name = o.ORM_Name })
                .FirstOrDefault();
        }
        public void InsertOfficialRecordMedium(IdNameViewModel ovm)
        {
            OfficialRecordMedium newRecord = new OfficialRecordMedium { ORM_Id = ovm.Id , ORM_Name = ovm.Name };
            context.OfficialRecordMediums.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteOfficialRecordMedium(IdNameViewModel ovm)
        {
            OfficialRecordMedium newRecord = new OfficialRecordMedium { ORM_Id = ovm.Id, ORM_Name = ovm.Name };
            context.OfficialRecordMediums.Attach(newRecord);
            context.OfficialRecordMediums.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateOfficialRecordMedium(IdNameViewModel ovm)
        {
            OfficialRecordMedium newRecord = new OfficialRecordMedium { ORM_Id = ovm.Id, ORM_Name = ovm.Name };
            context.OfficialRecordMediums.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region Retainers

        public List<IdNameViewModel> GetAllRetainers()
        {
            return context.Retainers
                .Select(o => new IdNameViewModel { Id = o.RET_Id , Name = o.RET_Name })
                .OrderBy(o => o.Name)
                .ToList();
        }
        public IdNameViewModel GetRetainerById(int id)
        {
            return context.Retainers.Where(o => o.RET_Id == id)
                .Select(o => new IdNameViewModel { Id = o.RET_Id, Name = o.RET_Name })
                .FirstOrDefault();
        }
        public void InsertRetainer(IdNameViewModel ovm)
        {
            Retainer newRecord = new Retainer { RET_Id = ovm.Id, RET_Name = ovm.Name };
            context.Retainers.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteRetainer(IdNameViewModel ovm)
        {
            Retainer newRecord = new Retainer { RET_Id = ovm.Id, RET_Name = ovm.Name };
            context.Retainers.Attach(newRecord);
            context.Retainers.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateRetainer(IdNameViewModel ovm)
        {
            Retainer newRecord = new Retainer { RET_Id = ovm.Id, RET_Name = ovm.Name };
            context.Retainers.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region Retention
        public List<RetentionViewModel> GetAllRetentions()
        {
            return context.Retentions
                .Select(o => new RetentionViewModel
                    {
                        Id = o.RET_Id, BasedOnCode = o.RET_BasedOnCode,
                        BaseOnDescription = o.RET_BaseOnDescription, Period = o.RET_Period,
                        EventCode = o.RET_EventCode
                    })
                 .OrderBy(o => o.BasedOnCode)
                .ToList();
        }
        public RetentionViewModel GetRetentionById(int id)
        {
            return context.Retentions.Where(o => o.RET_Id == id)
                .Select(o => new RetentionViewModel
                {
                    Id = o.RET_Id,
                    BasedOnCode = o.RET_BasedOnCode,
                    BaseOnDescription = o.RET_BaseOnDescription,
                    Period = o.RET_Period,
                    EventCode = o.RET_EventCode
                })
                .FirstOrDefault();
        }
        public void InsertRetention(RetentionViewModel ovm)
        {
            Retention newRecord = new Retention
            {
                RET_Id = ovm.Id,
                RET_BasedOnCode = ovm.BasedOnCode,
                RET_BaseOnDescription = ovm.BaseOnDescription,
                RET_EventCode = ovm.EventCode,
                RET_Period = ovm.Period
            };
            context.Retentions.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteRetention(RetentionViewModel ovm)
        {
            Retention newRecord = new Retention
            {
                RET_Id = ovm.Id,
                RET_BasedOnCode = ovm.BasedOnCode,
                RET_BaseOnDescription = ovm.BaseOnDescription,
                RET_EventCode = ovm.EventCode,
                RET_Period = ovm.Period
            };
            context.Retentions.Attach(newRecord);
            context.Retentions.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateRetention(RetentionViewModel ovm)
        {
            Retention newRecord = new Retention
            {
                RET_Id = ovm.Id,
                RET_BasedOnCode = ovm.BasedOnCode,
                RET_BaseOnDescription = ovm.BaseOnDescription,
                RET_EventCode = ovm.EventCode,
                RET_Period = ovm.Period
            };
            context.Retentions.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}