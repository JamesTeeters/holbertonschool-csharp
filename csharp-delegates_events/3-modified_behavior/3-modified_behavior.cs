using System;

public delegate void  CalculateHealth(float property);

public enum Modifier
{
    Weak,
    Base,
    Strong
} ;

public delegate float CalculateModifier(float baseValue, Modifier modifier) ;

class Player
{
    // access the Player’s properties directly from the main file.
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
        Console.WriteLine($"{name} takes {damage} damage!");
        ValidateHP(hp - damage);
    }

    public void HealDamage(float heal)
    {
        if (heal < 0)
        {
            heal = 0 ;
        }
        Console.WriteLine($"{name} heals {heal} HP!");
        ValidateHP(hp + heal);
    }

    public void ValidateHP(float newHp)
    {
        this.hp = newHp < 0 ? 0f : newHp > this.maxHp ? maxHp : newHp ;
    }

    public float ApplyModifier( float baseValue, Modifier modifier )
    {        
        return modifier == Modifier.Weak ? baseValue / 2 : modifier == Modifier.Strong ?  1.5f * baseValue : baseValue;
    }

}