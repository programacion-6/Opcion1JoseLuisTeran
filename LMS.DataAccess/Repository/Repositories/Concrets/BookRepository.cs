using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;
using Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Interfaces;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Repositories.Concrets;

public class BookRepository : BaseRepository<Book>, IBookRepository
{
    public Book GetByIsbn(string isbn)
    {
        return GetByParameter(book => book.ISBN == isbn).FirstOrDefault();
    }

    public IEnumerable<Book> GetByAuthor(string author)
    {
        return GetByParameter(book => book.Author == author);
    }

    public IEnumerable<Book> GetByTitle(string title)
    {
        return GetByParameter(book => book.Title == title);
    }

    public IEnumerable<Book> GetByLanguage(Language language)
    {
        return GetByParameter(book => book.Language == language);
    }

    public IEnumerable<Book> GetByPublicationYear(int publicationYear)
    {
        return GetByParameter(book => book.PublicationYear == publicationYear);
    }

    public IEnumerable<Book> GetByGenre(Genre genre)
    {
        return GetByParameter(book => book.Genre == genre);
    }
}
