using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Timers;
using CoffeeMachine;

namespace MixMachine
{
   public class MixAndPourMachine :IMixMachine
   {
        private WaterContainer _waterContainer;
        private Reservoirs _reservoirs;
        private List<Recipe> _recipes;
        private CoupContainer _coupContainer;


       public MixAndPourMachine()
       {
           InitializeRecepies();
           InitializeComponents();
       }

       public bool FillReservoirs()
       {
           foreach (var recipe in _recipes)
           {
               foreach (var currentComponent in recipe.Ingridients.Select(ingridient => ingridient.Drink))
               {
                   _reservoirs.ChangeDrink(currentComponent);
                   _reservoirs.AddDrink();
               }
           }
           return true;
       }

       public bool DrinkExists(string code)
       {
           int intCode = Int32.Parse(code);
           var drink = _recipes.FirstOrDefault(x => x.Name == (DrinkNames)intCode);
           if (drink != null)
           {
               return true;
           }
           return false;
       }

       public bool SetPrice(string code,int newPrice)
       {
           int intCode = Int32.Parse(code);
           var drink = _recipes.FirstOrDefault(x => x.Name == (DrinkNames)intCode);
           if (drink != null)
           {
               drink.Price = newPrice;
               return true;
           }
           return false;

       }

       private void InitializeComponents()
       {
           _coupContainer = new CoupContainer();
           _reservoirs = new Reservoirs();
           _waterContainer = new WaterContainer();
       }

       public Dictionary<string,int> GetPriceList()
       {
           return _recipes.ToDictionary(recipe => recipe.Description, recipe => recipe.Price);
       }

       public bool CheckWaterTemperature()
       {      
           _waterContainer.CheckTemperature();
           return _waterContainer.IsHeating; 
       }

       private void InitializeRecepies()
       {
           _recipes = new List<Recipe>();
           _recipes.Add(new Recipe
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
               ,
               Price = 30
           });
           _recipes.Add( new Recipe
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
               },
               Price = 50
           });
           _recipes.Add(new Recipe
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
               },
               Price = 40

           });

           _recipes.Add(new Recipe
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
               },
               Price = 45
           });
           _recipes.Add(new Recipe
           {
               Description = "Крепкий кофе",
               Name = DrinkNames.StrongCoffee,
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
               },
               Price = 35
           });
           _recipes.Add(new Recipe
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
               },
               Price = 60
           });

           _recipes.Add(new Recipe
           {
               Description = "Кофе без сахара",
               Name = DrinkNames.CoffeeWithoutSugar,
               Ingridients = new List<Ingridient>
               {
                   new Ingridient
                   {
                       Drink = Components.Coffee,
                       Count = 2
                   }
               },
               Price = 20
           });
       }

       public bool MixAndPoWur(string code)
       {
           var exists = CheckIngridientsExists(code);
           if(exists)
           { 
            int intCode = Int32.Parse(code);

           var drink = _recipes.FirstOrDefault(x => x.Name == (DrinkNames) intCode);

               foreach (var ingridient in drink.Ingridients)
               {
                   var currentComponent = ingridient.Drink;
                   _reservoirs.ChangeDrink(currentComponent);
                   _reservoirs.GetDrink(ingridient.Count);
               }
               _waterContainer.Get(CoupContainer.Volume);
               _coupContainer.GetCoup();
           }
           return exists;
       }

       private bool CheckIngridientsExists(string code)
       {
           bool result = !_coupContainer.IsEmpty
                    && _waterContainer.CheckWaterContains(CoupContainer.Volume);
               

           int intCode = Int32.Parse(code);
           var drink = _recipes.FirstOrDefault(x => x.Name == (DrinkNames) intCode);

           if (drink != null)
           {
               foreach (var ingr in drink.Ingridients)
               {
                   _reservoirs.ChangeDrink(ingr.Drink);
                   result = result && _reservoirs.CheckDrinkExists(ingr.Count);
               }

               
           }
           else
           {
               result = false;
           }

           return result;
       }



       public int? GetPrice(string code)
       {
           int intCode;
           if (Int32.TryParse(code, out intCode))
           {
               var drink = _recipes.FirstOrDefault(x => x.Name == (DrinkNames) intCode);

               if (drink != null)
               {
                   return drink.Price;
               }
           }

           return null;
       }

        public void SendDrink()
        {
            
        }

    }
}
