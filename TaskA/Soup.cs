using System;

public class Soup
{
    private Ingredient[] _ingredients;
    public Soup(Ingredient[] ingredients)
    {
        _ingredients = ingredients;
    }

    private bool CanEat()
    {
        foreach (var ingredient in _ingredients)
        {
            if (ingredient is Vegetable)
            {
                if ((ingredient as Vegetable).IsAllergicTo)
                    return false;
            }
            else if (ingredient is Meat)
            {
                if ((ingredient as Meat).IsTasty == false)
                    return false; 
            }
        }
        return true;
    }

    public bool WillEat => CanEat();
}