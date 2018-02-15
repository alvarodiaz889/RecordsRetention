using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using IUERM_RRS;

namespace IUERM_RRS.Controllers
{
    public class ScheduleController : Controller
    {
        private IUERM_RSchedEntities db = new IUERM_RSchedEntities();

        // GET: SCH
        public ActionResult Index()
        {
            var schedules = db.Schedules.Include(s => s.AreaScope).Include(s => s.DispositionOption).Include(s => s.GoverningPolicy).Include(s => s.GoverningRegulation).Include(s => s.GoverningStatute).Include(s => s.OfficeOfRecord).Include(s => s.OfficialRecordMedium).Include(s => s.Retainer).Include(s => s.Retention);
            return View(schedules.ToList());
        }

        // GET: SCH/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        // GET: SCH/Create
        public ActionResult Create()
        {
            ViewBag.SCH_AreaScopeId = new SelectList(db.AreaScopes, "AS_Id", "AS_Scope");
            ViewBag.SCH_DispositionId = new SelectList(db.DispositionOptions, "DOP_Id", "DOP_Name");
            ViewBag.SCH_GoverningPoliciesId = new SelectList(db.GoverningPolicies, "GPO_Id", "GPO_Name");
            ViewBag.SCH_GoverningRegulationsId = new SelectList(db.GoverningRegulations, "GRE_Id", "GRE_Name");
            ViewBag.SCH_GoverningStatutesId = new SelectList(db.GoverningStatutes, "GST_Id", "GST_Name");
            ViewBag.SCH_OfficeId = new SelectList(db.OfficeOfRecords, "OOR_Id", "OOR_Name");
            ViewBag.SCH_RecordMedium = new SelectList(db.OfficialRecordMediums, "ORM_Id", "ORM_Name");
            ViewBag.SCH_RetainerId = new SelectList(db.Retainers, "RET_Id", "RET_Name");
            ViewBag.SCH_RetentionId = new SelectList(db.Retentions, "RET_Id", "RET_BaseOnDescription");
            return View();
        }

        // POST: SCH/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SCH_ID,SCH_StewardDomain,SCH_RetentionArea,SCH_RetentionSubArea,SCH_AreaScopeId,SCH_RetentionAreaDescription,SCH_Type,SCH_OfficeId,SCH_Coordinator,SCH_RecordSeries,SCH_RecordSeriesCode,SCH_Description,SCH_RetentionId,SCH_Active,SCH_Vital,SCH_GoverningStatutesId,SCH_GoverningRegulationsId,SCH_GoverningPoliciesId,SCH_Reason,SCH_RecordMedium,SCH_RetainerId,SCH_DispositionId,SCH_RquiresCertDestruction,SCH_CreationDate")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                schedule.SCH_ID = Guid.NewGuid();
                db.Schedules.Add(schedule);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.SCH_AreaScopeId = new SelectList(db.AreaScopes, "AS_Id", "AS_Scope", schedule.SCH_AreaScopeId);
            ViewBag.SCH_DispositionId = new SelectList(db.DispositionOptions, "DOP_Id", "DOP_Name", schedule.SCH_DispositionId);
            ViewBag.SCH_GoverningPoliciesId = new SelectList(db.GoverningPolicies, "GPO_Id", "GPO_Name", schedule.SCH_GoverningPoliciesId);
            ViewBag.SCH_GoverningRegulationsId = new SelectList(db.GoverningRegulations, "GRE_Id", "GRE_Name", schedule.SCH_GoverningRegulationsId);
            ViewBag.SCH_GoverningStatutesId = new SelectList(db.GoverningStatutes, "GST_Id", "GST_Name", schedule.SCH_GoverningStatutesId);
            ViewBag.SCH_OfficeId = new SelectList(db.OfficeOfRecords, "OOR_Id", "OOR_Name", schedule.SCH_OfficeId);
            ViewBag.SCH_RecordMedium = new SelectList(db.OfficialRecordMediums, "ORM_Id", "ORM_Name", schedule.SCH_RecordMedium);
            ViewBag.SCH_RetainerId = new SelectList(db.Retainers, "RET_Id", "RET_Name", schedule.SCH_RetainerId);
            ViewBag.SCH_RetentionId = new SelectList(db.Retentions, "RET_Id", "RET_BasedOnCode", schedule.SCH_RetentionId);
            return View(schedule);
        }

