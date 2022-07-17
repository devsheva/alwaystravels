using CLOD.AlwaysTravels.AppCore.Interfaces.Repositories;
using CLOD.AlwaysTravels.Domain;
using Microsoft.Extensions.Configuration;
using Npgsql;
using RepoDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.Infrastructure.Repositories
{
    public class PackagesRepository : IPackagesRepository
    {
        private readonly IConfiguration _configuration;

        public PackagesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Package>> GetAllAsync()
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.QueryAllAsync<Package>();
        }

        public async Task<Package> GetAsync(int id)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return (await DB.QueryAsync<Package>(p => p.Id == id)).FirstOrDefault();
        }

        public async Task<int> InsertAsync(Package model)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.InsertAsync<Package, int>(model);
        }

        public Task<int> UpdateAsync(Package model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
