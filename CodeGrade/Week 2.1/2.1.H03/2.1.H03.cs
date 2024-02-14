public class Player
{
    string Name;
    int Power;
    int HealthPoints;
    public Player(string name, int power)
    {
        this.Name = name;
        this.Power = power;
        this.HealthPoints = 100;
    }


    public bool IsAlive()
    {
        return this.HealthPoints > 0;
    }


    public void TakeDamage(int damageTaken)
    {
        this.HealthPoints -= damageTaken;
        if (!IsAlive()) this.HealthPoints = 0;
    }
}