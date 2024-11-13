using System.Net;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_micro_project;
public class Library
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books { get; set; }
    public Library(int id, string name)
    {
        Id = id;
        Name = name;
        Books = new List<Book>();
    }

    public Library()
    {
    }

    public void Add(Book book)
    {
        Books.Add(book);
        Console.WriteLine($"{book.Name} added to the library");
    }
    public Book GetBookById(int bookId)
    {
        foreach (var book in Books)
        {
            if (book.Id == bookId)
                return book;
        }
        return null; 
    }
    public void Remove(int BookId) 
    {
        var bookToRemove = GetBookById(BookId);
        if (bookToRemove != null)
        {
            Books.Remove(bookToRemove);
            Console.WriteLine($"Book '{bookToRemove.Name}'  removed from the library.");
        }
        else
        {
            Console.WriteLine($"Book with Id {BookId} not found.");
          
        }
    }
}

