namespace _20102024;
public class Singer
{
    public string name { get; set; }
    public string surname { get; set; }
    public int age { get; set; }

    public Singer(string name, string surname, int age)
    {
        if (name.Length > 170)
        {
            Console.WriteLine("Invalid Name");
            return;
        }
        if(surname.Length>170) 
        {
            Console.WriteLine("Invalid Surname");
            return;
        }
        if (age < 0 || age > 170)
        {
            Console.WriteLine("Invalid Age");
            return;
        }
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    public override string ToString()
    {
        return $"Singer: {name} , {surname}  Age: {age}";
    }
}


 

