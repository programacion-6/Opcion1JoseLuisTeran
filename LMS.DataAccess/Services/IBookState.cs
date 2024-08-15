using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Services;

public interface IBookState
{
    void Borrow(Book book, Member member);
    void Return(Book book);
    bool IsAvailable();
}
