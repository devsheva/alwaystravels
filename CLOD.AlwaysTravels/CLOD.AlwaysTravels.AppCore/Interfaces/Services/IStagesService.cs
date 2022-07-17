using CLOD.AlwaysTravels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.AppCore.Interfaces.Services
{
    public interface IStagesService
    {
        Task<IEnumerable<Stage>> GetAllStagesAsync();
        Task<Stage> GetStageAsync(int id);
        Task<IEnumerable<Stage>> GetStagesByTravelIdAsync(int travelId);
        Task<int> InsertStageAsync(Stage stage);
    }
}
