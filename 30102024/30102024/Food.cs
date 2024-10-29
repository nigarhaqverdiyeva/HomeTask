namespace _30102024;
public abstract class Food
{
    public int Calorie { get; set; }

    protected Food(int calorie)
    {
        Calorie = calorie;
    }
}
