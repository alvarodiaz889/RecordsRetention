using IUERM_RRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUERM_RRS.Repositories
{
    public interface IMainRepository
    {
        //Area Scope
        List<AreaScopeViewModel> GetAllAreaScopes();
        AreaScopeViewModel GetAreaScopeById(int id);
        void InsertAreaScope(AreaScopeViewModel areaScope);
        void DeleteAreaScope(AreaScopeViewModel areaScope);
        void UpdateAreaScope(AreaScopeViewModel areaScope);

        //DispositionOptions
        List<DispositionOptionViewModel> GetAllDispositionOptions();
        DispositionOptionViewModel GetDispositionOptionsById(int id);
        void InsertDispositionOption(DispositionOptionViewModel dispositionOption);
        void DeleteDispositionOption(DispositionOptionViewModel dispositionOption);
        void UpdateDispositionOption(DispositionOptionViewModel dispositionOption);

        //EventCodes
        List<EventCodeViewModel> GetAllEventCodes();
        EventCodeViewModel GetEventCodesByCode(string code);
        void InsertEventCodes(EventCodeViewModel eventCode);
        void DeleteEventCodes(EventCodeViewModel eventCode);
        void UpdateEventCodes(EventCodeViewModel eventCode);

        //GoverningPolicies
        List<IdNameViewModel> GetAllGoverningPolicies();
        IdNameViewModel GetGoverningPolicyById(int id);
        void InsertGoverningPolicy(IdNameViewModel governingPolicy);
        void DeleteGoverningPolicy(IdNameViewModel governingPolicy);
        void UpdateGoverningPolicy(IdNameViewModel governingPolicy);

        //GoverningRegulations
        List<IdNameViewModel> GetAllGoverningRegulations();
        IdNameViewModel GetGoverningRegulationById(int id);
        void InsertGoverningRegulation(IdNameViewModel governingRegulation);
        void DeleteGoverningRegulation(IdNameViewModel governingRegulation);
        void UpdateGoverningRegulation(IdNameViewModel governingRegulation);

        //GoverningStatutes
        List<IdNameViewModel> GetAllGoverningStatutes();
        IdNameViewModel GetGoverningStatuteById(int id);
        void InsertGoverningStatutes(IdNameViewModel governingStatute);
        void DeleteGoverningStatutes(IdNameViewModel governingStatute);
        void UpdateGoverningStatutes(IdNameViewModel governingStatute);

        //OfficeOfRecords
        List<OfficeOfRecordViewModel> GetAllOfficeOfRecords();
        OfficeOfRecordViewModel GetOfficeOfRecordById(int id);
        void InsertOfficeOfRecord(OfficeOfRecordViewModel officeOfRecord);
        void DeleteOfficeOfRecord(OfficeOfRecordViewModel officeOfRecord);
        void UpdateOfficeOfRecord(OfficeOfRecordViewModel officeOfRecord);

        //OfficialRecordMedium
        List<IdNameViewModel> GetAllOfficialRecordMediums();
        IdNameViewModel GetOfficialRecordMediumById(int id);
        void InsertOfficialRecordMedium(IdNameViewModel officialRecordMedium);
        void DeleteOfficialRecordMedium(IdNameViewModel officialRecordMedium);
        void UpdateOfficialRecordMedium(IdNameViewModel officialRecordMedium);

        //Retainer
        List<IdNameViewModel> GetAllRetainers();
        IdNameViewModel GetRetainerById(int id);
        void InsertRetainer(IdNameViewModel retainer);
        void DeleteRetainer(IdNameViewModel retainer);
        void UpdateRetainer(IdNameViewModel retainer);

        //Retention
        List<RetentionViewModel> GetAllRetentions();
        RetentionViewModel GetRetentionById(int id);
        void InsertRetention(RetentionViewModel retention);
        void DeleteRetention(RetentionViewModel retention);
        void UpdateRetention(RetentionViewModel retention);

        void Dispose();
    }
}
