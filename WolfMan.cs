namespace ExerciseThree;

public class WolfMan : Wolf, IPerson
{
    public WolfMan(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void Talk()
    {
        Console.WriteLine("Thinking of when the full moon will come!");
    }
}