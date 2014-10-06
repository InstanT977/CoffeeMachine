using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using CoffeeMachine;

namespace MixMachine
{
   public class MixAndPourMachine :IMixMachine
   {
        public event EventHandler DrinkCooked;
        private WaterContainer _waterContainer;
        private Timer _timer;
        public Reservoirs Reservoirs;
        public bool IsWork;
        public List<Recipe> Recipes;

        public CoupContainer CoupContainer;


       public MixAndPourMachine()
       {
           InitializeWaterHeating();
           InitializeRecepies();
       }

       private void InitializeWaterHeating()
       {
           const int standartTimeToHeat = 60000;
           _timer = new Timer();
            _waterContainer = new WaterContainer();


           _timer.Elapsed += CheckWaterTemperature;
           _timer.Interval = standartTimeToHeat; // 10 seconds
           _timer.Start();
       }

       private void CheckWaterTemperature(object sender, ElapsedEventArgs e)
       {
           const int inProcessTimeToHeat = 10000;
           _waterContainer.CheckTemperature();
           if (_waterContainer.IsHeating)
           {
               _timer.Interval = inProcessTimeToHeat; 
               //maybe not need;
               _timer.Stop();
               _timer.Start();
           }
       }

       private void InitializeRecepies()
       {
           Recipes = new List<Recipe>();
           Recipes.Add(new Recipe
           {
               Description = "Черный кофе",
               Name = DrinkNames.BlackCoffee,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 1
                   },
                   new Ingridient
                   {
                       Drink = Components.Sugar,
                       Count = 2
                   }
               }
           });
           Recipes.Add( new Recipe
           {
               Description = "Капучино",
               Name = DrinkNames.Cappuccino,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Sugar,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Milk,
                       Count = 1
                   },
                   new Ingridient
                   {
                       Drink = Components.Chocolate,
                       Count = 1
                   }
               }
           });
           Recipes.Add(new Recipe
           {
               Description = "Кофе с молоком",
               Name = DrinkNames.CoffeeWithMilk,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Sugar,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Milk,
                       Count = 1
                   },
               }
           });

           Recipes.Add(new Recipe
           {
               Description = "Кофе с корицей",
               Name = DrinkNames.CoffeeWithCinnamon,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 1
                   },
                   new Ingridient
                   {
                       Drink = Components.Sugar,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Cinnamon,
                       Count = 1
                   },
               }
           });
           Recipes.Add(new Recipe
           {
               Description = "Кофе с корицей",
               Name = DrinkNames.CoffeeWithCinnamon,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 1
                   },
                   new Ingridient
                   {
                       Drink = Components.Sugar,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Cinnamon,
                       Count = 1
                   },
               }
           });
           Recipes.Add(new Recipe
           {
               Description = "Крепкий кофе",
               Name = DrinkNames.CoffeeWithCinnamon,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 1
                   },
                   new Ingridient
                   {
                       Drink = Components.Sugar,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Cinnamon,
                       Count = 1
                   },
               }
           });
           Recipes.Add(new Recipe
           {
               Description = "Турецкий кофе",
               Name = DrinkNames.TurkishCoffee,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Sugar,
                       Count = 0
                   },
                   new Ingridient
                   {
                       Drink = Components.Milk,
                       Count = 2
                   }
               }
           });
           Recipes.Add(new Recipe
           {
               Description = "Турецкий кофе",
               Name = DrinkNames.TurkishCoffee,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 2
                   },
                   new Ingridient
                   {
                       Drink = Components.Milk,
                       Count = 2
                   }
               }
           });

           Recipes.Add(new Recipe
           {
               Description = "Кофе без сахара",
               Name = DrinkNames.TurkishCoffee,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 2
                   }
               }
           });
       }

       public bool MixAndPoWur()
       {
           throw new NotImplementedException();
       }

       public int? GetPrice(string code)
       {
           int intCode = Int32.Parse(code);
           var drink = Recipes.FirstOrDefault(x => x.Name == (DrinkNames) intCode);

           if (drink != null)
           {
               return drink.Price;
           }
           return null;
       }

       public bool MixAndPour(string code)
       {
           return false;
       }
        public void SendDrink()
        {
            
        }

    }
}
