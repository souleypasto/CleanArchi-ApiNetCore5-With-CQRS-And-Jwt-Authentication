using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Application.Contracts.Persistence
{
    public interface IGenericRepository<T> where T : class
    {
        public Task<List<T>> Get();
        public Task<T> Get(Guid id);
        public Task<T> Get(int id);
        public Task Add(T entity);
        public Task Delete(T entity);
        public Task Update(T entity);
        public Task<bool> Exists(int id);
        public Task<bool> Exists(Guid id);

    }
}
