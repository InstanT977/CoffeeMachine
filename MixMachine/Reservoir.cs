using System.Collections.Generic;
using System.Linq;
using CoffeeMachine;

namespace MixMachine
{
    public class Reservoirs
    {
        private readonly List<Drink> _drinks;
        private Drink _currentDrink;
        private const int DefaultDrinkCount = 200;
        public Reservoirs()
        {
            InitializeDrinks();
            _drinks = new List<Drink>();
            _currentDrink = _drinks[0];
        }

        private void InitializeDrinks()
        {
            
            _drinks.Add(new Drink
            {
                Component = Components.Chocolate,
                DrinkCount = DefaultDrinkCount      
            });
            _drinks.Add(new Drink
            {
                Component = Components.Cinnamon,
                DrinkCount = DefaultDrinkCount
            });
            _drinks.Add(new Drink
            {
                Component = Components.Coffee,
                DrinkCount = DefaultDrinkCount
            });

            _drinks.Add(new Drink
            {
                Component = Components.Milk,
                DrinkCount = DefaultDrinkCount
            });
            _drinks.Add(new Drink
            {
                Component = Components.Sugar,
                DrinkCount = DefaultDrinkCount
            });
        }

        public Drink GetDrink(int count)
        {
            _currentDrink.DrinkCount -= count;
            var tempDrink = new Drink()
            {
                Component = _currentDrink.Component,
                DrinkCount = count
            };
            return tempDrink;
        }
        public void AddDrink()
        {
            _currentDrink.DrinkCount = DefaultDrinkCount;
        }
        public void ChangeDrink(Components component)
        {
            _currentDrink = _drinks.First(x => x.Component == component);
        }

    }

    public class Drink
    {
        public Components Component;
        public int DrinkCount;
    }
}
