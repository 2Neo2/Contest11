using System;

public class Rational
{
    int numerator;
    int denomenator;
    
    public static Rational Parse(string input)
    {
        Rational rational = new Rational();
        var numbers = input.Split('/');
        if (numbers.Length == 1)
        {
            rational.numerator = int.Parse(numbers[0]);
            rational.denomenator = 1;
        }
        else
        {
            rational.numerator = int.Parse(numbers[0]);
            rational.denomenator = int.Parse(numbers[1]);
        }
        return rational;
    }

    public static Rational operator +(Rational a, Rational b)
    {
        Rational rational = new Rational();

        rational.numerator = a.numerator * b.denomenator + a.denomenator * b.numerator;
        rational.denomenator = a.denomenator * b.denomenator;

        if (rational.numerator == rational.denomenator)
        {
            if (rational.numerator > 0 && rational.denomenator > 0)
            {
                rational.denomenator = 1;
                rational.numerator = 1;
            }
            else
            {
                rational.denomenator = 1;
                rational.numerator = -1;
            }
        }
        else if (rational.numerator == 0)
            rational.denomenator = 1;
        else
        {
            var nod = FindNod(rational.numerator, rational.denomenator);
            rational.numerator /= nod;
            rational.denomenator /= nod;
        }
        
        if (rational.denomenator < 0)
        {
            rational.denomenator *= -1;
            rational.numerator *= -1;
        }

        return rational;
    }
    
    public static Rational operator -(Rational a, Rational b)
    {
        Rational rational = new Rational();
        rational.numerator = a.numerator * b.denomenator - a.denomenator * b.numerator;
        rational.denomenator = a.denomenator * b.denomenator;
        
        if (rational.numerator == rational.denomenator)
        {
            if (rational.numerator > 0 && rational.denomenator > 0)
            {
                rational.denomenator = 1;
                rational.numerator = 1;
            }
            else
            {
                rational.denomenator = 1;
                rational.numerator = -1;
            }
        }
        else if (rational.numerator == 0)
            rational.denomenator = 1;
        else
        {
            var nod = FindNod(rational.numerator, rational.denomenator);
            rational.numerator /= nod;
            rational.denomenator /= nod;
        }

        if (rational.denomenator < 0)
        {
            rational.denomenator *= -1;
            rational.numerator *= -1;
        }

        return rational;
    }
    
    public static Rational operator *(Rational a, Rational b)
    {
        Rational rational = new Rational();
        rational.numerator = a.numerator * b.numerator;
        rational.denomenator = a.denomenator * b.denomenator;
        
        if (rational.numerator == rational.denomenator)
        {
            if (rational.numerator > 0 && rational.denomenator > 0)
            {
                rational.denomenator = 1;
                rational.numerator = 1;
            }
            else
            {
                rational.denomenator = 1;
                rational.numerator = -1;
            }
        }
        else if (rational.numerator == 0)
            rational.denomenator = 1;
        else
        {
            var nod = FindNod(rational.numerator, rational.denomenator);
            rational.numerator /= nod;
            rational.denomenator /= nod;
        }
        
        if (rational.denomenator < 0)
        {
            rational.denomenator *= -1;
            rational.numerator *= -1;
        }


        return rational;
    }
    
    public static Rational operator /(Rational a, Rational b)
    {
        Rational rational = new Rational();
        
        rational.numerator = a.numerator * b.denomenator;
        rational.denomenator = a.denomenator * b.numerator;
        
        if (rational.numerator == rational.denomenator)
        {
            if (rational.numerator > 0 && rational.denomenator > 0)
            {
                rational.denomenator = 1;
                rational.numerator = 1;
            }
            else
            {
                rational.denomenator = 1;
                rational.numerator = -1;
            }
        }
        else if (rational.numerator == 0)
            rational.denomenator = 1;
        else
        {
            var nod = FindNod(rational.numerator, rational.denomenator);
            rational.numerator /= nod;
            rational.denomenator /= nod;
        }
        
        if (rational.denomenator < 0)
        {
            rational.denomenator *= -1;
            rational.numerator *= -1;
        }

        return rational;
    }

    private static int FindNod(int a, int b)
    {
        while (b != 0)
        {
            var t = b;
            b = a % b;
            a = t;
        }
        return a;
    }

    public override string ToString()
    {
        if (denomenator == 1)
            return numerator.ToString();
        return numerator + "/" + denomenator;
    }
}