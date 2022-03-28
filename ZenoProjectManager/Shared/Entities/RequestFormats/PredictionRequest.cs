using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoProjectManager.Shared.Entities.RequestFormats
{
    public class PredictionRequest
    {
        public Guid CompanyId { get; set; }
        public DateTime CompanyCreatedDate { get; set; }
        public DateTime PredictionDate { get; set; }
    }
}
