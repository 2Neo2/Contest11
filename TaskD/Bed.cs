using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[Serializable]
public class Bed : Furniture
{
    [XmlElement("pillow")]
    public List<Pillow> pillows { get; set; }
    public Bed(long id, List<Pillow> pillows) : base(id)
    {
        this.pillows= pillows;
    }

    public Bed()
    {
    }
}