using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashMachine
{
    public interface IAcceptor
    {
        void GetMoney(string money);
        int ReturnMoney();
        bool IsBusy();
        bool Failed();

    }
}
