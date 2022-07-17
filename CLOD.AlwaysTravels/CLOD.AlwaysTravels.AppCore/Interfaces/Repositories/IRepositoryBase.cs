using CLOD.AlwaysTravels.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLOD.AlwaysTravels.AppCore.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity,TPrimaryKey> where TEntity : EntityBase<TPrimaryKey>
    {
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<TEntity> GetAsync(TPrimaryKey id);
        Task<TPrimaryKey> InsertAsync(TEntity model);
        Task<TPrimaryKey> UpdateAsync(TEntity model);
        Task<TPrimaryKey> DeleteAsync(TPrimaryKey id);

    }
}
