using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashMachine;
using CoffeeMachine;

namespace CashMachine
{
    public class Acceptor :IAcceptor
    {
         public bool _isUsed;
         public bool _fail;
         public int _account;
         public List<Banknote> _banknoteList;
         public BanknoteChecker _banknoteChecker;

        public void Update()
        {
            
        }
        public void GetMoney()
        {
        }
        public int ReturnMoney()
        {
            return 0;
        }
        public bool IsBusy()
        {
            return false;
        }
        public bool Failed()
        {
            return false;
        }
    }
}
