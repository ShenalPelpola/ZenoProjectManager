using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenoProjectManager.Server.Model;
using ZenoProjectManager.Shared.Entities.RequestFormats;
using ZenoProjectManager.Shared.Entities.ResponseFormats;

namespace ZenoProjectManager.Server.Algorithms
{
    public class PredictionAlgorithms : IPredictionAlgorithms
    {
        private readonly IProjectRepository _projectRepository;
        private readonly ICompanyRepository _companyRepository;

        public PredictionAlgorithms(IProjectRepository projectRepository,
                ICompanyRepository companyRepository)
        {
            _projectRepository = projectRepository;
            _companyRepository = companyRepository;
        }

        public PredictionResponse SimpleMovingAverage(PredictionRequest predictionRequest)
        {
            throw new NotImplementedException();
        }
    }
}
