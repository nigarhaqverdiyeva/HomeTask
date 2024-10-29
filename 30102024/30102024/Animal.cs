using System.Reflection;

namespace _30102024;
public abstract class Animal
{
    public int AvgLifeTime { get; set; }
    public Gender Gender { get; set; }
    public string Breed { get; set; }
    public int HP { get; set; }

    public Animal(int avgLifeTime, Gender gender, string breed, int hp)
    {
        AvgLifeTime = avgLifeTime;
        Gender = gender;
        Breed = breed;
        HP = hp;
    }
    public abstract void DisplayInfo();
}
