﻿using IUERM_RRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUERM_RRS.Repositories
{
    public interface IScheduleRepository
    {
        List<ScheduleViewModel> GetAllRecords();
        ScheduleViewModel GetScheduleById(string id);
        void Insert(ScheduleViewModel schedule);
        void Delete(ScheduleViewModel schedule);
        void Delete(string id);
        void Update(ScheduleViewModel schedule);
        ScheduleViewModel GetDropDownsInfoCreate();
        ScheduleViewModel GetDropDownsInfoUpdate(ScheduleViewModel svm,string Id);
        bool RecordExistByForeignIDs(int? areaScopeId, int? officeId, int? retentionId,
            int? governingStatutesId, int? governingRegulationsId, int? governingPoliciesId,
            int? recordMediumId, int? retainerId, int? dispositionId, int? eventCodeId);
        void Dispose();
    }
}
