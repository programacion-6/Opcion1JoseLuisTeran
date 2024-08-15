using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

public interface IBaseRepository<T> : IDisposable where T : IEntityBase, new()
{
    Task<int> Create(T entity);
    Task<int> Update(T entity);
    Task<int> Delete(T entity);
}
