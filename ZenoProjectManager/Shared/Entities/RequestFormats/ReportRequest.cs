using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoProjectManager.Shared.Entities.RequestFormats
{
    public class ReportRequest
    {
        public Guid CompanyId { get; set; }
        public Guid ProjectId { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
