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
    private string name;
    private float maxHp;
    private float hp;
    private string status;

    public EventHandler<CurrentHPArgs> HPCheck;

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
        
        this.status = $"{name} is ready to go!" ;

        // Update status
        HPCheck += CheckStatus ;

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

        HPCheck ( this, new CurrentHPArgs(hp) ) ;
    }

    public float ApplyModifier( float baseValue, Modifier modifier )
    {        
        return modifier == Modifier.Weak ? baseValue / 2 : modifier == Modifier.Strong ?  1.5f * baseValue : baseValue;
    }

    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if(e.currentHp == maxHp)
        {
            status = $"{name} is in perfect health!" ;
        } else if ( maxHp / 2 <= e.currentHp )
        {
            status = $"{name} is doing well!" ;
        } else if ( maxHp / 4 <= e.currentHp )
        {
            status = $"{name} isn't doing too great..." ;
        } else if ( 0 < e.currentHp )
        {
            status = $"{name} needs help!" ;
        } else
        {
            status = $"{name} is knocked out!" ;
        }

        Console.WriteLine(status);
    }
}

class CurrentHPArgs : EventArgs
{
    public readonly float currentHp ;
    
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp ;
    }
}