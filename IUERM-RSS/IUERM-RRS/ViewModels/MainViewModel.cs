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
        public string Name { get; set; }
    }

    public class IdNameViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
    public class DispositionOptionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Disposition Option")]
        public string Name { get; set; }
    }

    public class EventCodeViewModel
    {

        [Display(Name = "Code")]
        public string Code { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }
    }

    public class OfficeOfRecordViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Code")]
        public string Code { get; set; }
    }

    public class RetentionViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Ret.Code")]
        public string BasedOnCode { get; set; }

        [Display(Name = "Ret. Description")]
        public string BaseOnDescription { get; set; }

        [Display(Name = "Event Code")]
        public string EventCode { get; set; }

        [Display(Name = "Period")]
        public string Period { get; set; }
    }
}