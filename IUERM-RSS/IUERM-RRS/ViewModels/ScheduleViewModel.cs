using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IUERM_RRS.ViewModels
{
    public class ScheduleViewModel
    {
        public Guid SCH_ID { get; set; }

        [Display(Name = "Steward Domain")]
        public string SCH_StewardDomain { get; set; }

        [Display(Name = "Retention Area")]
        public string SCH_RetentionArea { get; set; }

        [Display(Name = "Retention Sub Area")]
        public string SCH_RetentionSubArea { get; set; }

        [Display(Name = "Area Scope")]
        public int SCH_AreaScopeId { get; set; }

        [Display(Name = "Ret. Area Description")]
        public string SCH_RetentionAreaDescription { get; set; }

        [Display(Name = "Type")]
        public string SCH_Type { get; set; }

        [Display(Name = "Office")]
        public int OfficeId { get; set; }

        [Display(Name = "Coordinator")]
        public string SCH_Coordinator { get; set; }

        [Display(Name = "Record Series")]
        public string SCH_RecordSeries { get; set; }

        [Display(Name = "Series Code")]
        public string SCH_RecordSeriesCode { get; set; }

        [Display(Name = "Description")]
        public string SCH_Description { get; set; }

        [Display(Name = "Retention")]
        public int SCH_RetentionId { get; set; }

        [Display(Name = "Active")]
        [UIHint("Active")]
        public bool SCH_Active { get; set; }

        [Display(Name = "Vital")]
        [UIHint("Vital")]
        public bool SCH_Vital { get; set; }

        [Display(Name = "Governing Statutes")]
        public int SCH_GoverningStatutesId { get; set; }

        [Display(Name = "Governing Regulations")]
        public int SCH_GoverningRegulationsId { get; set; }

        [Display(Name = "Governing Policies")]
        public int SCH_GoverningPoliciesId { get; set; }

        [Display(Name = "Reason")]
        public string SCH_Reason { get; set; }

        [Display(Name = "Record Medium")]
        public int SCH_RecordMedium { get; set; }

        [Display(Name = "People who retains")]
        public int SCH_RetainerId { get; set; }

        [Display(Name = "Disposition")]
        public int SCH_DispositionId { get; set; }
        public bool SCH_RquiresCertDestruction { get; set; }
        public DateTime SCH_CreationDate { get; set; }

    }
}