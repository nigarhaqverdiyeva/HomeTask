namespace _30102024;
public class Program
{
    static void Main(string[] args)
    {
        Wolf wolf = new Wolf(10, Gender.Male, "Gray Wolf", 100, true, 15);
        Elephant elephant = new Elephant(60, Gender.Female, "African Elephant", 300, 6000, false);
        Meat meat = new Meat(200, Meat.Type.Beef);
        Grass grass = new Grass(50, "Timothy Grass");
        ZooCage<Wolf, Meat> wolfCage = new ZooCage<Wolf, Meat>(wolf, meat);
        ZooCage<Elephant, Grass> elephantCage = new ZooCage<Elephant, Grass>(elephant, grass);
        wolf.DisplayInfo();
        elephant.DisplayInfo();
        Console.WriteLine("Before hunting:");
        Console.WriteLine($"Wolf HP: {wolf.HP}, Elephant HP: {elephant.HP}");
        wolf.Hunt(elephant); 
        Console.WriteLine("After hunting:");
        Console.WriteLine($"Wolf HP: {wolf.HP}, Elephant HP: {elephant.HP}");
    }
}


