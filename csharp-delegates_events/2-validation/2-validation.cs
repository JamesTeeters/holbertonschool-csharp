using System;

public delegate void  CalculateHealth(float property);

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

    public void TakeDamage(float damage)
    {
        if (damage < 0)
        {
                damage = 0 ;
        }
        else
        {
            ValidateHP(hp -= damage);
        }
        Console.WriteLine($"{name} takes {damage} damage!");
    }

    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0 ;
        }
        else
        {
            ValidateHP(hp += heal);
        }
        Console.WriteLine($"{name} heals {heal} HP!");
    }

    public void ValidateHP(float newHp)
    {
        hp = newHp < 0 ? 0 : newHp > maxHp ? maxHp : newHp ;
    }

}