using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UniveraStoreCase.DataAccess.Data;
using UniveraStoreCase.DataAccess.Repositories.IRepositories;

namespace UniveraStoreCase.DataAccess.Repositories.GenericRepositories
{
    public abstract class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly UniveraDbContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(UniveraDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }
        public IEnumerable<T> GetEntity(Expression<Func<T, bool>> expression = null, string[] navProperty = null)
        {
            IQueryable<T> entities = null;
            if (expression == null)
            {
                entities = _context.Set<T>();
            }
            else
            {
                entities = _context.Set<T>().Where(expression);
            }
            if (navProperty == null)
            {
                return entities;
            }
            else
            {
                foreach (var item in navProperty)
                {
                    entities = entities.Include(item);
                }
                return entities;
            }
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T> GetEntityByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public void Remove(int id)
        {
            T existing = _dbSet.Find(id);
            _dbSet.Remove(existing);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void SaveAsync()
        {
            _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
