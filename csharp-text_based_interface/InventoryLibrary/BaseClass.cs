using System;

class BaseClass
{
    string id {get; set;};
    DateTime date_created {get; set;};
    DateTime date_updated {get; set;};

    public BaseClass()
    {
        id = Guid.NewGuid().ToString();
        date_created = DateTime.Now;
        date_updated = date_created;
    }

    public string ToJSON()
    {
        var options = new JsonSerializerOptions { WriteIndented = true,};
        return JsonSerializer.Serialize<Object>(this, options);
    }

    public override string ToString() => $"[{this.GetType().Name}] ({this.id}) \n{ToJSON()}";
}