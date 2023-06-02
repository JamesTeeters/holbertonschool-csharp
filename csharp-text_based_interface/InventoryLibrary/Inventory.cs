using System;

class Inventory : BaseClass
{
    /// <summary> User id property </summary>
    public string user_id {get; set;};
    /// <summary> Item id property </summary>
    public string item_id {get; set;};
    /// <summary> Quantity property </summary>
    public int quantity;

    public Inventory(string user_id="User id", string item_id="Item id", int quantity=1)
    {
        this.user_id = user_id;
        this.item_id = item_id;
        this.quantity = quantity < 0 ? 0 : quantity;
    }
}