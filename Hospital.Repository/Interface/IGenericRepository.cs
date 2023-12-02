using System.Linq.Expressions;

namespace Hospital.Repository.Interface
{

    public interface IGenericRepository<T> : IDisposable
    {
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null,
            string includeProperties = "");

        T GetById(object id);
        Task<T> GetByIdAsync(object id);
        void Add(T entity);
        Task<T> AddAsyncs(T entity);
        void Update(T entity);
        Task<T> UpdateAsyncs(T entity);
        void Delete(T entity);
        Task<T> DeleteAsyncs(T entity);


    }
}
