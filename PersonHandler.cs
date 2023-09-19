namespace ExerciseThree;

public class PersonHandler
{
    public void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }
    public Person CreatePerson(Person pers, int age, string fName, string lName, double height, double weight)
    {
        pers.Age = age;
        pers.Firstname = fName;
        pers.LastName = lName;
        pers.Height = height;
        pers.Weight = weight;
        return new Person();
    }
}