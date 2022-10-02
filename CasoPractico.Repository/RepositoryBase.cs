using CasoPractico.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryForWrite<T>, IRepositoryForRead<T> where T : class
    {
        protected TransactionsDbContext _repositoryContext;
        public RepositoryBase(TransactionsDbContext repositoryContext)
        => _repositoryContext = repositoryContext;

        /// <summary>
        /// Get all entities of type T
        /// </summary>
        /// <param name="trackChanges"></param>
        /// <returns></returns>
        public IQueryable<T> GetAllAsync(bool trackChanges) => !trackChanges ? _repositoryContext.Set<T>().AsNoTracking() : _repositoryContext.Set<T>();


        public IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges) => !trackChanges ?
            _repositoryContext.Set<T>()
            .Where(expression)
            .AsNoTracking() :
            _repositoryContext.Set<T>()
            .Where(expression);


        public ValueTask<T> GetByIdAsync(params object[] keyValues) => _repositoryContext.Set<T>().FindAsync(keyValues);

        public void Create(T entity) => _repositoryContext.Set<T>().Add(entity);
        public void Update(T entity) => _repositoryContext.Set<T>().Update(entity);
        public void Delete(T entity) => _repositoryContext.Set<T>().Remove(entity);
        public void CreateRange(T entity) => _repositoryContext.Set<T>().AddRange(entity);
        public void UpdateRange(T entity) => _repositoryContext.Set<T>().UpdateRange(entity);
        public void DeleteRange(T entity) => _repositoryContext.Set<T>().RemoveRange(entity);
    }
}
