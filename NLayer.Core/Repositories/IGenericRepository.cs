using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAll();

        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        //Yazmış olduğun sorgular direkt veritabanına gitmez tolist tolistasync kullanırsan veritabanına gider.(Daha performanslı çalışır)
        // Delegeler metotları işaret eder.

        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task AddAsync(T entity);

        Task AddRangeAsync(IEnumerable<T> entities);

        void Update(T entity);

        void Remove(T entity);

        void RemoveRange(IEnumerable<T> entities);

    }
}
