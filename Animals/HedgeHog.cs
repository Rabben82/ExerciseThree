namespace ExerciseThree.Animals;

public class HedgeHog : Animal
{
    public HedgeHog(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void NrOfSpikes()
    {
        throw new NotImplementedException();
    }
    public override void DoSound()
    {
        Console.WriteLine("Grunting and snuffing!");
    }

    public override string Stats()
    {
        return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}";
    }
}