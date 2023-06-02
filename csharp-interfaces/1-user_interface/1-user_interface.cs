using System;

public abstract class Base
{
    private string name {get; set;}

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

public class TestObject : Base, IInteractive, IBreakable, ICollectable
{
    public int durability {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    public bool isCollected {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }
    public string name {
        get => throw new NotImplementedException();
        set => throw new NotImplementedException();
    }

    public void Interact() {throw new NotImplementedException();}
    public void Break() {throw new NotImplementedException();}
    public void Collect() {throw new NotImplementedException();}
}