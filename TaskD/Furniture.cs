using System;
using System.Xml.Serialization;
[Serializable]
[XmlInclude(typeof(Bed))]
[XmlInclude(typeof(Lamp))]
public abstract class Furniture
{
    public long id { get; set; }
    protected Furniture(long id)
    {
        this.id = id;
    }

    public Furniture()
    {
    }
}