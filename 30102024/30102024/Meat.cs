namespace _30102024;
public class Meat : Food
{
    public Type MeatType { get; set; }
    public Meat(int calorie, Type meatType) : base(calorie)
    {
        MeatType = meatType;
    }
    public enum Type
    {
        Beef,
        Chicken,
        Pork
    }

}
