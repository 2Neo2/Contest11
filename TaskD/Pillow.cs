using System;
using System.Xml.Serialization;

[Serializable]
[XmlRoot("Bed")]
public class Pillow
{
    public long id { get; set; }
    public string isRuined { get; set; }

    public Pillow(long id, bool isRuined)
    {
        this.id = id;
        if (isRuined)
            this.isRuined = "Yes";
        else
            this.isRuined = "No";
    }

    public Pillow()
    {
    }
}