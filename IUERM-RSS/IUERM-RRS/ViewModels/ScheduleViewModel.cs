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
        [Display(Name = "Area Scope")]
        public string SCH_AreaScope
        {
            get
            {
                return AreaScopeObject?.Name ?? string.Empty;
            }
        }

        [Display(Name = "Ret. Area Description")]
        public string SCH_RetentionAreaDescription { get; set; }

        [Display(Name = "Type")]
        public string SCH_Type { get; set; }

        [Display(Name = "Office")]
        public int? SCH_OfficeId { get; set; }
        [Display(Name = "Office")]
        public string SCH_Office
        {
            get
            {
                string code = OfficeOfRecordObject?.Code ?? string.Empty;
                string name = OfficeOfRecordObject?.Name ?? string.Empty;
                return code + " - " + name;
            }
        }

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
        [Display(Name = "Retention")]
        public string SCH_Retention
        {
            get
            {
                string code = RetentionObject?.BasedOnCode ?? string.Empty;
                string description = RetentionObject?.BaseOnDescription ?? string.Empty;
                return code + " - " + description;
            }
        }

        [Display(Name = "Active")]
        public bool? SCH_Active { get; set; }
        [Display(Name = "Active")]
        public string SCH_IsActive
        {
            get
            {
                bool active = (SCH_Active != null) ? (bool)SCH_Active : false;
                return active ? "Yes" : "NO";
            }
        }

        [Display(Name = "Vital")]
        public bool? SCH_Vital { get; set; }
        public string SCH_IsVital
        {
            get
            {
                bool vital = (SCH_Vital != null) ? (bool)SCH_Vital : false;
                return vital ? "Yes" : "NO";
            }
        }


        [Display(Name = "Governing Statutes")]
        public int? SCH_GoverningStatutesId { get; set; }
        [Display(Name = "Governing Statutes")]
        public string SCH_GoverningStatute
        {
            get
            {
                return GoverningStatuteObject?.Name ?? string.Empty;
            }
        }

        [Display(Name = "Governing Regulations")]
        public int? SCH_GoverningRegulationsId { get; set; }
        [Display(Name = "Governing Regulations")]
        public string SCH_GoverningRegulation
        {
            get
            {
                return GoverningRegulationObject?.Name?? string.Empty;
            }
        }


        [Display(Name = "Governing Policies")]
        public int? SCH_GoverningPoliciesId { get; set; }
        [Display(Name = "Governing Policies")]
        public string SCH_GoverningPolicy
        {
            get
            {
                return GoverningPolicyObject?.Name ?? string.Empty;
            }
        }

        [Display(Name = "Reason")]
        public string SCH_Reason { get; set; }

        [Display(Name = "Record Medium")]
        public int? SCH_RecordMedium { get; set; }
        [Display(Name = "Record Medium")]
        public string SCH_RecordMediums
        {
            get
            {
                return OfficialRecordMediumObject?.Name?? string.Empty;
            }
        }

        [Display(Name = "People who retains")]
        public int? SCH_RetainerId { get; set; }
        [Display(Name = "People who retains")]
        public string SCH_Retainer
        {
            get
            {
                return RetainerObject?.Name ?? string.Empty;
            }
        }

        [Display(Name = "Disposition")]
        public int? SCH_DispositionId { get; set; }
        [Display(Name = "Disposition")]
        public string SCH_Disposition
        {
            get
            {
                return DispositionOptionObject?.Name?? string.Empty;
            }
        }

        [Display(Name ="Requires Certificate of Destruction")]
        public bool? SCH_RequiresCertDestruction { get; set; }
        [Display(Name = "Requires Certificate of Destruction")]
        public string SCH_RquiresDestruction
        {
            get
            {
                bool requires = (SCH_RequiresCertDestruction != null) ? (bool)SCH_RequiresCertDestruction : false;
                return requires ? "Yes" : "NO";
            }
        }


        [Display(Name = "Creation Date")]
        public DateTime? SCH_CreationDate { get; set; }

        // Navigation Objects for customizing the data in the 'get { }' property for the grid view
        public AreaScopeViewModel AreaScopeObject { get; set; }
        public DispositionOptionViewModel DispositionOptionObject { get; set; }
        public IdNameViewModel GoverningPolicyObject { get; set; }
        public IdNameViewModel GoverningRegulationObject { get; set; }
        public IdNameViewModel GoverningStatuteObject { get; set; }
        public OfficeOfRecordViewModel OfficeOfRecordObject { get; set; }
        public OfficialRecordMediumVM OfficialRecordMediumObject { get; set; }
        public IdNameViewModel RetainerObject { get; set; }
        public RetentionViewModel RetentionObject { get; set; }

        // Variables for the drop down lists in the create and edit views
        public IEnumerable<SelectListItem> AreaScopes { get; set; }
        public IEnumerable<SelectListItem> DispositionOptions { get; set; }
        public IEnumerable<SelectListItem> GoverningPolicies { get; set; }
        public IEnumerable<SelectListItem> GoverningRegulations { get; set; }
        public IEnumerable<SelectListItem> GoverningStatutes { get; set; }
        public IEnumerable<SelectListItem> OfficeOfRecords { get; set; }
        public IEnumerable<SelectListItem> OfficialRecordMediums { get; set; }
        public IEnumerable<SelectListItem> Retainers { get; set; }
        public IEnumerable<SelectListItem> Retentions { get; set; }
        public IEnumerable<SelectListItem> ActiveInactive { get; set; }
        public IEnumerable<SelectListItem> IsVital { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }
        public IEnumerable<SelectListItem> RequireDestructionOpt { get; set; }

    }
    
}