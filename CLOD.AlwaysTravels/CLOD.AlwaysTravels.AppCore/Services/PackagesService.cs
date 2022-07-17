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
    public class PackagesService : IPackagesService
    {
        private readonly IPackagesRepository _packagesRepository;

        public PackagesService(IPackagesRepository packagesRepository)
        {
            _packagesRepository = packagesRepository;
        }

        public async Task<IEnumerable<Package>> GetAllPackagesAsync()
        {
            var list = await _packagesRepository.GetAllAsync();
            return list;
        }

        public async Task<Package> GetPackageAsync(int id)
        {
            var obj = await _packagesRepository.GetAsync(id);
            return obj;
        }

        public async Task<int> InsertPackageAsync(Package package)
        {
            var id = await _packagesRepository.InsertAsync(package);
            return id;
        }

        
    }
}
