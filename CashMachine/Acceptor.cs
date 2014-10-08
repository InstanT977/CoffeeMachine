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

        public void GetMoney(string money)
        {
            _isUsed = true;
            var currentBanknote = new Banknote(money);
            _fail = !_banknoteChecker.Check(currentBanknote);
            if (!_fail)
            {
                _banknoteList.Add(currentBanknote);
                _account += currentBanknote._value;
            }
            _isUsed = false;

        }

        public void ReturnMoney()
        {
            _banknoteList.Clear();
            _account = 0;
        }
        public bool IsBusy()
        {
            return _isUsed;
        }
        public bool Failed()
        {
            return _fail;
        }
    }
}
