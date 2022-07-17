using CLOD.AlwaysTravels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.AppCore.Interfaces.Services
{
    public interface IPackagesService
    {
        Task<Package> GetPackageAsync(int id);
        Task<int> InsertPackageAsync(Package package);

    }
}
