namespace _30102024;
public class Elephant : Animal
{

    public double Weight { get; set; }
    public bool IsTrained { get; set; }
    public Elephant(int avgLifeTime, Gender gender, string breed, int hp, double weight, bool isTrained) : base(avgLifeTime, gender, breed, hp)
    {
        Weight = weight;
        IsTrained = isTrained;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Elephant - Breed: {Breed}, HP: {HP}, Weight: {Weight}kg, Trained: {IsTrained}");
    }
}
