namespace ExerciseThree;

public class NumericInputError : UserError
{
    public override string UeMessage()
    {
        return "You tried to use a numeric input in a text only field. This fired an error!";
    }
}