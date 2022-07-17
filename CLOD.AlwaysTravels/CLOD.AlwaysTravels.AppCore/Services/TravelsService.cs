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
    public class TravelsService : ITravelsService
    {
        private readonly ITravelsRepository _travelsRepository;
        public TravelsService(ITravelsRepository travelsRepository)
        {
            _travelsRepository = travelsRepository;
        }

        public async Task<IEnumerable<Travel>> GetAllTravelsAsync()
        {
            var list = await _travelsRepository.GetAllAsync();
            return list;
        }

        public async Task<Travel> GetTravelByIdAsync(int id)
        {
            var obj = await _travelsRepository.GetAsync(id);
            return obj;
        }

        public async Task<int> InsertTravelAsync(Travel travel)
        {
            var id = await _travelsRepository.InsertAsync(travel);
            return id;
        }
    }
}
