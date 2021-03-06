﻿using IUERM_RRS.Helpers;
using IUERM_RRS.Validations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace IUERM_RRS.ViewModels
{
    public class ScheduleViewModel
    {
        public ScheduleViewModel() { }
        public Guid SCH_ID { get; set; }

        [Display(Name = "Data Steward Domain")]
        [Validator()]
        public string SCH_StewardDomain { get; set; }

        [Display(Name = "Records Retention Area")]
        [Validator()]
        public string SCH_RetentionArea { get; set; }

        [Display(Name = "Records Retention Sub-Area")]
        [Validator()]
        public string SCH_RetentionSubArea { get; set; }

        [Display(Name = "Area/Sub-Area Scope")]
        [Validator()]
        public int? SCH_AreaScopeId { get; set; }
        [Display(Name = "Area/Sub-Area Scope")]
        public string SCH_AreaScope { get;set; }

        private string retentionAreaDescription;
        [Display(Name = "Area/Sub-Area Description")]
        [Validator()]
        [DataType(DataType.MultilineText)]
        public string SCH_RetentionAreaDescription {
            //get { return retentionAreaDescription.ShortTo(40); }
            get { return retentionAreaDescription; }
            set { retentionAreaDescription = value; }
        }

        [Display(Name = "Type")]
        [Validator()]
        public string SCH_Type { get; set; }

        [Display(Name = "Office of Record")]
        [Validator()]
        public int? SCH_OfficeId { get; set; }
        [Display(Name = "Office of Record")]
        public string SCH_Office { get; set; }

        [Display(Name = "Records Coordinator")]
        [Validator()]
        public string SCH_Coordinator { get; set; }

        [Display(Name = "Record Series")]
        [Validator()]
        public string SCH_RecordSeries { get; set; }

        [Display(Name = "Record Series Code")]
        [Validator()]
        public string SCH_RecordSeriesCode { get; set; }

        private string _description;
        [Display(Name = "Record Description")]
        [Validator()]
        [DataType(DataType.MultilineText)]
        public string SCH_Description {
            //get { return _description.ShortTo(40);}
            get { return _description; }
            set { _description = value; }
        }

        [Display(Name = "Based On")]
        [Validator()]
        public int? SCH_RetentionId { get; set; }
        [Display(Name = "Based On")]
        public string SCH_Retention { get; set; }

        [Display(Name = "Active/Inactive")]
        [Validator()]
        public bool? SCH_Active { get; set; }
        [Display(Name = "Active/Inactive")]
        public string SCH_IsActive { get;set;}

        [Display(Name = "Vital")]
        [Validator()]
        public bool? SCH_Vital { get; set; }
        [Display(Name = "Vital")]
        public string SCH_IsVital { get;set; }

        private string _governingStatute;
        [Display(Name = "Governing Statutes")]
        public string SCH_GoverningStatute {
            get { return _governingStatute.ReplaceCustom("#"); }
            set { _governingStatute = value; }
        }
        [Display(Name = "Governing Statutes")]
        public List<string> GoverningStatuteIds { get; set; }
        [Display(Name = "Governing Statutes")]
        public MultiSelectList GoverningStatutesMultiSelect { get; set; }


        private string _governingRegulation;
        [Display(Name = "Governing Regulations")]
        public string SCH_GoverningRegulation {
            get { return _governingRegulation.ReplaceCustom("#"); }
            set { _governingRegulation = value; }
        }
        [Display(Name = "Governing Regulations")]
        public List<string> GoverningRegulationIds { get; set; }
        [Display(Name = "Governing Regulations")]
        public MultiSelectList GoverningRegulationsMultiSelect { get; set; }

        private string _governingPolicy;
        [Display(Name = "Governing IU Policies")]
        public string SCH_GoverningPolicy
        {
            get{ return _governingPolicy.ReplaceCustom("#"); }
            set{ _governingPolicy = value; }
        }
        [Display(Name = "Governing IU Policies")]
        public List<string> GoverningPolicyIds { get; set; }
        [Display(Name = "Governing IU Policies")]
        public MultiSelectList GoverningPoliciesMultiSelect { get; set; }

        private string _reason;
        [Display(Name = "Reason for Retention Period")]
        [Validator()]
        [DataType(DataType.MultilineText)]
        public string SCH_Reason {
            //get { return _reason.ShortTo(40); }
            get { return _reason; }
            set { _reason = value; }
        }

        [Display(Name = "Official Record Medium")]
        [Validator()]
        public int? SCH_RecordMediumId { get; set; }
        [Display(Name = "Official Record Medium")]
        public string SCH_RecordMedium { get; set; }

        [Display(Name = "Who Can Retain")]
        [Validator()]
        public int? SCH_RetainerId { get; set; }
        [Display(Name = "Who Can Retain")]
        public string SCH_Retainer { get; set; }

        [Display(Name = "Disposition")]
        [Validator()]
        public int? SCH_DispositionId { get; set; }
        [Display(Name = "Disposition")]
        public string SCH_Disposition { get; set; }

        [Display(Name ="Requires Certificate of Destruction")]
        [Validator()]
        public bool? SCH_RequiresCertDestruction { get; set; }
        [Display(Name = "Requires Certificate of Destruction")]
        public string SCH_RequiresDestruction { get; set; }

        [Display(Name = "Creation Date")]
        public DateTime? SCH_CreationDate { get; set; }
        [Display(Name = "Creation Date")]
        public string SCH_CreationDate2 { get; set; }

        [Display(Name = "Event Code")]
        [Validator()]
        public int? SCH_EventCodeId { get; set; }

        private string _eventCode;
        [Display(Name = "Event Code")]
        public string SCH_EventCode {
            get
            {
                if (!string.IsNullOrEmpty(_eventCode))
                {
                    if (_eventCode.Trim().Equals("-")) return string.Empty;
                    string[] split = _eventCode.Split('-');
                    if (string.IsNullOrEmpty(split[0].Trim()) || string.IsNullOrEmpty(split[1].Trim()))
                        return _eventCode.Replace("-", string.Empty).Trim();
                    else return _eventCode;
                }
                else return _eventCode;
            }
            set { _eventCode = value; }
        }

        [Display(Name = "Retention Period")]
        [Validator()]
        public string SCH_Years { get; set; }


        // Variables for the drop down lists in the create and edit views
        public IEnumerable<SelectListItem> AreaScopes { get; set; }
        public IEnumerable<SelectListItem> DispositionOptions { get; set; }
        public IEnumerable<SelectListItem> OfficeOfRecords { get; set; }
        public IEnumerable<SelectListItem> OfficialRecordMediums { get; set; }
        public IEnumerable<SelectListItem> Retainers { get; set; }
        public IEnumerable<SelectListItem> Retentions { get; set; }
        public IEnumerable<SelectListItem> ActiveInactive { get; set; }
        public IEnumerable<SelectListItem> IsVital { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }
        public IEnumerable<SelectListItem> RequireDestructionOpt { get; set; }
        public IEnumerable<SelectListItem> EventCodes { get; set; }

        //Grid Column visibility for the grid located in Home/Index
        private static List<ColumnManager> columnManager;
        public static bool Checked = false;
        public static void SetColumns(List<ColumnManager> columns)
        {
            columnManager = columns;
        }

        public static bool IsColumnVisible(string columnName)
        {
            //If the checkbox is checked, it will omit the configuration
            if (Checked)
                return true;
            var column = columnManager.Where(c => c.ColumnName == columnName).FirstOrDefault();
            return column?.Visible ?? false;
        }

    }
    
}