using System.Linq.Expressions;

namespace CasoPractico.Contracts.Persistence
{
    public interface IRepositoryForRead<T>
    {
        ValueTask<T> GetByIdAsync(params object[] keyValues);
        IQueryable<T> GetAllAsync(bool trackChanges);
        IQueryable<T> GetByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
    }
}