        // GET: SCH/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            ViewBag.SCH_AreaScopeId = new SelectList(db.AreaScopes, "AS_Id", "AS_Scope", schedule.SCH_AreaScopeId);
            ViewBag.SCH_DispositionId = new SelectList(db.DispositionOptions, "DOP_Id", "DOP_Name", schedule.SCH_DispositionId);
            ViewBag.SCH_GoverningPoliciesId = new SelectList(db.GoverningPolicies, "GPO_Id", "GPO_Name", schedule.SCH_GoverningPoliciesId);
            ViewBag.SCH_GoverningRegulationsId = new SelectList(db.GoverningRegulations, "GRE_Id", "GRE_Name", schedule.SCH_GoverningRegulationsId);
            ViewBag.SCH_GoverningStatutesId = new SelectList(db.GoverningStatutes, "GST_Id", "GST_Name", schedule.SCH_GoverningStatutesId);
            ViewBag.SCH_OfficeId = new SelectList(db.OfficeOfRecords, "OOR_Id", "OOR_Name", schedule.SCH_OfficeId);
            ViewBag.SCH_RecordMedium = new SelectList(db.OfficialRecordMediums, "ORM_Id", "ORM_Name", schedule.SCH_RecordMedium);
            ViewBag.SCH_RetainerId = new SelectList(db.Retainers, "RET_Id", "RET_Name", schedule.SCH_RetainerId);
            ViewBag.SCH_RetentionId = new SelectList(db.Retentions, "RET_Id", "RET_BasedOnCode", schedule.SCH_RetentionId);
            return View(schedule);
        }

        // POST: SCH/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SCH_ID,SCH_StewardDomain,SCH_RetentionArea,SCH_RetentionSubArea,SCH_AreaScopeId,SCH_RetentionAreaDescription,SCH_Type,SCH_OfficeId,SCH_Coordinator,SCH_RecordSeries,SCH_RecordSeriesCode,SCH_Description,SCH_RetentionId,SCH_Active,SCH_Vital,SCH_GoverningStatutesId,SCH_GoverningRegulationsId,SCH_GoverningPoliciesId,SCH_Reason,SCH_RecordMedium,SCH_RetainerId,SCH_DispositionId,SCH_RquiresCertDestruction,SCH_CreationDate")] Schedule schedule)
        {
            if (ModelState.IsValid)
            {
                db.Entry(schedule).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.SCH_AreaScopeId = new SelectList(db.AreaScopes, "AS_Id", "AS_Scope", schedule.SCH_AreaScopeId);
            ViewBag.SCH_DispositionId = new SelectList(db.DispositionOptions, "DOP_Id", "DOP_Name", schedule.SCH_DispositionId);
            ViewBag.SCH_GoverningPoliciesId = new SelectList(db.GoverningPolicies, "GPO_Id", "GPO_Name", schedule.SCH_GoverningPoliciesId);
            ViewBag.SCH_GoverningRegulationsId = new SelectList(db.GoverningRegulations, "GRE_Id", "GRE_Name", schedule.SCH_GoverningRegulationsId);
            ViewBag.SCH_GoverningStatutesId = new SelectList(db.GoverningStatutes, "GST_Id", "GST_Name", schedule.SCH_GoverningStatutesId);
            ViewBag.SCH_OfficeId = new SelectList(db.OfficeOfRecords, "OOR_Id", "OOR_Name", schedule.SCH_OfficeId);
            ViewBag.SCH_RecordMedium = new SelectList(db.OfficialRecordMediums, "ORM_Id", "ORM_Name", schedule.SCH_RecordMedium);
            ViewBag.SCH_RetainerId = new SelectList(db.Retainers, "RET_Id", "RET_Name", schedule.SCH_RetainerId);
            ViewBag.SCH_RetentionId = new SelectList(db.Retentions, "RET_Id", "RET_BasedOnCode", schedule.SCH_RetentionId);
            return View(schedule);
        }

        // GET: SCH/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Schedule schedule = db.Schedules.Find(id);
            if (schedule == null)
            {
                return HttpNotFound();
            }
            return View(schedule);
        }

        // POST: SCH/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Schedule schedule = db.Schedules.Find(id);
            db.Schedules.Remove(schedule);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
