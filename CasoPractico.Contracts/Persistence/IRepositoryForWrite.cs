using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoPractico.Contracts.Persistence
{
    public interface IRepositoryForWrite<T>
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        void CreateRange(T entity);
        void UpdateRange(T entity);
        void DeleteRange(T entity);
    }
}
