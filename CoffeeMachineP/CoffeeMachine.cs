using System;
using System.ComponentModel;
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
        public CashKeeper _coinKeeper;
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
        }
        public void InitState()
        {
            
        }

        public void Update()
        {
            
        }
    }
}
