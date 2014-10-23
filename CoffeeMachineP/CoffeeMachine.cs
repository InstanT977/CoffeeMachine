using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Timers;
using CashMachine;
using CoffeeMachine;
using MixMachine;

namespace Machine
{
   public class CoffeeMachine:ICoffeeMach
   {
       public event EventHandler PriceChanged;
       public event EventHandler StateChanged;
       public event EventHandler AccountChanged;
       public event EventHandler DrinkCooked;
       public event EventHandler WaterHeatingStateChanged;
       private Timer _tChecker;

  
       private readonly IAcceptor _acceptor;
       private const string Password = "771066582";
       private const string ReFillReservoirs = "771066595";
       private const string ChangePrice = "771066599";
       private const string WidthrowCash = "7710665118";
       private const int StandartTimeToHeat = 60000;
       private const int InProcessTimeToHeat = 10000;
       private const string GetUserMoney = "$";
       private bool _adminMode;
       private int _account;
       public int Account {
           get
           {
               return _account;
           }
           set
           {
               _account = value;
              AccountChanged(_account, new EventArgs());  
           } }

       public StatesOfCoffeeMachine State;
        private readonly IMixMachine _mixMachine;
        public String Input;

       public CoffeeMachine()
       {
           _acceptor = new Acceptor();
           _mixMachine = new MixAndPourMachine();
           State = StatesOfCoffeeMachine.SReady;
           InitializeWaterHeating();
       }

       private void InitializeWaterHeating()
       {
           _tChecker = new Timer();
           _tChecker.Elapsed += CheckWaterTemperature;
           _tChecker.Interval = StandartTimeToHeat; // 60 seconds
           _tChecker.Start();
       } 

       private void CheckWaterTemperature(object sender, EventArgs e)
       {
           var heating = _mixMachine.CheckWaterTemperature();
           _tChecker.Interval = InProcessTimeToHeat;
           WaterHeatingStateChanged(heating, new EventArgs());
           if (!heating)
           {
               _tChecker.Interval = StandartTimeToHeat;
           }

       }

       public Dictionary<string, int> GetPriceList()
       {
           return _mixMachine.GetPriceList();
       }

       public void SetDefaultState(object sender, EventArgs e)
       {
           ChangeState(StatesOfCoffeeMachine.SReady);
           _adminMode = false;
           Input = String.Empty;
       }

       public void CheckInputData(object sender, EventArgs e)
       {
           var tempInput = sender == null ? "" : sender.ToString();

           if (!InputCodeIsCorrect(tempInput))
           {
               return;
           }



           if (!_adminMode)
           {
               switch (tempInput)
               {
                   case Password:
                       ChangeState(StatesOfCoffeeMachine.SAdmin);
                       _adminMode = true;
                       break;
                   case GetUserMoney:
                       WidthrowUserCash();
                       break;
                   default:
                       CheckPriceAndStartPowur(tempInput);
                       break;

               }
           }
           else
           {
               switch (tempInput)
               {
                   case ReFillReservoirs:
                       if (_adminMode)
                       {
                           var filled = _mixMachine.FillReservoirs();
                           if (filled)
                           {
                               ChangeState(StatesOfCoffeeMachine.SReservoirsFilled);
                               ChangeState(StatesOfCoffeeMachine.SReady);
                           }
                       }
                       else
                       {
                           ChangeState(StatesOfCoffeeMachine.SIncorrectInput);
                       }
                       break;
                   case ChangePrice:
                           ChangeState(StatesOfCoffeeMachine.SDrinkCodeRequest);
                       break;
                   case WidthrowCash:
                       ChangeState(StatesOfCoffeeMachine.SCashCleared);
                       SetDefaultState(null,null);
                       break;
                   default:
                       CheckState(tempInput);
                       break;

               }
           }

        }

       private void WidthrowUserCash()
       {
           if (Account != 0)
           {
               Account = 0;
               ChangeState(StatesOfCoffeeMachine.SAccountCleared);
           }
           SetDefaultState(null, new EventArgs());
       }

