using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IUERM_RRS.ViewModels
{
    public class AreaScopeViewModel
    {
        [Display(Name = "Id" )]
        public int Id { get; set; }

        [Display(Name = "Scope")]
        [MaxLength(50)]
        public string Name { get; set; }
    }

    public class IdNameViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(255)]
        public string Name { get; set; }
    }

    public class OfficialRecordMediumVM
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
    
    public class DispositionOptionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Disposition Option")]
        [MaxLength(255)]
        public string Name { get; set; }
    }

    public class EventCodeViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Code")]
        [MaxLength(10)]
        public string Code { get; set; }

        [Display(Name = "Description")]
        [MaxLength(255)]
        public string Description { get; set; }

        [Display(Name ="Event Code")]
        public string EventCode
        {
            get
            {
                string r = Code ?? string.Empty;
                r += Description ?? string.Empty;
                return r;
            }
            set { }
        }
    }

    public class OfficeOfRecordViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        [MaxLength(50)]
        public string Name { get; set; }

        [Display(Name = "Code")]
        [MaxLength(50)]
        public string Code { get; set; }
    }

    public class RetentionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Ret.Code")]
        public string BasedOnCode { get; set; }

        [Display(Name = "Ret. Description")]
        public string BaseOnDescription { get; set; }

        [Display(Name = "EventCodeId")]
        public int? EventCodeId { get; set; }
        [Display(Name = "EventCodeId")]
        public string EventCode2 { get; set; }
        [UIHint("EventCodeId")]
        public EventCodeViewModel EventCode { get; set; }

        [Display(Name = "Period")]
        public string Period { get; set; }

        [Display(Name = "Retention")]
        public string Name { get
            {
                return BasedOnCode + "-" + BaseOnDescription;
            }
            set { }
        }
    }
}