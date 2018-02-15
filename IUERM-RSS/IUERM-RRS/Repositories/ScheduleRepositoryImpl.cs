using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IUERM_RRS.ViewModels;

namespace IUERM_RRS.Repositories
{
    public class ScheduleRepositoryImpl : IScheduleRepository
    {
        private IUERM_RSchedEntities context = new IUERM_RSchedEntities();
        public List<ScheduleViewModelEdit> GetAllSchedules()
        {
            List<ScheduleViewModelEdit> schedulesVM = new List<ScheduleViewModelEdit>();
            var schedules = context.Schedules.ToList();
            foreach (var sch in schedules)
            {
                var vm = new ScheduleViewModelEdit
                {
                    AreaScopes = context.AreaScopes.ToList(),
                    GoverningPolicies = context.GoverningPolicies.ToList()
                };
            }
            return schedulesVM;
        }

        List<ScheduleViewModelEdit> IScheduleRepository.GetAllSchedules()
        {
            throw new NotImplementedException();
        }

        ScheduleViewModelEdit IScheduleRepository.GetScheduleById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(ScheduleViewModelEdit schedule)
        {
            throw new NotImplementedException();
        }

        public void Delete(ScheduleViewModelEdit schedule)
        {
            throw new NotImplementedException();
        }

        public void Update(ScheduleViewModelEdit schedule)
        {
            throw new NotImplementedException();
        }
    }
}