       private void CheckState(string input)
       {
           switch (State)
           {
               case StatesOfCoffeeMachine.SDrinkCodeRequest:
                   if (_adminMode)
                   {
                       Input = input;
                       ChangeState(StatesOfCoffeeMachine.SPriceRequest);
                   }
                   else
                   {
                       CheckPriceAndStartPowur(input);
                   }
                   break;
                case StatesOfCoffeeMachine.SPriceRequest:
                   if (_adminMode)
                   {
                       int price;
                       if(Int32.TryParse(input,out price))
                       {
                           var result = _mixMachine.SetPrice(Input, price);
                           if (result)
                           {
                               PriceChanged(this,new EventArgs());
                               ChangeState(StatesOfCoffeeMachine.SDone);
                               SetDefaultState(this, new EventArgs());
                           }
                           else
                           {
                               InputErrorState();
                           }
                       }
                       else
                       {
                           ChangeState(StatesOfCoffeeMachine.SIncorrectInput);
                       }
                   }
                   break;

           }
       }

       private void InputErrorState()
       {
           ChangeState(StatesOfCoffeeMachine.SIncorrectInput);
       }

       private bool InputCodeIsCorrect(string code)
       {
           if (string.IsNullOrEmpty(code) || code.Contains("*"))
           {
               ChangeState(StatesOfCoffeeMachine.SIncorrectInput);
               return false;
           }
           return true;
       }

       public bool CheckMoney(string money)
       {
           _acceptor.GetMoney(money);
           do
           {
               if (!_acceptor.IsBusy())
               {
                   if (!_acceptor.Failed())
                   {
                       Account += Int32.Parse(money);
                       return true;
                   }
                   else
                   {
                       _acceptor.ReturnMoney();
                       return false;
                   }
               }
           } while (_acceptor.IsBusy());
           return true;
       }

       private void CheckPriceAndStartPowur(string input)
       {
           ChangeState(StatesOfCoffeeMachine.SPriceRequest);
           var price = _mixMachine.GetPrice(input);
           if (price == null)
           {
               ChangeState(StatesOfCoffeeMachine.SIncorrectInput);
           }
           else
           {
               ChangeState(StatesOfCoffeeMachine.SMoneyRequest);
               if (Account >= price)
               {
                   var powurResult = _mixMachine.MixAndPoWur(input);
                   if (powurResult)
                   {
                       Account -= (int)price;
                       _mixMachine.SendDrink();
                       DrinkCooked(null,new EventArgs());
                       ChangeState(StatesOfCoffeeMachine.SDone);
                       SetDefaultState(this,new EventArgs());
                   }
                   else
                   {
                       ChangeState(StatesOfCoffeeMachine.SEmptyReservoir);
                   }
               }
               else
               {
                   ChangeState(StatesOfCoffeeMachine.SNotEnoughMoney);
               }
           }

       }

       private void ChangeState(StatesOfCoffeeMachine newState)
       {
           State = newState;
           StateChanged(null, new EventArgs());
       }

        public string GetState()
        {
            switch (State)
            {
                case StatesOfCoffeeMachine.SReady:
                    return "Готов к работе!";
                case StatesOfCoffeeMachine.SAdmin:
                    return "Вы авторизрованы!";
                case StatesOfCoffeeMachine.SDone:
                    return "Готово!";
                case StatesOfCoffeeMachine.SDrinkRequest:
                    return "Запрос напитка...";
                case StatesOfCoffeeMachine.SEmptyReservoir:
                    return "Отсутствуют ингридиенты!";
                case StatesOfCoffeeMachine.SLock:
                    return "Заблокировано.";
                case StatesOfCoffeeMachine.SMoneyRequest:
                    return "Запрос средств...";
                case StatesOfCoffeeMachine.SPriceRequest:
                    return "Запрос цены напитка";
                case StatesOfCoffeeMachine.SPriceChanged:
                    return "Цена успешно изменена!";
                case StatesOfCoffeeMachine.SUnlock:
                    return "Разблокирование...";
                case StatesOfCoffeeMachine.SWaterHeating:
                    return "Нагрев воды...";
                case StatesOfCoffeeMachine.SIncorrectInput:
                    return "Некорректный ввод!";
                case StatesOfCoffeeMachine.SNotEnoughMoney:
                    return "Недостаточно средств!";
                case StatesOfCoffeeMachine.SReservoirsFilled:
                    return "Резервуары пополнены.";
                case StatesOfCoffeeMachine.SCashCleared:
                    return "Получены средства автомата";
                case StatesOfCoffeeMachine.SAccountCleared:
                    return "Выдача сдачи";
                case StatesOfCoffeeMachine.SDrinkCodeRequest:
                    return "Введите код напитка";
                case StatesOfCoffeeMachine.SDrinkNewPriceRequest:
                    return "Введите новую цену напитка";
                default:
                    return "";
            }
        }

    }
}
