namespace Library_micro_project;
public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public decimal Price { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Author: {AuthorName}, Price: {Price:C}");
    }
}
