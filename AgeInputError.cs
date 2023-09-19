namespace ExerciseThree;

public class AgeInputError : UserError
{
    public override string UeMessage()
    {
        return "You have entered an invalid age, it needs to be bigger than 0. This fired an error!";
    }
}