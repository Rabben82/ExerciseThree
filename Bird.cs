namespace ExerciseThree;

public class Bird : Animal
{
    public Bird(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void WingSpan()
    {
    }

    public virtual void FlyingSpeed()
    {
        Console.WriteLine("Average flight of a bird is xxxx");
    }

    public override void DoSound()
    {
        Console.WriteLine("Chirping!");
    }
}