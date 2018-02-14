using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUERM_RRS.Repositories
{
    public interface IScheduleRepository
    {
        //Area Scope
        List<ScheduleViewModel> GetAllSchedules();
        ScheduleViewModel GetScheduleById(string id);
        void Insert(ScheduleViewModel schedule);
        void Delete(ScheduleViewModel schedule);
        void Update(ScheduleViewModel schedule);
    }
}
