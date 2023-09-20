namespace ExerciseThree.Animals;

public class Dog : Animal
{
    public Dog(string name, int age, double weight) : base(name, age, weight)
    {
    }
    public void BarkOfTheDevil()
    {
        Console.WriteLine("Barks so loud you can se the devil coming out his mouth!");
    }
    public override void DoSound()
    {
        Console.WriteLine("Barking");
    }

    public override string Stats()
    {

        return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}";
    }

    public string SpecialAttack()
    {
        return "Attacks with paws of fury!";
    }
}