namespace _30102024;
public class Wolf : Animal
{
    public bool IsPrideLeader { get; set; }
    public int AttackDamage { get; set; }

    public Wolf(int avgLifeTime, Gender gender, string breed, int hp, bool isPrideLeader, int attackDamage) : base(avgLifeTime, gender, breed, hp)
    {
        IsPrideLeader = isPrideLeader;
        AttackDamage = attackDamage;
    }

    public void Hunt<T>(T animal) where T : Animal
    {
        animal.HP -= AttackDamage;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Wolf - Breed: {Breed}, HP: {HP}, Leader: {IsPrideLeader}");
    }
}
