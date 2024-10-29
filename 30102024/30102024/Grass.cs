namespace _30102024;
public class Grass : Food
{
    public string Name { get; set; }
    public Grass(int calorie, string name) : base(calorie)
    {
        Name = name;
    }
}
