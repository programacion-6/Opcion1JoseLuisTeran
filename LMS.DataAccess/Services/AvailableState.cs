using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Services;

public class AvailableState : IBookState
{
    public void Borrow(Book book, Member member)
    {
        book.State = new BorrowedState(member);
        Console.WriteLine($"{member.FirstName} borrowed '{book.Title}'");
    }

    public void Return(Book book)
    {
        Console.WriteLine($"'{book.Title}' is already available in the library.");
    }

    public bool IsAvailable() => true;
}
