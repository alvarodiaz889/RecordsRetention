using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IUERM_RRS.ViewModels
{
    public class ScheduleViewModel
    {
        public Guid SCH_ID { get; set; }

        [Display(Name = "Steward Domain")]
        [Required]
        public string SCH_StewardDomain { get; set; }

        [Display(Name = "Retention Area")]
        [Required]
        public string SCH_RetentionArea { get; set; }

        [Display(Name = "Retention Sub Area")]
        public string SCH_RetentionSubArea { get; set; }

        [Display(Name = "Area Scope")]
        [Required]
        public int? SCH_AreaScopeId { get; set; }

        [Display(Name = "Ret. Area Description")]
        public string SCH_RetentionAreaDescription { get; set; }

        [Display(Name = "Type")]
        public string SCH_Type { get; set; }

        [Display(Name = "Office")]
        public int? SCH_OfficeId { get; set; }

        [Display(Name = "Coordinator")]
        [Required]
        public string SCH_Coordinator { get; set; }

        [Display(Name = "Record Series")]
        public string SCH_RecordSeries { get; set; }

        [Display(Name = "Series Code")]
        public string SCH_RecordSeriesCode { get; set; }

        [Display(Name = "Description")]
        public string SCH_Description { get; set; }

        [Display(Name = "Retention")]
        public int? SCH_RetentionId { get; set; }

        [Display(Name = "Active")]
        public bool? SCH_Active { get; set; }

        [Display(Name = "Vital")]
        public bool? SCH_Vital { get; set; }

        [Display(Name = "Governing Statutes")]
        public int? SCH_GoverningStatutesId { get; set; }

        [Display(Name = "Governing Regulations")]
        public int? SCH_GoverningRegulationsId { get; set; }

        [Display(Name = "Governing Policies")]
        public int? SCH_GoverningPoliciesId { get; set; }

        [Display(Name = "Reason")]
        public string SCH_Reason { get; set; }

        [Display(Name = "Record Medium")]
        public int? SCH_RecordMedium { get; set; }

        [Display(Name = "People who retains")]
        public int? SCH_RetainerId { get; set; }

        [Display(Name = "Disposition")]
        public int? SCH_DispositionId { get; set; }
        public bool? SCH_RquiresCertDestruction { get; set; }
        public DateTime? SCH_CreationDate { get; set; }

        public IEnumerable<SelectListItem> AreaScopes { get; set; }
        public IEnumerable<SelectListItem> DispositionOptions { get; set; }
        public IEnumerable<SelectListItem> GoverningPolicies { get; set; }
        public IEnumerable<SelectListItem> GoverningRegulations { get; set; }
        public IEnumerable<SelectListItem> GoverningStatutes { get; set; }
        public IEnumerable<SelectListItem> OfficeOfRecords { get; set; }
        public IEnumerable<SelectListItem> OfficialRecordMediums { get; set; }
        public IEnumerable<SelectListItem> Retainers { get; set; }
        public IEnumerable<SelectListItem> Retentions { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }

    }
}