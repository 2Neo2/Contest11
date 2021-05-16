using System;
using System.Collections.Generic;

[Serializable]
public class Lamp : Furniture
{
    public double lifeTime { get; set; }

    public Lamp(long id, TimeSpan lifeTime) : base(id)
    {
        this.lifeTime = lifeTime.TotalSeconds;
    }

    public Lamp()
    {
    }
}