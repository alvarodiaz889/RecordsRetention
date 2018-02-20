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
    public class MainController : Controller
    {
        private IMainRepository mainRepository;
        public MainController(IMainRepository mainRepository)
        {
            this.mainRepository = mainRepository;
        }

        #region AreaScopes
        public JsonResult ReadAreaScopes([DataSourceRequest]DataSourceRequest request)
        {
            List<AreaScopeViewModel> list = mainRepository.GetAllAreaScopes();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateAreaScope([DataSourceRequest] DataSourceRequest request, AreaScopeViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertAreaScope(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyAreaScope([DataSourceRequest] DataSourceRequest request, AreaScopeViewModel obj)
        {
            mainRepository.DeleteAreaScope(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateAreaScope([DataSourceRequest] DataSourceRequest request, AreaScopeViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateAreaScope(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region DispositionOptions

        public JsonResult ReadDispositionOptions([DataSourceRequest]DataSourceRequest request)
        {
            List<DispositionOptionViewModel> list = mainRepository.GetAllDispositionOptions();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateDispositionOption([DataSourceRequest] DataSourceRequest request, DispositionOptionViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertDispositionOption(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyDispositionOption([DataSourceRequest] DataSourceRequest request, DispositionOptionViewModel obj)
        {
            mainRepository.DeleteDispositionOption(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateDispositionOption([DataSourceRequest] DataSourceRequest request, DispositionOptionViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateDispositionOption(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region EventCodes

        public JsonResult ReadEventCodes([DataSourceRequest]DataSourceRequest request)
        {
            List<EventCodeViewModel> list = mainRepository.GetAllEventCodes();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateEventCode([DataSourceRequest] DataSourceRequest request, EventCodeViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertEventCodes(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyEventCode([DataSourceRequest] DataSourceRequest request, EventCodeViewModel obj)
        {
            mainRepository.DeleteEventCodes(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateEventCode([DataSourceRequest] DataSourceRequest request, EventCodeViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateEventCodes(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region GoverningPolicies

        public JsonResult ReadGoverningPolicies([DataSourceRequest]DataSourceRequest request)
        {
            List<IdNameViewModel> list = mainRepository.GetAllGoverningPolicies();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateGoverningPolicy([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertGoverningPolicy(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyGoverningPolicy([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            mainRepository.DeleteGoverningPolicy(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateGoverningPolicy([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateGoverningPolicy(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region GoverningRegulations

        public JsonResult ReadGoverningRegulation([DataSourceRequest]DataSourceRequest request)
        {
            List<IdNameViewModel> list = mainRepository.GetAllGoverningRegulations();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateGoverningRegulation([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertGoverningRegulation(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyGoverningRegulation([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            mainRepository.DeleteGoverningRegulation(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateGoverningRegulation([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateGoverningRegulation(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region GoverningStatutes

        public JsonResult ReadGoverningStatutes([DataSourceRequest]DataSourceRequest request)
        {
            List<IdNameViewModel> list = mainRepository.GetAllGoverningStatutes();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateGoverningStatute([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertGoverningStatutes(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyGoverningStatute([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            mainRepository.DeleteGoverningStatutes(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateGoverningStatute([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateGoverningStatutes(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region OfficeOfRecords

        public JsonResult ReadOfficeOfRecords([DataSourceRequest]DataSourceRequest request)
        {
            List<OfficeOfRecordViewModel> list = mainRepository.GetAllOfficeOfRecords();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateOfficeOfRecord([DataSourceRequest] DataSourceRequest request, OfficeOfRecordViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertOfficeOfRecord(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyOfficeOfRecord([DataSourceRequest] DataSourceRequest request, OfficeOfRecordViewModel obj)
        {
            mainRepository.DeleteOfficeOfRecord(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateOfficeOfRecord([DataSourceRequest] DataSourceRequest request, OfficeOfRecordViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateOfficeOfRecord(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region OfficialRecordMediums

        public JsonResult ReadOfficialRecordMediums([DataSourceRequest]DataSourceRequest request)
        {
            List<OfficialRecordMediumVM> list = mainRepository.GetAllOfficialRecordMediums();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateOfficialRecordMedium([DataSourceRequest] DataSourceRequest request, OfficialRecordMediumVM obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertOfficialRecordMedium(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyOfficialRecordMedium([DataSourceRequest] DataSourceRequest request, OfficialRecordMediumVM obj)
        {
            mainRepository.DeleteOfficialRecordMedium(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateOfficialRecordMedium([DataSourceRequest] DataSourceRequest request, OfficialRecordMediumVM obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateOfficialRecordMedium(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region Retainers

        public JsonResult ReadRetainers([DataSourceRequest]DataSourceRequest request)
        {
            List<IdNameViewModel> list = mainRepository.GetAllRetainers();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateRetainer([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertRetainer(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyRetainer([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            mainRepository.DeleteRetainer(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateRetainer([DataSourceRequest] DataSourceRequest request, IdNameViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateRetainer(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion

        #region Retentions

        public JsonResult ReadRetentions([DataSourceRequest]DataSourceRequest request)
        {
            List<RetentionViewModel> list = mainRepository.GetAllRetentions();
            DataSourceResult result = list.AsQueryable().ToDataSourceResult(request);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateRetention([DataSourceRequest] DataSourceRequest request, RetentionViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.InsertRetention(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult DestroyRetention([DataSourceRequest] DataSourceRequest request, RetentionViewModel obj)
        {
            mainRepository.DeleteRetention(obj);
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }

        [HttpPost]
        public ActionResult UpdateRetention([DataSourceRequest] DataSourceRequest request, RetentionViewModel obj)
        {
            if (ModelState.IsValid)
            {
                mainRepository.UpdateRetention(obj);
            }
            return Json(new[] { obj }.ToDataSourceResult(request, ModelState));
        }
        #endregion
    }
}