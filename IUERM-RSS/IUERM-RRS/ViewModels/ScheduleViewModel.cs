using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IUERM_RRS.ViewModels
{
    public class ScheduleViewModel
    {
        public System.Guid SCH_ID { get; set; }

        [Display(Name = "Steward Domain")]
        public string SCH_StewardDomain { get; set; }

        [Display(Name = "Retention Area")]
        public string SCH_RetentionArea { get; set; }

        [Display(Name = "Retention Sub Area")]
        public string SCH_RetentionSubArea { get; set; }

        [Display(Name = "Area Scope")]
        public Nullable<int> SCH_AreaScopeId { get; set; }

        [Display(Name = "Ret. Area Description")]
        public string SCH_RetentionAreaDescription { get; set; }

        [Display(Name = "Type")]
        public string SCH_Type { get; set; }

        [Display(Name = "Office")]
        public Nullable<int> SCH_OfficeId { get; set; }

        [Display(Name = "Coordinator")]
        public string SCH_Coordinator { get; set; }

        [Display(Name = "Record Series")]
        public string SCH_RecordSeries { get; set; }

        [Display(Name = "Series Code")]
        public string SCH_RecordSeriesCode { get; set; }

        [Display(Name = "Description")]
        public string SCH_Description { get; set; }

        [Display(Name = "Retention")]
        public Nullable<int> SCH_RetentionId { get; set; }

        [Display(Name = "Active")]
        public string SCH_Active { get; set; }

        [Display(Name = "Vital")]
        public string SCH_Vital { get; set; }

        [Display(Name = "Governing Statutes")]
        public Nullable<int> SCH_GoverningStatutesId { get; set; }

        [Display(Name = "Governing Regulations")]
        public Nullable<int> SCH_GoverningRegulationsId { get; set; }

        [Display(Name = "Governing Policies")]
        public Nullable<int> SCH_GoverningPoliciesId { get; set; }

        [Display(Name = "Reason")]
        public string SCH_Reason { get; set; }

        [Display(Name = "Record Medium")]
        public Nullable<int> SCH_RecordMedium { get; set; }

        [Display(Name = "People who retains")]
        public Nullable<int> SCH_RetainerId { get; set; }

        [Display(Name = "Disposition")]
        public Nullable<int> SCH_DispositionId { get; set; }
        public Nullable<bool> SCH_RquiresCertDestruction { get; set; }
        public Nullable<System.DateTime> SCH_CreationDate { get; set; }

    }
}