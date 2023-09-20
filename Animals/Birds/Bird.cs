namespace ExerciseThree.Animals.Birds;

public class Bird : Animal
{
    public Bird(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void WingSpan()
    {
        throw new NotImplementedException();
    }

    public virtual void FlyingSpeed()
    {
        Console.WriteLine("Average flight of a bird is xxxx");
    }

    public override void DoSound()
    {
        Console.WriteLine("Chirping!");
    }

    public override string Stats()
    {
        return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}";
    }
}