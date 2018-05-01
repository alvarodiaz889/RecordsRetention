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
            return View();
        }

        public ActionResult AdvancedView(string check)
        {
            ScheduleViewModel.SetColumns(mainRepository.GetColumnsConfig());
            ScheduleViewModel.Checked = Convert.ToBoolean(check);
            ViewBag.Checked = Convert.ToBoolean(check);
            return View("Index");
        }

        public ActionResult Schedules_Read([DataSourceRequest]DataSourceRequest request)
        {
            List<ScheduleViewModel> schedules = scheduleRepository.GetAllRecords();
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