namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

public class Book : IEntityBase
{
    public Guid Id { get; set; }
    public string _isbn { get; set; }
    public string _title { get; set; }
    public string _description { get; set; }
    public Language _language { get; set; }
    public string _author { get; set; }
    public int _publicationYear { get; set; }
    public Genre _genre { get; set; }

    public Book() {}

    public Book(Guid id, string isbn, string title, string description, 
                Language language, string author, int publicationYear, Genre genre)
    {
        Id = id;
        _isbn = isbn;
        _title = title;
        _description = description;
        _language = language;
        _author = author;
        _publicationYear = publicationYear;
        _genre = genre;
    }

    public override string ToString()
    {
        return 
            $"Title: {_title}\n" +
            $"Description: {_description}\n" +
            $"Author: {_author}\n" +
            $"Genre: {_genre}\n" +
            $"Language: {_language}\n" +
            $"Publication Year: {_publicationYear}\n" +
            $"ISBN: {_isbn}\n";
    }
}
