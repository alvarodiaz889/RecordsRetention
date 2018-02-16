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

        public List<Schedule> GetAllRecords()
        {
            return context.Schedules.ToList();
        }

        public Schedule GetScheduleById(string id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public void Delete(Schedule schedule)
        {
            throw new NotImplementedException();
        }

        public void Update(Schedule schedule)
        {
            throw new NotImplementedException();
        }
    }
}