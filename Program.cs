namespace ExerciseThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            var personHandler = new PersonHandler();

            var person1 = personHandler.CreatePerson(10, "christian", "rabb", 1.78, 72);
            var person2 = personHandler.CreatePerson(20, "Kathleen", "Johansson", 1.68, 65);

            personHandler.PrintPerson(person1);
            personHandler.PrintPerson(person2);
   

            personHandler.SetLastName(person2,"rabben");

            personHandler.PrintPerson(person2);

            //personHandler.SetAge(person, 45);

            //try
            //{
            //    person.Age = 3;
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Error: {e.Message}");
            //}
            //try
            //{
            //    person.FirstName = "Christian";
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Error: {e.Message}");
            //}
            //try
            //{
            //    person.LastName = "Rabb";
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Error: {e.Message}");

            //}
        }
    }
}