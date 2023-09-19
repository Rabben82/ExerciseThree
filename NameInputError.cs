namespace ExerciseThree;

public class NameInputError : UserError
{
    public override string UeMessage()
    {
        return "You have entered an invalid name, it cant be less than 2 characters. This fired an error!";
    }
}