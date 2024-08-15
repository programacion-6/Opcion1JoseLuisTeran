using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

public interface IBaseRepository<T>
{
    void Create(T entity);
    void Update(T entity);
    void Delete(T entity);
    IEnumerable<T> GetAll();
}
