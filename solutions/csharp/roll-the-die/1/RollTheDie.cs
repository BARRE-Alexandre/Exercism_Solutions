public class Player
{
    public int RollDie()
    {
        Random rand = new Random();
        int roll = rand.Next(1,19);
        return roll;
    }

    public double GenerateSpellStrength()
    {
        Random rand = new Random();
        double strength = rand.NextDouble();
        return strength;
    }
}
