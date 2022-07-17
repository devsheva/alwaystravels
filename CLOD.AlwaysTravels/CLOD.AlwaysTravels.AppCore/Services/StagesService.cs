using CLOD.AlwaysTravels.AppCore.Interfaces.Repositories;
using CLOD.AlwaysTravels.AppCore.Interfaces.Services;
using CLOD.AlwaysTravels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.AppCore.Services
{
    public class StagesService : IStagesService
    {
        private readonly IStagesRepository _stagesRepository;

        public StagesService(IStagesRepository stagesRepository)
        {
            _stagesRepository = stagesRepository;
        }

        public Task<IEnumerable<Stage>> GetAllStagesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Stage> GetStageAsync(int id)
        {
            var obj = await _stagesRepository.GetAsync(id);
            return obj;
        }

        public async Task<IEnumerable<Stage>> GetStagesByTravelIdAsync(int travelId)
        {
            var list = await _stagesRepository.GetByTravelAsync(travelId);
            return list;
        }

        public async Task<int> InsertStageAsync(Stage stage)
        {
            var id = await _stagesRepository.InsertAsync(stage);
            return id;
        }
    }
}
