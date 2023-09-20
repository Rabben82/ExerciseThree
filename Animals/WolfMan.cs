namespace ExerciseThree.Animals;

public class WolfMan : Wolf, IPerson
{
    public WolfMan(string name, int age, double weight, int attackClawsOfTerrorDamage) : base(name, age, weight, attackClawsOfTerrorDamage)
    {
    }

    public void ClawsOfTerror()
    {
        throw new NotImplementedException();
    }

    public void Talk()
    {
        Console.WriteLine("Thinking of when the full moon will come!");
    }
}