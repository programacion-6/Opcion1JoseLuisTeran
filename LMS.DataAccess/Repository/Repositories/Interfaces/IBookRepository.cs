using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

public interface IBookRepository : IBaseRepository<Book>
{
    Book GetByIsbn(string isbn);
}
