using System;
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
       public IAcceptor Acceptor;
       private const string Password = "771066582";
       public int _account;
       public StatesOfCoffeeMachine State;
        private IMixMachine _mixMachine;
        public String _input;

       public CoffeeMachine()
       {
           Acceptor = new Acceptor();
           _mixMachine = new MixAndPourMachine();
           State = StatesOfCoffeeMachine.SDrinkRequest;
       }




       public void CheckInputData(object sender, EventArgs e)
        {
            var input = sender.ToString();
           _input = input.Replace("*", "");
           if (_input == Password)
           {
               State = StatesOfCoffeeMachine.SAdmin;
           }
           CheckPrice(_input);
  
        }

       public bool CheckMoney(string money)
       {
           Acceptor.GetMoney(money);
           if (!Acceptor.IsBusy())
           {
               if (!Acceptor.Failed())
               {
                   _account += Int32.Parse(money);
                   return true;
               }
               else
               {
                   Acceptor.ReturnMoney();
                   return false;
               }
           }
       }
       private void CheckPrice(string input)
       {
           State = StatesOfCoffeeMachine.SPriceRequest;
           var price = _mixMachine.GetPrice(input);
           if (price == null)
           {
               State = StatesOfCoffeeMachine.SIncorrectInput;
           }
           else
           {
               State = StatesOfCoffeeMachine.SMoneyRequest;
               if (_account >= price)
               {
                   _mixMachine.MixAndPoWur();
               }
               else
               {
                   State = StatesOfCoffeeMachine.SNotEnoughMoney;
               }
           }

       }

       private void CheckString(string input)
       {
            string pattern = @"не";
            string text = "Не может быть совсем не может быть"; 
            RegexOptions option=RegexOptions.IgnoreCase; 
            Regex newReg = new Regex(pattern,option);  
            MatchCollection matches = newReg.Matches(text);
            foreach(Match mat in matches)
            {
                    Console.WriteLine("Значение найденного обьекта {0}",mat.Value);
            }

       }
        public string InitState()
        {
            switch (State)
            {
                case StatesOfCoffeeMachine.SAdmin:
                    return "Вы авторизрованы как администратор!";
                case StatesOfCoffeeMachine.SDone:
                    return "Успешно выполнено!";
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
                    return "Готов к работе!";
                case StatesOfCoffeeMachine.SWaterHeating:
                    return "Нагрев воды...";
                default:
                    return "";
            }
        }

        public void Update()
        {
            
        }
    }
}
