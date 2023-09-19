namespace ExerciseThree;

public class HedgeHog : Animal
{
    public HedgeHog(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void NrOfSpikes()
    {
    }
    public override void DoSound()
    {
        Console.WriteLine("Grunting and snuffing!");
        ;
    }
}