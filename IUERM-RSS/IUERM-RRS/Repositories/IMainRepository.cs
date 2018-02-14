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
        List<ScheduleViewModel> GetAllAreaScopes();
        ScheduleViewModel GetAreaScopeById(int id);
        void InsertAreaScope(ScheduleViewModel areaScope);
        void DeleteAreaScope(ScheduleViewModel areaScope);
        void UpdateAreaScope(ScheduleViewModel areaScope);

        //DispositionOptions
        List<DispositionOption> GetAllDispositionOptions();
        DispositionOption GetDispositionOptionsById(int id);
        void InsertDispositionOption(DispositionOption dispositionOption);
        void DeleteDispositionOption(DispositionOption dispositionOption);
        void UpdateDispositionOption(DispositionOption dispositionOption);

        //EventCodes
        List<EventCode> GetAllEventCodes();
        EventCode GetEventCodesByCode(string code);
        void InsertEventCodes(EventCode eventCode);
        void DeleteEventCodes(EventCode eventCode);
        void UpdateEventCodes(EventCode eventCode);

        //GoverningPolicies
        List<GoverningPolicy> GetAllGoverningPolicies();
        GoverningPolicy GetGoverningPolicyById(int id);
        void InsertGoverningPolicy(GoverningPolicy governingPolicy);
        void DeleteGoverningPolicy(GoverningPolicy governingPolicy);
        void UpdateGoverningPolicy(GoverningPolicy governingPolicy);

        //GoverningRegulations
        List<GoverningRegulation> GetAllGoverningRegulations();
        GoverningRegulation GetGoverningRegulationById(int id);
        void InsertGoverningRegulation(GoverningRegulation governingRegulation);
        void DeleteGoverningRegulation(GoverningRegulation governingRegulation);
        void UpdateGoverningRegulation(GoverningRegulation governingRegulation);

        //GoverningStatutes
        List<GoverningStatute> GetAllGoverningStatutes();
        GoverningStatute GetGoverningStatuteById(int id);
        void InsertGoverningStatutes(GoverningStatute governingStatute);
        void DeleteGoverningStatutes(GoverningStatute governingStatute);
        void UpdateGoverningStatutes(GoverningStatute governingStatute);

        //OfficeOfRecords
        List<OfficeOfRecord> GetAllOfficeOfRecords();
        OfficeOfRecord GetOfficeOfRecordById(int id);
        void InsertOfficeOfRecord(OfficeOfRecord officeOfRecord);
        void DeleteOfficeOfRecord(OfficeOfRecord officeOfRecord);
        void UpdateOfficeOfRecord(OfficeOfRecord officeOfRecord);

        //OfficialRecordMedium
        List<OfficialRecordMedium> GetAllOfficialRecordMediums();
        OfficialRecordMedium GetOfficialRecordMediumById(int id);
        void InsertOfficialRecordMedium(OfficialRecordMedium officialRecordMedium);
        void DeleteOfficialRecordMedium(OfficialRecordMedium officialRecordMedium);
        void UpdateOfficialRecordMedium(OfficialRecordMedium officialRecordMedium);

        //Retainer
        List<Retainer> GetAllRetainers();
        Retainer GetRetainerById(int id);
        void InsertRetainer(Retainer retainer);
        void DeleteRetainer(Retainer retainer);
        void UpdateRetainer(Retainer retainer);

        //Retention
        List<Retention> GetAllRetentions();
        Retention GetRetentionById(int id);
        void InsertRetention(Retention retention);
        void DeleteRetention(Retention retention);
        void UpdateRetention(Retention retention);

        void Dispose();
    }
}
