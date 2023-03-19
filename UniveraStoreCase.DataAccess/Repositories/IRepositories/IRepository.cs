using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UniveraStoreCase.DataAccess.Repositories.IRepositories
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetEntityByIdAsync(int id);
        IEnumerable<T> GetEntity(Expression<Func<T, bool>> expression = null, string[] navProperty = null);
        void Remove(int id);
        void Add(T entity);
        void Update(T entity);
        void Save();
        void SaveAsync();
    }
}
