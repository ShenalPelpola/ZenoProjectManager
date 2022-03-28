using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZenoProjectManager.Shared.Entities.ResponseFormats
{
    public class PredictionResponse
    {
        public DateTime PredictionDate { get; set; }
        public int Current { get; set; }
        public int MonthlyAvg { get; set; }
        public int Prediction { get; set; }
    }
}
