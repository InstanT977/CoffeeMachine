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
       public event EventHandler StateChanged;
       public event EventHandler AccountChanged;
       public event EventHandler DrinkCooked;
       public event EventHandler DrinkPriceChanged;
       private readonly IAcceptor Acceptor;
       private const string Password = "771066582";
       private const string ReFillReservoirs = "771066595";
       private const string ChangePrice = "771066599";
       private const string WidthrowCash = "7710665118";
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
           Acceptor = new Acceptor();
           _mixMachine = new MixAndPourMachine();
           State = StatesOfCoffeeMachine.SDone;
       }


       public Dictionary<string, int> GetPriceList()
       {
           return _mixMachine.GetPriceList();
       }

       public void Cancel(object sender, EventArgs e)
       {
           ChangeState(StatesOfCoffeeMachine.SDone);
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
           CheckState();
           CheckInput(tempInput);
        }

       private void CheckInput(string tempInput)
       {
           switch (tempInput)
           {
               case Password:
                   ChangeState(StatesOfCoffeeMachine.SAdmin);
                   _adminMode = true;
                   break;
               case ReFillReservoirs:
                   if (_adminMode)
                   {
                       var filled = _mixMachine.FillReservoirs();
                       if (filled)
                       {
                           ChangeState(StatesOfCoffeeMachine.SReservoirsFilled);
                       }
                   }
                   else
                   {
                       ChangeState(StatesOfCoffeeMachine.SIncorrectInput);
                   }
                   break;
               case ChangePrice:
                   if (_adminMode)
                   {
                       ChangeState(StatesOfCoffeeMachine.SDrinkCodeRequest);
                   }
                   break;
           }
       }

       private void CheckState()
       {
           switch (State)
           {
               case StatesOfCoffeeMachine.SDrinkCodeRequest:
                   if (_adminMode)
                   {
                       ChangeState(StatesOfCoffeeMachine.SPriceRequest);
                   }
                   else
                   {
                       CheckPriceAndStartPowur(Input);
                   }
                   break;
           }
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
           Acceptor.GetMoney(money);
           do
           {
               if (!Acceptor.IsBusy())
               {
                   if (!Acceptor.Failed())
                   {
                       Account += Int32.Parse(money);
                       return true;
                   }
                   else
                   {
                       Acceptor.ReturnMoney();
                       return false;
                   }
               }
           } while (Acceptor.IsBusy());
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
                case StatesOfCoffeeMachine.SAdmin:
                    return "Вы авторизрованы как администратор!";
                case StatesOfCoffeeMachine.SDone:
                    return "Готов к работе!";
                case StatesOfCoffeeMachine.SDrinkRequest:
                    return "Запрос напитка...";
                case StatesOfCoffeeMachine.SEmptyReservoir:
                    return "Отсутствуют ингридиенты!";
                case StatesOfCoffeeMachine.SLock:
                    return "Заблокировано.";
                case StatesOfCoffeeMachine.SMoneyRequest:
                    return "Внесите деньги!";
                case StatesOfCoffeeMachine.SPriceRequest:
                    return "Запрос цены напитка";
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
                    return "Получены все средства из депозита";
                case StatesOfCoffeeMachine.SDrinkCodeRequest:
                    return "Введите код напитка";
                case StatesOfCoffeeMachine.SDrinkNewPriceRequest:
                    return "Введите новую цену напитка";
                default:
                    return "";
            }
        }

        public void Update()
        {
            
        }
    }
}
