namespace ExerciseThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var personHandler = new PersonHandler();

            personHandler.SetAge(person, 45);
       
            try
            {
                person.Age = 3;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            try
            {
                person.Firstname = "Christian";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            try
            {
                person.LastName = "Rabb";
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");

            }


        }
    }
}