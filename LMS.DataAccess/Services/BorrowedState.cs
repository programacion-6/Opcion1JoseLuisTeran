using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Services;

public class BorrowedState : IBookState
{
    private Member _borrower;

    public BorrowedState(Member borrower)
    {
        _borrower = borrower;
    }

    public void Borrow(Book book, Member member)
    {
        Console.WriteLine($"'{book.Title}' is already borrowed by {_borrower.FirstName}. Double booking is not allowed.");
    }

    public void Return(Book book)
    {
        book.State = new AvailableState();
        Console.WriteLine($"'{book.Title}' has been returned by {_borrower.FirstName}");
    }

    public bool IsAvailable() => false;
}
