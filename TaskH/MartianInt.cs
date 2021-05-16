using System;
using System.Runtime.CompilerServices;

public class MartianInt
{
    private int value;
    private static int count = 0;
    
    public MartianInt(int value)
    {
        this.value = value;
    }

    public static explicit operator int(MartianInt martianInt)
    {
        int value = martianInt.value + count++;
        
        if (value < 0)
            throw new ArgumentException("Value is negative");
        else
            return value;
    }

    public static implicit operator MartianInt(int value)
    {
        var number = value - count++;
        
        if (number <= 0)
            throw new ArgumentException("Value is negative");
        else
            return new MartianInt(number);
    }
    
    public int Value => value;
}