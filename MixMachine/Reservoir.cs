﻿using System.Collections.Generic;
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
            _drinks = new List<Drink>();
            InitializeDrinks();
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
            if (_currentDrink.DrinkCount - count < 0)
            {
                return null;
            }
            _currentDrink.DrinkCount -= count;
            var tempDrink = new Drink()
            {
                Component = _currentDrink.Component,
                DrinkCount = count
            };
            return tempDrink;
        }

        public bool CheckDrinkExists(int count)
        {
            return _currentDrink.DrinkCount >= count;
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
