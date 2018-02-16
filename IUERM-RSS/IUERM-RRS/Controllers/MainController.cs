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

        #region EventCodes

        public JsonResult GoverningPolicies([DataSourceRequest]DataSourceRequest request)
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

    }
}