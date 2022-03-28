using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoProjectManager.Shared.Entities.ResponseFormats
{
    public class UserPredictionResponse
    {
        public DateTime PredictionDate { get; set; }
        public Guid ProjectId { get; set; }
        public string ProjectName { get; set; }
        public int CurrentUsers { get; set; }
        public int PredictedUsers { get; set; }
    }
}
