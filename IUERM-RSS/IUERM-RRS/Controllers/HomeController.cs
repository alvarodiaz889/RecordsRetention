using IUERM_RRS.Repositories;
using IUERM_RRS.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IUERM_RRS.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private IScheduleRepository scheduleRepository;
        private IMainRepository mainRepository;
        public HomeController(IScheduleRepository scheduleRepository, IMainRepository mainRepository)
        {
            this.mainRepository = mainRepository;
            this.scheduleRepository = scheduleRepository;
        }

        public ActionResult Index()
        {
            ScheduleViewModel.SetColumns(mainRepository.GetColumnsConfig());
            ScheduleViewModel.Checked = false;
            ViewBag.Checked = false;
            ViewBag.SearchValue = string.Empty;
            return View();
        }

        public ActionResult AdvancedView(string check, string searchValue)
        {
            ScheduleViewModel.SetColumns(mainRepository.GetColumnsConfig());
            ScheduleViewModel.Checked = Convert.ToBoolean(check);
            ViewBag.Checked = Convert.ToBoolean(check);
            ViewBag.SearchValue = searchValue;
            return View("Index");
        }

        public ActionResult Schedules_Read([DataSourceRequest]DataSourceRequest request, string searchValue)
        {
            List<ScheduleViewModel> schedules = scheduleRepository.GetAllRecords();
            if (!string.IsNullOrWhiteSpace(searchValue))
            {
                schedules = schedules.Where(s =>
                {
                    bool valid = false;

                    if ((string.Empty + s.SCH_AreaScope).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Coordinator).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_CreationDate2).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Description).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Disposition).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_EventCode).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_GoverningPolicy).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_GoverningRegulation).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_GoverningStatute).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_IsActive).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_IsVital).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Office).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Reason).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_RecordMedium).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_RecordSeries).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_RecordSeriesCode).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_RequiresDestruction).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Retainer).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Retention).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_RetentionArea).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_RetentionAreaDescription).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_RetentionSubArea).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_StewardDomain).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Type).ToUpper().Contains(searchValue.ToUpper())) valid = true;
                    if ((string.Empty + s.SCH_Years).ToUpper().Contains(searchValue.ToUpper())) valid = true;

                    return valid;

                }).ToList();
            }
            DataSourceResult result = schedules.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public ActionResult LoginError()
        {
            return View();
        }

        [AllowAnonymous]
        public ActionResult Error()
        {
            return View();
        }
    }
}