using IUERM_RRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUERM_RRS.Repositories
{
    public interface IScheduleRepository
    {
        List<Schedule> GetAllRecords();
        Schedule GetScheduleById(string id);
        void Insert(Schedule schedule);
        void Delete(Schedule schedule);
        void Update(Schedule schedule);
    }
}
