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
    public class SPRepository : ISPRepository
    {
        private readonly IConfiguration _configuration;

        public SPRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<SP>> GetByStageAsync(int stageId)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.QueryAsync<SP>(sp => sp.StageId == stageId);
        }

        public async Task<IEnumerable<SP>> GetByPackageAsync(int packageId)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.QueryAsync<SP>(sp => sp.PackageId == packageId);
        }

        public Task<IEnumerable<SP>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<SP> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<int> InsertAsync(SP model)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.InsertAsync<SP, int>(model);
        }

        public Task<int> UpdateAsync(SP model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
