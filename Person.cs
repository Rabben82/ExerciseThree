namespace ExerciseThree;

public class Person
{
    private int age;
    private string firstName = null!;
    private string lastName = null!;
    private double height;
    private double weight;
    public int Age
    {
        get => age;
        set
        {
            if (value > 0)
            {
                age = value;
            }
            else
            {
                throw new ArgumentException("Age must be greater than 0.");
            }
        }
    }
    public string Firstname
    {
        get => firstName;
        set
        {
            if (value.Length >= 2 && value.Length < 10)
            {
                firstName = value;
            }
            else
            {
                throw new ArgumentException("First name need to be bigger than 2 characters and not greater than 10.");
            }
        }
    }
    public string LastName
    {
        get => lastName;
        set
        {
            if (value.Length >= 3 && value.Length < 15)
            {
                lastName = value;
            }
            else
            {
                throw new ArgumentException("Last name need to be bigger than 3 characters and less than 15.");
            }
        }
    }
    public double Height
    {
        get => height;
        set => height = value;
    }
    public double Weight
    {
        get => weight;
        set => weight = value;
    }


}