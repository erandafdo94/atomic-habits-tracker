using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AtomicHabits.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}