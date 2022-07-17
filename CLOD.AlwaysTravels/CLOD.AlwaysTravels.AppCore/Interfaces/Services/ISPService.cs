using CLOD.AlwaysTravels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.AppCore.Interfaces.Services
{
    public interface ISPService 
    {
        Task<IEnumerable<SP>> GetSPsByStageAsync(int stageId);
        Task<IEnumerable<SP>> GetSPsByPackageAsync(int packageId);
        Task<int> InsertSPAsync(SP sp);

    }
}
