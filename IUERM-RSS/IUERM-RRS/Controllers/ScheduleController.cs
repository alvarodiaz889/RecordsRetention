using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IUERM_RRS;
using IUERM_RRS.Repositories;
using IUERM_RRS.ViewModels;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Newtonsoft.Json;

namespace IUERM_RRS.Controllers
{
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class ScheduleController : Controller
    {
        private IScheduleRepository scheduleRepository;
        private IMainRepository mainRepository;

        public ScheduleController(IScheduleRepository scheduleRepository, IMainRepository mainRepository)
        {
            this.scheduleRepository = scheduleRepository;
            this.mainRepository = mainRepository;
        }

        [AllowAnonymous]
        public ActionResult Index()
        {
            if (User.IsInRole("SuperAdmin"))
                return RedirectToAction("Index", "User");
            else if (User.IsInRole("Admin"))
                return View("Grid");
            else
                return RedirectToAction("Index", "Home");
        }

        public ActionResult Grid()
        {
            ScheduleViewModel.SetColumns(mainRepository.GetColumnsConfig());
            return View();
        }

        public ActionResult GetPartial(string partial)
        {
            ViewBag.EventCodes = mainRepository.GetAllEventCodes();
            ViewBag.Partial = partial;
            return PartialView(partial);
        }

        public ActionResult GetDDLUpdated(string name,string scheduleId)
        {
            var items = mainRepository.GetDDLbyName(name, scheduleId);
            return Json(items, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            ScheduleViewModel model = GetModel();
            return View(model);
        }

        public ActionResult Edit(string Id)
        {
            ScheduleViewModel model = scheduleRepository.GetScheduleById(Id);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ScheduleViewModel schedule)
        {
            if (ModelState.IsValid)
            {
                scheduleRepository.Insert(schedule);
                return RedirectToAction("Grid", "Schedule");
            }
            schedule = GetModel();
            return View(schedule);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ScheduleViewModel schedule)
        {
            if (ModelState.IsValid)
            {
                scheduleRepository.Update(schedule);
                return RedirectToAction("Grid", "Schedule");
            }
            schedule = GetModel();
            return View(schedule);
        }

        #region KendoGridMethods
        

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Schedules_Destroy([DataSourceRequest]DataSourceRequest request, ScheduleViewModel schedule)
        {
            scheduleRepository.Delete(schedule);
            return Json(new[] { schedule }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Schedules_Destroy2(string id)
        {
            scheduleRepository.Delete(id);
            return Json("");
        }

        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }

        //public ActionResult FileDemo()
        //{
        //    var fileContents = Convert.FromBase64String(base64);

        //    return File(fileContents, contentType, fileName);
        //}

        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }
        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                scheduleRepository.Dispose();
                mainRepository.Dispose();
            }
            base.Dispose(disposing);
        }

        private ScheduleViewModel GetModel()
        {
            return scheduleRepository.GetDropDownsInfoCreate();
        }

        [HttpPost]
        public ActionResult RecordExist(string name,int id)
        {
            int? areaScopeId = name == "areaScopeId" ?  (int?)id:null;
            int? officeId = name == "officeId" ? (int?)id : null;
            int? retentionId = name == "retentionId" ? (int?)id : null;
            int? governingStatutesId = name == "governingStatutesId" ? (int?)id : null;
            int? governingRegulationsId = name == "governingRegulationsId" ? (int?)id : null;
            int? governingPoliciesId = name == "governingPoliciesId" ? (int?)id : null;
            int? recordMediumId = name == "recordMediumId" ? (int?)id : null;
            int? retainerId = name == "retainerId" ? (int?)id : null;
            int? dispositionId = name == "dispositionId" ? (int?)id : null;
            int? eventCodeId = name == "eventCodeId" ? (int?)id : null;
            bool value = scheduleRepository.RecordExistByForeignIDs(areaScopeId, officeId, retentionId, governingStatutesId,
                governingRegulationsId, governingPoliciesId, recordMediumId, retainerId, dispositionId, eventCodeId);
            return Json(value, JsonRequestBehavior.AllowGet);
        }

    }
}
