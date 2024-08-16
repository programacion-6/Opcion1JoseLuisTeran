using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Concrets;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.UI;

public class BookComponents
{
    public static IBookRepository _bookRepository = new BookRepository();
    private static BookRepository bookRepository = new BookRepository();

    public static void AddBook()
    {
        Console.Clear();
        Console.WriteLine("Enter Book Details");
        Console.Write("ISBN: ");
        string isbn = Console.ReadLine();
        Console.Write("Title: ");
        string title = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Language (ENGLISH/SPANISH/FRENCH): ");
        Language language = (Language)Enum.Parse(typeof(Language), Console.ReadLine().ToUpper());
        Console.Write("Author: ");
        string author = Console.ReadLine();
        Console.Write("Publication Year: ");
        int publicationYear = int.Parse(Console.ReadLine());
        Console.Write("Genre (ADVENTURE/ROMANCE/HORROR/FANTASY/POETRY): ");
        Genre genre = (Genre)Enum.Parse(typeof(Genre), Console.ReadLine().ToUpper());

        var book = new Book(isbn, title, description, language, author, publicationYear, genre);
        _bookRepository.Create(book);
        Console.WriteLine("Book added successfully. Press any key to continue.");
        Console.ReadKey();
    }

    public static void ViewAllBooks()
    {
        Console.Clear();
        Console.WriteLine("All Books:");
        foreach (var book in _bookRepository.GetAll())
        {
            Console.WriteLine(book);
            Console.WriteLine();
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }

    public static void SearchBooks()
    {
        Console.Clear();
        Console.WriteLine("Search Books");
        Console.WriteLine("1. By Author");
        Console.WriteLine("2. By Title");
        Console.WriteLine("3. By Language");
        Console.WriteLine("4. By Publication Year");
        Console.WriteLine("5. By Genre");
        Console.Write("Select an option: ");
        string option = Console.ReadLine();

        IEnumerable<Book> books;
        switch (option)
        {
            case "1":
                Console.Write("Enter Author: ");
                string author = Console.ReadLine();
                books = bookRepository.GetByAuthor(author);
                break;
            case "2":
                Console.Write("Enter Title: ");
                string title = Console.ReadLine();
                books = bookRepository.GetByTitle(title);
                break;
            case "3":
                Console.Write("Enter Language (ENGLISH/SPANISH/FRENCH): ");
                Language language = (Language)Enum.Parse(typeof(Language), Console.ReadLine().ToUpper());
                books = bookRepository.GetByLanguage(language);
                break;
            case "4":
                Console.Write("Enter Publication Year: ");
                int publicationYear = int.Parse(Console.ReadLine());
                books = bookRepository.GetByPublicationYear(publicationYear);
                break;
            case "5":
                Console.Write("Enter Genre (ADVENTURE/ROMANCE/HORROR/FANTASY/POETRY): ");
                Genre genre = (Genre)Enum.Parse(typeof(Genre), Console.ReadLine().ToUpper());
                books = bookRepository.GetByGenre(genre);
                break;
            default:
                Console.WriteLine("Invalid option, returning to Admin Menu.");
                return;
        }

        Console.Clear();
        Console.WriteLine("Search Results:");
        foreach (var book in books)
        {
            Console.WriteLine(book);
            Console.WriteLine();
        }
        Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
    }
}
