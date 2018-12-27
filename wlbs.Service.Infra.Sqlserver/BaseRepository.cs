using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using wlbs.Service.Domain.Core;

namespace wlbs.Service.Infra.Sqlserver
{
    public class BaseRepository<T, Tkey> : IRepository<T, Tkey> where T : AggregateRoot<Tkey>
    {
        protected WriteDbContext dbContext = new WriteDbContext();
        public async Task<int> AddAsync(T entity)
        {
            await dbContext.AddAsync(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<T> FindById(Tkey id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }

        public async Task<T> FindById(object[] ids)
        {
            return await dbContext.Set<T>().FindAsync(ids);
        }

        public async Task<int> RemoveAsync(Tkey id)
        {
            var entity = await dbContext.Set<T>().FindAsync(id);
            dbContext.Remove(entity);
            return await dbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAsync(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            return await dbContext.SaveChangesAsync();
        }
    }
}
