namespace ExerciseThree;

public class PersonHandler
{
    public void SetAge(Person pers, int age)
    {
        pers.Age = age;
    }
    public void SetFirstName(Person pers, string fName)
    {
        pers.FirstName = fName;
    }
    public void SetLastName(Person pers, string lName)
    {
        pers.LastName = lName;
    }
    public void SetHeight(Person pers, double height)
    {
        pers.Height = height;
    }
    public void SetWeight(Person pers, double weight)
    {
        pers.Weight = weight;
    }
    public Person CreatePerson(int age, string fName, string lName, double height, double weight)
    {
        Person person = new Person();
        try
        {
            person.Age = age;
            person.FirstName = fName;
            person.LastName = lName;
            person.Height = height;
            person.Weight = weight;
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error when creating person: {e.Message}");
        }


        return person;
    }
    //Use this method to update the current person if needed
    public void UpdatePerson(Person person, int age, string newFName, string newLName, double newHeight, double newWeight)
    {
        try
        {
            if (age > 0)
            {
                person.Age = age;
            }

            if (!string.IsNullOrWhiteSpace(newFName) && newFName.Length >= 2 && newFName.Length <= 10)
            {
                person.FirstName = newFName;
            }

            if (!string.IsNullOrWhiteSpace(newLName) && newLName.Length >= 3 && newLName.Length <= 15)
            {
                person.LastName = newLName;
            }

            if (newHeight >= 0)
            {
                person.Height = newHeight;
            }

            if (newWeight >= 0)
            {
                person.Weight = newWeight;
            }
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Error updating person: {e.Message}");
        }
    }

    public void PrintPerson(Person person)
    {
        Console.WriteLine($"Firstname: {person.FirstName}\nLastName: {person.LastName}\nAge: {person.Age}\nHeight: {person.Height}\nWeight: {person.Weight}");
        Console.WriteLine(".......................................");
    }
}