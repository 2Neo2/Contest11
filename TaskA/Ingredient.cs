using System;
using System.ComponentModel;
using System.Runtime.Serialization;

[KnownType(typeof(Meat))]
[KnownType(typeof(Vegetable))]
[DataContract]
public class Ingredient : IComparable
{
    [DataMember]
    public string Name { get; set; }
    
    [DataMember]
    protected int TimeToCook { get; set; }

    public int CompareTo(object obj)
    {
        var item = obj as Ingredient;

        if (item.TimeToCook < TimeToCook)
            return -1;
        else if (item.TimeToCook > TimeToCook)
            return 1;
        else
            return 0;
    }

    public Ingredient(string name, int timeToCook)
    {
        Name = name;
        TimeToCook = timeToCook;
    }

    public override string ToString()
    {
        return Name;
    }
}