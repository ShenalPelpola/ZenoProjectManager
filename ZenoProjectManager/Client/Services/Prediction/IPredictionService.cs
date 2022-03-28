using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoProjectManager.Shared.Entities.RequestFormats;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Client.Services.Prediction
{
    public interface IPredictionService
    {
        Task<PredictionResponse> GetProjectsPrediction(PredictionRequest predictionRequest);
        Task<IEnumerable<UserPredictionResponse>> GetUserPrediction(PredictionRequest predictionRequest);
    }
}
