using ExerciseThree.Animals;
using ExerciseThree.Animals.Birds;
using ExerciseThree.Animals.Reptiles;

namespace ExerciseThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 3.1 1-2
            //var person = new Person();
            //PersonHandler personHandler = new PersonHandler();
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

            var getFullName = personHandler.GetFullName(person1);
            Console.WriteLine(getFullName);
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

            #region Task 3.3 1-14
            List<Animal> animals = new List<Animal>();
            Dog dog = new Dog("Doggy",10, 15.5);
            //Added an extra property attackdamage to the wolf class so it has something different from the inherited Animal class.
            Wolf wolf = new Wolf("Wolfy", 14, 25.7, 10);
            Flamingo flamingo = new Flamingo("Flamingo",13,16);
            WolfMan wolfMan = new WolfMan("Wolfman", 45, 98, 20);

            //animals.Add(dog);
            //animals.Add(wolf);
            //animals.Add(flamingo);

            //foreach (var animal in animals)
            //{
            //    Console.WriteLine(animal.Name);
            //    animal.DoSound();

            //    if (animal is Dog doggy)
            //    {
            //        doggy.BarkOfTheDevil();
            //    }

            //    if (animal is Flamingo birdFlamingo)
            //    {
            //        birdFlamingo.FlyingSpeed();
            //        birdFlamingo.WingsOfStorm();
            //    }
            //}

            //wolfMan.Talk();
            //wolfMan.HowlOfThunder();
            //13. It should be in the bird class since its only the birds who need the new attribute
            //14. If all the animals need the new attribute it should go in the animal class
            #endregion

            #region Task 3.4 1-18

            Pelican pelican = new Pelican("Pelican",4,13.7);
            HedgeHog hedgeHog = new HedgeHog("Sonic", 17, 7);
            Horse horse = new Horse("Horsey", 24, 150);
            Swan swan = new Swan("Swany", 13, 35);
            Snake snake = new Snake("Snakey", 5, 6); 
            
            //var sum = wolfMan.Stats();
            //Console.WriteLine(sum);
            animals.Add(wolfMan);
            animals.Add(wolf);
            animals.Add(pelican);
            animals.Add(flamingo);
            animals.Add(swan);
            animals.Add(snake);
            animals.Add(hedgeHog);
            animals.Add(horse);
            animals.Add(dog);

            //Prints all the stats for all animals

            //foreach (var allAnimals in animals)
            //{
            //    var sumStats= allAnimals.Stats();
            //    Console.WriteLine(sumStats);
            //}

            //Calls the Do Sound method on the animals, if there is an animal that has implemented the Iperson interface we typecast it and print the Talk() method.

            //foreach (var animalsInList in animals)
            //{
            //    Console.Write($"{animalsInList.GetType().Name}: ");
            //    animalsInList.DoSound();

            //    if (animalsInList is IPerson person)
            //    {
            //        person.Talk();
            //    }

            //}


            //tried to add a horse to a list that accept object Dog 

            //List<Dog> dogs = new List<Dog>();
            //dogs.Add(Horse);

            //Prints just the dog stats from animal list

            foreach (var allAnimals in animals)
            {
                
                if (allAnimals is Dog animalDog)
                {
                   var sumStats =  animalDog.Stats();
                    Console.WriteLine(sumStats);
                   var specialAttack = animalDog.SpecialAttack();
                   Console.WriteLine(specialAttack);
                }
            }

            //9. A Horse cant be a dog, a horse inherits from Animal the class and not the dog class. If it had been inherited from the dog class i could have added it into the list.
            //10. Since the Animal is the base class, the list need to accept the Animal class as an argument to be able to store all the animals
            //13. Since all different animals inherits from the base class Animal and we put them in a list that accepts classes that inherits from Animal we can access the method in the base class called Stats. We override that method in the derived classes, so when we iterate through the list it checks if there are any overriden methods and if it is it calls that method. 
            //14. Since the method is not in the Animal class that we inherit from and we treat all our objects as Animal when we put them into the animals list. We therefore don't have access to the individual methods in for example the Dog class. We need to check if Dog is in the animal list and then typecast it and then we can get access to the methods in the dog class.
            #endregion

        }
    }
}