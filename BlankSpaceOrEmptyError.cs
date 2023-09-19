namespace ExerciseThree;

public class BlankSpaceOrEmptyError : UserError
{
    public override string UeMessage()
    {
        return "You have entered a black space or empty value. This fired an error!";
    }
}