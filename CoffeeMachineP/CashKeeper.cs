using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CashKeeper
    {
        public bool _closed;
        public int _account;
        public void Open()
        {
            _closed = false;
        }
        public void GetMoney(int money)
        {
            _account += money;
        }
        public bool IsClosed()
        {
            return _closed;
        }
        public int ReturnMoney()
        {
            return 0;
        }
        public void Close()
        {
            _closed = true;
        }

    }
}
