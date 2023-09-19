namespace ExerciseThree;

public class Bird : Animal
{
    public Bird(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void WingSpan()
    {
    }
    public override void DoSound()
    {
        Console.WriteLine("Chirping!");
    }
}