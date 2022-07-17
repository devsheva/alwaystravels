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
    public class SPService : ISPService
    {
        private readonly ISPRepository _spRepository;

        public SPService(ISPRepository spRepository)
        {
            _spRepository = spRepository;
        }

        public async Task<IEnumerable<SP>> GetSPsByStageAsync(int stageId)
        {
            var list = await _spRepository.GetByStageAsync(stageId);
            return list;
        }

        public async Task<IEnumerable<SP>> GetSPsByPackageAsync(int packageId)
        {
            var list = await _spRepository.GetByPackageAsync(packageId);
            return list;
        }

        public async Task<int> InsertSPAsync(SP sp)
        {
            var id = await _spRepository.InsertAsync(sp);
            return id;
        }
    }
}
