using Opcion1JoseLuisTeran.LMS.DataAccess.Services;

namespace Opcion1JoseLuisTeran.LMS.DataAccess.Repository.Entities;

public class Book : IEntityBase
{
    public Guid Id { get; }
    private string _isbn;
    private string _title;
    private string _description;
    private Language _language;
    private string _author;
    private int _publicationYear;
    private Genre _genre;
    public IBookState State { get; set; }
    public DateTime? DueDate { get; private set; }
    public Member BorrowedBy { get; private set; }

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

    public Book(string isbn, string title, string description, 
                Language language, string author, int publicationYear, Genre genre)
    {
        Id = Guid.NewGuid();
        _isbn = isbn;
        _title = title;
        _description = description;
        _language = language;
        _author = author;
        _publicationYear = publicationYear;
        _genre = genre;
        State = new AvailableState();
    }

    public string ISBN 
    {
        get => _isbn;
        set => _isbn = value;
    }

    public string Title 
    {
        get => _title;
        set => _title = value;
    }

    public string Description 
    {
        get => _description;
        set => _description = value;
    }

    public Language Language 
    {
        get => _language;
        set => _language = value;
    }

    public string Author 
    {
        get => _author;
        set => _author = value;
    }

    public int PublicationYear 
    {
        get => _publicationYear;
        set => _publicationYear = value;
    }

    public Genre Genre 
    {
        get => _genre;
        set => _genre = value;
    }

    public void Borrow(Member member, DateTime dueDate)
    {
        if (State.IsAvailable())
        {
            BorrowedBy = member;
            DueDate = dueDate;
        }
        State.Borrow(this, member);
    }

    public void Return()
    {
        BorrowedBy = null;
        DueDate = null;
        State.Return(this);
    }

    public bool IsAvailable()
    {
        return State.IsAvailable();
    }

    public override string ToString()
    {
        return 
            // $"ID: {Id}\n" +
            $"Title: {_title}\n" +
            $"Description: {_description}\n" +
            $"Author: {_author}\n" +
            $"Genre: {_genre}\n" +
            $"Language: {_language}\n" +
            $"Publication Year: {_publicationYear}\n" +
            $"ISBN: {_isbn}\n";
    }
}
