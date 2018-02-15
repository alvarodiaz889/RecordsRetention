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
        List<ScheduleViewModelEdit> GetAllSchedules();
        ScheduleViewModelEdit GetScheduleById(string id);
        void Insert(ScheduleViewModelEdit schedule);
        void Delete(ScheduleViewModelEdit schedule);
        void Update(ScheduleViewModelEdit schedule);
    }
}
