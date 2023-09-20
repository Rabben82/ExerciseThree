namespace ExerciseThree.Animals.Birds;

public class Flamingo : Bird
{
    public Flamingo(string name, int age, double weight) : base(name, age, weight)
    {
    }

    public override void FlyingSpeed()
    {
        Console.WriteLine("The speed of a flamingo is xxxx");
    }

    public void WingsOfStorm()
    {
        Console.WriteLine("Flaps the wings so hard it's like a storm hitting you!");
    }
}