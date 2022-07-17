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
    public class TravelsRepository : ITravelsRepository
    {
        private readonly IConfiguration _configuration;

        public TravelsRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Travel>> GetAllAsync()
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.QueryAllAsync<Travel>();
        }

        public async Task<Travel> GetAsync(int id)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return (await DB.QueryAsync<Travel>(t => t.Id == id)).FirstOrDefault();
        }

        public async Task<int> InsertAsync(Travel model)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.InsertAsync<Travel, int>(model);
        }

        public Task<int> UpdateAsync(Travel model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
