namespace ExerciseThree.Animals.Reptiles;

public class Snake : Animal
{
    public Snake(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void IsPoisonous()
    {
        throw new NotImplementedException();
    }
    public override void DoSound()
    {
        Console.WriteLine("Hissing!");
        ;
    }

    public override string Stats()
    {
        return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}";
    }
}