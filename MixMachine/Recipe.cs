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
        BlackCoffee = 0,
        Cappuccino = 1,
        StrongCoffee = 2,
        CoffeeWithCinnamon = 3,
        CoffeeWithMilk = 4, 
        TurkishCoffee = 5,
        CoffeeWithoutSugar = 6,
        VanillaCoffee = 7
    }
}
