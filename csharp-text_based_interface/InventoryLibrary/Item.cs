using System;


class Item : BaseClass
{
    public string name;
    public string description;
    public float price = 0.2f;
    public List<String> tags;

    public Item(string name="name", string description="description", float price=0.00, List<String> tags="tags")
    {
        this.name = name;
        this.description = description;
        this.price = Math.Round(price, 2) ;
        this.tags = tags;
    }
}