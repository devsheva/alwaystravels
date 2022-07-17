using CLOD.AlwaysTravels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.AppCore.Interfaces.Services
{
    public interface ITravelsService
    {
        Task<IEnumerable<Travel>> GetAllTravelsAsync();
        Task<Travel> GetTravelByIdAsync(int id);
        Task<int> InsertTravelAsync(Travel travel);


    }
}
