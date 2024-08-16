using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Concrets;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;
using Opcion1JoseLuisTeran.LMS.DataAccess.Services;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.UI;

public class BorrowComponents
{
    private static IBookRepository _bookRepository = new BookRepository();
    private static Member _loggedInMember;

    public static void BorrowBook()
    {
        Console.Clear();
        Console.WriteLine("Enter ISBN of the book you want to borrow:");
        string isbn = Console.ReadLine();

        var book = _bookRepository.GetByIsbn(isbn);
        if (book != null)
        {
            try
            {
                book.Borrow(_loggedInMember, DateTime.Now.AddDays(14));
                Console.WriteLine("Book borrowed successfully. Press any key to continue.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Book not found. Press any key to continue.");
        }
        Console.ReadKey();
    }

    public static void ReturnBook()
    {
        Console.Clear();
        Console.WriteLine("Enter ISBN of the book you want to return:");
        string isbn = Console.ReadLine();

        var book = _bookRepository.GetByIsbn(isbn);
        if (book != null)
        {
            try
            {
                book.Return();
                Console.WriteLine("Book returned successfully. Press any key to continue.");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        else
        {
            Console.WriteLine("Book not found. Press any key to continue.");
        }
        Console.ReadKey();
    }

    public static void CheckBookAvailability()
    {
        Console.Clear();
        Console.WriteLine("Enter ISBN of the book you want to check:");
        string isbn = Console.ReadLine();

        var book = _bookRepository.GetByIsbn(isbn);
        if (book != null)
        {
            Console.WriteLine($"Book '{book.Title}' is {(book.State is AvailableState ? "available" : "not available")}.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}
