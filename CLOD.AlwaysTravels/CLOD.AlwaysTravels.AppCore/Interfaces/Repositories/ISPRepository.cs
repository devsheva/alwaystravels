using CLOD.AlwaysTravels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.AppCore.Interfaces.Repositories
{
    public interface ISPRepository : IRepositoryBase<SP, int>
    {
        Task<IEnumerable<SP>> GetByStageAsync(int stageId);
        Task<IEnumerable<SP>> GetByPackageAsync(int packageId);

    }
}
