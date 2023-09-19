namespace ExerciseThree;

public class Snake : Animal
{
    public Snake(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void IsPoisonous()
    {
    }
    public override void DoSound()
    {
        Console.WriteLine("Hissing!");
        ;
    }
}