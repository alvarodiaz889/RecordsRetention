using IUERM_RRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace IUERM_RRS.Repositories
{
    public interface IMainRepository
    {
        //Area Scope
        List<AreaScopeViewModel> GetAllAreaScopes();
        IEnumerable<SelectListItem> GetAllAreaScopesDDL();
        AreaScopeViewModel GetAreaScopeById(int id);
        void InsertAreaScope(AreaScopeViewModel areaScope);
        void DeleteAreaScope(AreaScopeViewModel areaScope);
        void UpdateAreaScope(AreaScopeViewModel areaScope);

        //DispositionOptions
        List<DispositionOptionViewModel> GetAllDispositionOptions();
        IEnumerable<SelectListItem> GetAllDispositionOptionsDDL();
        DispositionOptionViewModel GetDispositionOptionsById(int id);
        void InsertDispositionOption(DispositionOptionViewModel dispositionOption);
        void DeleteDispositionOption(DispositionOptionViewModel dispositionOption);
        void UpdateDispositionOption(DispositionOptionViewModel dispositionOption);

        //EventCodes
        List<EventCodeViewModel> GetAllEventCodes();
        IEnumerable<SelectListItem> GetAllEventCodesDDL();
        EventCodeViewModel GetEventCodesById(int id);
        void InsertEventCodes(EventCodeViewModel eventCode);
        void DeleteEventCodes(EventCodeViewModel eventCode);
        void UpdateEventCodes(EventCodeViewModel eventCode);

        //GoverningPolicies
        List<IdNameViewModel> GetAllGoverningPolicies();
        MultiSelectList GetAllGoverningPoliciesDDL(string IdSchedule);
        IdNameViewModel GetGoverningPolicyById(int id);
        void InsertGoverningPolicy(IdNameViewModel governingPolicy);
        void DeleteGoverningPolicy(IdNameViewModel governingPolicy);
        void UpdateGoverningPolicy(IdNameViewModel governingPolicy);

        //GoverningRegulations
        List<IdNameViewModel> GetAllGoverningRegulations();
        MultiSelectList GetAllGoverningRegulationsDDL(string IdSchedule);
        IdNameViewModel GetGoverningRegulationById(int id);
        void InsertGoverningRegulation(IdNameViewModel governingRegulation);
        void DeleteGoverningRegulation(IdNameViewModel governingRegulation);
        void UpdateGoverningRegulation(IdNameViewModel governingRegulation);

        //GoverningStatutes
        List<IdNameViewModel> GetAllGoverningStatutes();
        MultiSelectList GetAllGoverningStatutesDDL(string IdSchedule);
        IdNameViewModel GetGoverningStatuteById(int id);
        void InsertGoverningStatutes(IdNameViewModel governingStatute);
        void DeleteGoverningStatutes(IdNameViewModel governingStatute);
        void UpdateGoverningStatutes(IdNameViewModel governingStatute);

        //OfficeOfRecords
        List<OfficeOfRecordViewModel> GetAllOfficeOfRecords();
        IEnumerable<SelectListItem> GetAllOfficeOfRecordsDDL();
        OfficeOfRecordViewModel GetOfficeOfRecordById(int id);
        void InsertOfficeOfRecord(OfficeOfRecordViewModel officeOfRecord);
        void DeleteOfficeOfRecord(OfficeOfRecordViewModel officeOfRecord);
        void UpdateOfficeOfRecord(OfficeOfRecordViewModel officeOfRecord);

        //OfficialRecordMedium
        List<OfficialRecordMediumVM> GetAllOfficialRecordMediums();
        IEnumerable<SelectListItem> GetAllOfficialRecordMediumsDDL();
        OfficialRecordMediumVM GetOfficialRecordMediumById(int id);
        void InsertOfficialRecordMedium(OfficialRecordMediumVM officialRecordMedium);
        void DeleteOfficialRecordMedium(OfficialRecordMediumVM officialRecordMedium);
        void UpdateOfficialRecordMedium(OfficialRecordMediumVM officialRecordMedium);

        //Retainer
        List<IdNameViewModel> GetAllRetainers();
        IEnumerable<SelectListItem> GetAllRetainersDDL();
        IdNameViewModel GetRetainerById(int id);
        void InsertRetainer(IdNameViewModel retainer);
        void DeleteRetainer(IdNameViewModel retainer);
        void UpdateRetainer(IdNameViewModel retainer);

        //Retention
        List<RetentionViewModel> GetAllRetentions();
        IEnumerable<SelectListItem> GetAllRetentionsDDL();
        RetentionViewModel GetRetentionById(int id);
        void InsertRetention(RetentionViewModel retention);
        void DeleteRetention(RetentionViewModel retention);
        void UpdateRetention(RetentionViewModel retention);

        //Custom Selection Lists
        IEnumerable<SelectListItem> GetActiveDDL();
        IEnumerable<SelectListItem> GetYesNoDDL();
        IEnumerable<SelectListItem> GetTypesDDL();
        IEnumerable<SelectListItem> GetDDLbyName(string name,string scheduleId);

        //Columns Configuration
        List<ColumnManager> GetColumnsConfig();

        void Dispose();
    }
}
