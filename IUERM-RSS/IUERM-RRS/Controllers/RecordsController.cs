﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using IUERM_RRS;

namespace IUERM_RRS.Controllers
{
    public class RecordsController : Controller
    {
        private IUERM_RSchedEntities db = new IUERM_RSchedEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Schedules_Read([DataSourceRequest]DataSourceRequest request)
        {
            IQueryable<Schedule> schedules = db.Schedules;
            DataSourceResult result = schedules.ToDataSourceResult(request, schedule => new {
                SCH_ID = schedule.SCH_ID,
                SCH_StewardDomain = schedule.SCH_StewardDomain,
                SCH_RetentionArea = schedule.SCH_RetentionArea,
                SCH_RetentionSubArea = schedule.SCH_RetentionSubArea,
                SCH_RetentionAreaDescription = schedule.SCH_RetentionAreaDescription,
                SCH_Type = schedule.SCH_Type,
                SCH_Coordinator = schedule.SCH_Coordinator,
                SCH_RecordSeries = schedule.SCH_RecordSeries,
                SCH_RecordSeriesCode = schedule.SCH_RecordSeriesCode,
                SCH_Description = schedule.SCH_Description,
                SCH_Active = schedule.SCH_Active,
                SCH_Vital = schedule.SCH_Vital,
                SCH_Reason = schedule.SCH_Reason,
                SCH_RquiresCertDestruction = schedule.SCH_RquiresCertDestruction,
                SCH_CreationDate = schedule.SCH_CreationDate,
            });

            return Json(result);
        }

        [HttpPost]
        public ActionResult Excel_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }
    
        [HttpPost]
        public ActionResult Pdf_Export_Save(string contentType, string base64, string fileName)
        {
            var fileContents = Convert.FromBase64String(base64);

            return File(fileContents, contentType, fileName);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
