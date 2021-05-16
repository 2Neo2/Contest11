using System;
using System.Runtime.Serialization;
[Serializable]
public class Penalty
{
    private int car_number;
    
    private int cost;

    public Penalty(int carNumber, int cost)
    {
        this.car_number = carNumber;
        this.cost = cost;
    }
}