namespace ExerciseThree;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public Animal(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }
    public abstract void DoSound();

}