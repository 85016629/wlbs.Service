using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace wlbs.Service.Domain.Core
{
    public interface IRepository<TAggregateRoot, Tkey> where TAggregateRoot : IAggregateRoot
    {
        Task<int> AddAsync(TAggregateRoot entity);
        Task<int> UpdateAsync(TAggregateRoot entity);
        Task<int> RemoveAsync(Tkey id);
        Task<TAggregateRoot> FindById(Tkey id);
        Task<TAggregateRoot> FindById(object[] ids);
    }
}
