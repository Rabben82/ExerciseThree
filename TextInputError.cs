namespace ExerciseThree;

public class TextInputError : UserError
{
    public override string UeMessage()
    {
        return "You tried to use a text input in a numeric only field. This fired an error!";
    }
}