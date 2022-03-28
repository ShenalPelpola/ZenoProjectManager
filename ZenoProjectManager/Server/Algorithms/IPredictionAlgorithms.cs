using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities.RequestFormats;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Server.Algorithms
{
    public interface IPredictionAlgorithms
    {
        PredictionResponse SimpleMovingAverage(PredictionRequest predictionRequest);
    }
}
