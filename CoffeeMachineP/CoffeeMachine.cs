using System;
using System.ComponentModel;
using CashMachine;
using CoffeeMachine;
using MixMachine;

namespace Machine
{
   public class CoffeeMachine:ICoffeeMach
    {
       public IAcceptor _acceptor;
       public String _password;
       public int _account;
       public StatesOfCoffeeMachine _state;
        public CashKeeper _coinKeeper;
        public IMixMachine _mixMachine;
        public String _input;

       public enum States
       {
           SDrinkRequest,
           SPriceRequest,
           SDone,
           SMoneyRequest,
           SEmptyReservoir,
           SUnlock,
           SLock,
           SWaterHeating
       };

       public void CheckInputData()
        {
            
        }
        public void InitState()
        {
            
        }

        public void Update()
        {
            
        }
    }
}
