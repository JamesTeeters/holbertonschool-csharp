using System;

class Player
{
    private string name;
    private float maxHp;
    private float hp;

    public Player(string name= "Player", float maxHp= 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
            this.maxHp = 100f;
        }
        this.hp = this.maxHp;
    }

    public void PrintHealth()
    {
        Console.WriteLine($"{name} has {hp} / {maxHp} health");
    }

    public delegate void  CalculateHealth(float property);

    public void TakeDamage(float damage)
    {
        damage = (damage < 0) ? 0 : damage ;
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    public void HealDamage(float heal)
    {
        heal = (heal < 0) ? 0 : heal ;
        Console.WriteLine($"{name} heals {heal} HP!");
    }
}