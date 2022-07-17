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
    public class StagesRepository : IStagesRepository
    {
        private readonly IConfiguration _configuration;

        public StagesRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<IEnumerable<Stage>> GetByTravelAsync(int travelId)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.QueryAsync<Stage>(s => s.TravelId == travelId);
        }

        public async Task<IEnumerable<Stage>> GetAllAsync()
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.QueryAllAsync<Stage>();
        }

        public async Task<Stage> GetAsync(int id)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return (await DB.QueryAsync<Stage>(s => s.Id == id)).FirstOrDefault();
        }

        public async Task<int> InsertAsync(Stage model)
        {
            var cs = _configuration.GetConnectionString("AlwaysTravelsDB");
            using var DB = new NpgsqlConnection(cs);
            return await DB.InsertAsync<Stage, int>(model);
        }

        public Task<int> UpdateAsync(Stage model)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
