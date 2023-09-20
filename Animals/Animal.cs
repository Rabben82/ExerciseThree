namespace ExerciseThree.Animals;

public abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Weight { get; set; }

    public List<Animal> animals = new List<Animal>();

    protected Animal(string name, int age, double weight)
    {
        Name = name;
        Age = age;
        Weight = weight;
    }
    public abstract void DoSound();

    public abstract string Stats();

}