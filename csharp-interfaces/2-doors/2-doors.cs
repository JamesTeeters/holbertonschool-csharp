using System;

public abstract class Base
{
    public string name = null;

    public override string ToString() => $"{this.name} is a {this.GetType()}";
        
}
public interface IInteractive
{
    void Interact();
}
public interface IBreakable
{
    int durability {get; set;}
    void Break();
}
public interface ICollectable
{
    bool isCollected {get; set;}
    void Collect();
}

public class Door : Base, IInteractive
{
    public Door(string name = "Door"){
        this.name = name;
    }
    public void Interact(){
        Console.WriteLine($"You try to open the {this.name}. It's locked.");
    }
}