namespace ExerciseThree;

public class Wolf : Animal
{
    public Wolf(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void HowlOfThunder()
    {
    }
    public override void DoSound()
    {
        Console.WriteLine("Howling");
    }
}