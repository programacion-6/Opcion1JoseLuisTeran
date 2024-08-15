using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Concrets;

public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    private readonly List<T> _entities = new List<T>();

    public void Create(T entity)
    {
        _entities.Add(entity);
    }

    public void Delete(T entity)
    {
        _entities.Remove(entity);
    }

    public IEnumerable<T> GetAll()
    {
        return _entities;
    }

    public void Update(T entity)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetByParameter(Func<T, bool> predicate)
    {
        return _entities.Where(predicate);
    }
}
