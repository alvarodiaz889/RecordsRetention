using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IUERM_RRS.ViewModels
{
    public class ScheduleViewModelEdit
    {
        public Guid Id { get; set; }
        public string StewardDomain { get; set; }
        public string RetentionArea { get; set; }
        public string RetentionSubArea { get; set; }
        public int AreaScopeId { get; set; }
        public string RetentionAreaDescription { get; set; }
        public string Type { get; set; }
        public int OfficeId { get; set; }
        public string Coordinator { get; set; }
        public string RecordSeries { get; set; }
        public string RecordSeriesCode { get; set; }
        public string Description { get; set; }
        public int RetentionId { get; set; }
        public string Active { get; set; }
        public string Vital { get; set; }
        public int GoverningStatutesId { get; set; }
        public int GoverningRegulationsId { get; set; }
        public int GoverningPoliciesId { get; set; }
        public string Reason { get; set; }
        public int RecordMedium { get; set; }
        public int RetainerId { get; set; }
        public int DispositionId { get; set; }
        public bool RquiresCertDestruction { get; set; }

    }
}