namespace ExerciseThree.Animals;

public class Wolf : Animal
{
    public int AttackHowlOfThunderDamage { get; set; }
    public Wolf(string name, int age, double weight, int attackDamage) : base(name, age, weight)
    {
        AttackHowlOfThunderDamage = attackDamage;
    }
    public void HowlOfThunder()
    {
        Console.WriteLine("Howls of thunder!");
    }
    public override void DoSound()
    {
        Console.WriteLine("Howling");
    }

    public override string Stats()
    {
        return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}\nAttack Damage: {AttackHowlOfThunderDamage}";
    }
}