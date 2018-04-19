using IUERM_RRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IUERM_RRS.Repositories
{
    public class MainRepositoryImpl : IMainRepository
    {
        private IUERM_RSchedEntities context = new IUERM_RSchedEntities();

        #region AreaScope
        public List<AreaScopeViewModel> GetAllAreaScopes()
        {
            List<AreaScopeViewModel> list = context.AreaScopes
                .Select(o => new AreaScopeViewModel { Id = o.AS_Id, Name = o.AS_Scope })
                .OrderBy(o => o.Name)
                .ToList();
            return list;
        }

        public IEnumerable<SelectListItem> GetAllAreaScopesDDL()
        {
            List<SelectListItem> list = context.AreaScopes
                .Select(o => new SelectListItem { Value = o.AS_Id.ToString(), Text = o.AS_Scope })
                .OrderBy(o => o.Text)
                .ToList();

            return list;
        }

        public AreaScopeViewModel GetAreaScopeById(int id)
        {
            return context.AreaScopes.Where(o => o.AS_Id == id)
                .Select(o => new AreaScopeViewModel { Id = o.AS_Id, Name = o.AS_Scope })
                .FirstOrDefault();
        }
        public void InsertAreaScope(AreaScopeViewModel areaScopeVM)
        {
            AreaScope newRecord = new AreaScope { AS_Scope = areaScopeVM.Name.Trim() };
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
            try
            {
                AreaScope newRecord = new AreaScope { AS_Id = areaScopeVM.Id, AS_Scope = areaScopeVM.Name };
                context.AreaScopes.Attach(newRecord);
                context.AreaScopes.Remove(newRecord);
                context.SaveChanges();
            } catch (Exception ex)
            {
                throw ex;
            }
            
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

        public IEnumerable<SelectListItem> GetAllDispositionOptionsDDL()
        {
            List<SelectListItem> list = context.DispositionOptions
                .Select(o => new SelectListItem { Value = o.DOP_Id .ToString(), Text = o.DOP_Name })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
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
            DispositionOption newRecord = new DispositionOption { DOP_Id = ovm.Id , DOP_Name = ovm.Name.Trim() };
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
                .Select(o => new EventCodeViewModel
                    {
                        Id = o.ECD_Id,
                        Code = o.ECD_Code ?? string.Empty,
                        Description = o.ECD_Description ?? string.Empty
                    })
                .OrderBy(o => o.Code)
                .ToList();
        }

        public IEnumerable<SelectListItem> GetAllEventCodesDDL()
        {
            List<SelectListItem> list = context.EventCodes
                .Select(o => new SelectListItem
                    {
                        Value = o.ECD_Id.ToString() ,
                        Text = o.ECD_Code ?? string.Empty,
                })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
        }

        public EventCodeViewModel GetEventCodesById(int id)
        {
            return context.EventCodes.Where(o => o.ECD_Id == id)
                .Select(o => new EventCodeViewModel
                    {
                        Id = o.ECD_Id,
                        Code = o.ECD_Code ?? string.Empty,
                        Description = o.ECD_Description ?? string.Empty
                    })
                .FirstOrDefault();
        }
        public void InsertEventCodes(EventCodeViewModel ovm)
        {
            EventCode newRecord = new EventCode {
                ECD_Id = ovm.Id,
                ECD_Code = ovm.Code?.Trim(),
                ECD_Description = ovm.Description?.Trim()
            };
            context.EventCodes.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteEventCodes(EventCodeViewModel ovm)
        {
            EventCode newRecord = new EventCode
            {
                ECD_Id = ovm.Id,
                ECD_Code = ovm.Code?.Trim(),
                ECD_Description = ovm.Description?.Trim()
            };
            context.EventCodes.Attach(newRecord);
            context.EventCodes.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateEventCodes(EventCodeViewModel ovm)
        {
            EventCode newRecord = new EventCode
            {
                ECD_Id = ovm.Id,
                ECD_Code = ovm.Code?.Trim(),
                ECD_Description = ovm.Description?.Trim()
            };
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

        public IEnumerable<SelectListItem> GetAllGoverningPoliciesDDL()
        {
            List<SelectListItem> list = context.GoverningPolicies
                .Select(o => new SelectListItem { Value = o.GPO_Id.ToString(), Text = o.GPO_Name })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
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

        public IEnumerable<SelectListItem> GetAllGoverningRegulationsDDL()
        {
            List<SelectListItem> list = context.GoverningRegulations
                .Select(o => new SelectListItem { Value = o.GRE_Id.ToString(), Text = o.GRE_Name })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
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

        public IEnumerable<SelectListItem> GetAllGoverningStatutesDDL()
        {
            List<SelectListItem> list = context.GoverningStatutes
                .Select(o => new SelectListItem {
                    Value = o.GST_Id.ToString(),
                    Text = o.GST_Name.Length > 50 ? o.GST_Name.Substring(0, 50) + " ..." : o.GST_Name })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
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

        public IEnumerable<SelectListItem> GetAllOfficeOfRecordsDDL()
        {
            List<SelectListItem> list = context.OfficeOfRecords
                .Select(o => new SelectListItem { Value = o.OOR_Id.ToString(), Text = o.OOR_Name })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
        }

        public OfficeOfRecordViewModel GetOfficeOfRecordById(int id)
        {
            return context.OfficeOfRecords.Where(o => o.OOR_Id == id)
                .Select(o => new OfficeOfRecordViewModel { Id = o.OOR_Id, Name = o.OOR_Name.Trim(), Code = o.OOR_Code.Trim() })
                .FirstOrDefault();
        }
        public void InsertOfficeOfRecord(OfficeOfRecordViewModel ovm)
        {
            OfficeOfRecord newRecord = new OfficeOfRecord { OOR_Id = ovm.Id, OOR_Name = ovm.Name?.Trim(), OOR_Code = ovm.Code?.Trim() };
            context.OfficeOfRecords.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteOfficeOfRecord(OfficeOfRecordViewModel ovm)
        {
            OfficeOfRecord newRecord = new OfficeOfRecord { OOR_Id = ovm.Id, OOR_Name = ovm.Name.Trim(), OOR_Code = ovm.Code.Trim() };
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
        public List<OfficialRecordMediumVM> GetAllOfficialRecordMediums()
        {
            return context.OfficialRecordMediums
                .Select(o => new OfficialRecordMediumVM { Id = o.ORM_Id , Name = o.ORM_Name })
                .OrderBy(o => o.Name)
                .ToList();
        }

        public IEnumerable<SelectListItem> GetAllOfficialRecordMediumsDDL()
        {
            List<SelectListItem> list = context.OfficialRecordMediums
                .Select(o => new SelectListItem { Value = o.ORM_Id.ToString(), Text = o.ORM_Name })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
        }

        public OfficialRecordMediumVM GetOfficialRecordMediumById(int id)
        {
            return context.OfficialRecordMediums.Where(o => o.ORM_Id == id)
                .Select(o => new OfficialRecordMediumVM { Id = o.ORM_Id, Name = o.ORM_Name })
                .FirstOrDefault();
        }
        public void InsertOfficialRecordMedium(OfficialRecordMediumVM ovm)
        {
            OfficialRecordMedium newRecord = new OfficialRecordMedium { ORM_Id = ovm.Id , ORM_Name = ovm.Name };
            context.OfficialRecordMediums.Add(newRecord);
            context.SaveChanges();
        }
        public void DeleteOfficialRecordMedium(OfficialRecordMediumVM ovm)
        {
            OfficialRecordMedium newRecord = new OfficialRecordMedium { ORM_Id = ovm.Id, ORM_Name = ovm.Name };
            context.OfficialRecordMediums.Attach(newRecord);
            context.OfficialRecordMediums.Remove(newRecord);
            context.SaveChanges();
        }
        public void UpdateOfficialRecordMedium(OfficialRecordMediumVM ovm)
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

        public IEnumerable<SelectListItem> GetAllRetainersDDL()
        {
            List<SelectListItem> list = context.Retainers
                .Select(o => new SelectListItem { Value = o.RET_Id.ToString(), Text = o.RET_Name })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
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
                .Select(o => new RetentionViewModel { Id = o.RET_Id, BasedOnCode = o.RET_BasedOnCode, BaseOnDescription = o.RET_BaseOnDescription })
                .OrderBy(o => o.BasedOnCode)
                .ToList();
        }

        public IEnumerable<SelectListItem> GetAllRetentionsDDL()
        {
            List<SelectListItem> list = context.Retentions
                .Select(o => new SelectListItem { Value = o.RET_Id.ToString(), Text = o.RET_BasedOnCode + "-" + o.RET_BaseOnDescription })
                .OrderBy(o => o.Text)
                .ToList();
            
            return list;
        }   
        public RetentionViewModel GetRetentionById(int id)
        {
            return context.Retentions.Where(o => o.RET_Id == id)
                .Select(o => new RetentionViewModel
                {
                    Id = o.RET_Id,
                    BasedOnCode = o.RET_BasedOnCode,
                    BaseOnDescription = o.RET_BaseOnDescription
                })
                .FirstOrDefault();
        }
        public void InsertRetention(RetentionViewModel ovm)
        {
            Retention newRecord = new Retention
            {
                RET_Id = ovm.Id,
                RET_BasedOnCode = ovm.BasedOnCode,
                RET_BaseOnDescription = ovm.BaseOnDescription
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
                RET_BaseOnDescription = ovm.BaseOnDescription
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
                RET_BaseOnDescription = ovm.BaseOnDescription
            };
            context.Retentions.Attach(newRecord);
            context.Entry(newRecord).State = EntityState.Modified;
            context.SaveChanges();
        }
        #endregion

        #region CustomSelectionLists
        public IEnumerable<SelectListItem> GetActiveDDL()
        {
            return new List<SelectListItem> {
                new SelectListItem { Value = "true" , Text = "Active" },
                new SelectListItem { Value = "false" , Text = "Inactive" }
            };
        }

        public IEnumerable<SelectListItem> GetYesNoDDL()
        {
            return new List<SelectListItem> {
                new SelectListItem { Value = "true" , Text = "Yes" },
                new SelectListItem { Value = "false" , Text = "No" }
            };
        }

        public IEnumerable<SelectListItem> GetTypesDDL()
        {
            //Values hardcoded for now, there are just 2 types in the requirements
            return new List<SelectListItem> {
                new SelectListItem { Value = "General" , Text = "General" },
                new SelectListItem { Value = "Unit Specific" , Text = "Unit Specific" }
            };
        }

        public IEnumerable<SelectListItem> GetDDLbyName(string name)
        {
            IEnumerable<SelectListItem> list = null;
            switch (name)
            {
                case "_AreaScope":
                    list = GetAllAreaScopesDDL();
                    break;
                case "_DispositionOption":
                    list = GetAllDispositionOptionsDDL();
                    break;
                case "_EventCode":
                    list = GetAllEventCodesDDL();
                    break;
                case "_GoverningPolicy":
                    list = GetAllGoverningPoliciesDDL();
                    break;
                case "_GoverningRegulation":
                    list = GetAllGoverningRegulationsDDL();
                    break;
                case "_GoverningStatute":
                    list = GetAllGoverningStatutesDDL();
                    break;
                case "_OfficeOfRecord":
                    list = GetAllOfficeOfRecordsDDL();
                    break;
                case "_OfficialRecordMedium":
                    list = GetAllOfficialRecordMediumsDDL();
                    break;
                case "_Retainer":
                    list = GetAllRetainersDDL();
                    break;
                case "_Retention":
                case "_RetentionEventCode":
                    list = GetAllRetentionsDDL();
                    break;
                    
            }
            return list;
        }

        public List<ColumnManager> GetColumnsConfig()
        {
            return context.ColumnManagers.AsNoTracking().ToList();
        }

        #endregion



        public void Dispose()
        {
            context.Dispose();
        }

        
    }
}