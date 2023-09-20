namespace ExerciseThree.Animals;

public class Horse : Animal
{
    public Horse(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void LightningSpeed()
    {
    }

    public override void DoSound()
    {
        Console.WriteLine("Neighing!");
    }

    public override string Stats()
    {
        return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}";
    }
}