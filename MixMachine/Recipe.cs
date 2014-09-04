using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Recipe
    {
        public string Description;
        public DrinkNames Name;
        public List<Ingridient> Ingridients;
        public int Price;


        public void ChangePrice(int newPrice)
        {
            Price = newPrice;
        }
    }

    public enum DrinkNames
    {
        BlackCoffee,
        Cappuccino,
        StrongCoffee,
        CoffeeWithCinnamon,
        CoffeeWithMilk, 
        TurkishCoffee,
        CoffeeWithoutSugar,
        VanillaCoffee
    }
}
