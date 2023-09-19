namespace ExerciseThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 3.1 1-2
            //var person = new Person();

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


            #endregion


            #region Task 3.1 3-5
            var personHandler = new PersonHandler();

            var person1 = personHandler.CreatePerson(10, "christian", "rabb", 1.78, 72);
            var person2 = personHandler.CreatePerson(20, "Kathleen", "Johansson", 1.68, 65);

            personHandler.PrintPerson(person1);
            personHandler.PrintPerson(person2);


            personHandler.SetLastName(person2, "rabben");

            personHandler.PrintPerson(person2);
            #endregion

            #region Task 3.2 1-10
            List<UserError> userErrors = new List<UserError>();
            TextInputError textInputError = new TextInputError();
            NumericInputError numericInputError = new NumericInputError();
            BlankSpaceOrEmptyError blankSpaceOrEmptyError = new BlankSpaceOrEmptyError();
            AgeInputError ageInputError = new AgeInputError();
            NameInputError nameInputError = new NameInputError();
            userErrors.Add(textInputError);
            userErrors.Add(numericInputError);
            userErrors.Add(blankSpaceOrEmptyError);
            userErrors.Add(ageInputError);
            userErrors.Add(nameInputError);

            foreach (var errors in userErrors)
            {
                Console.WriteLine(errors.UeMessage());
            }
            #endregion

        }
    }
}