using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
   public interface ICoffeeMach
    {
        event EventHandler StateChanged;

        event EventHandler AccountChanged;

        event EventHandler DrinkCooked;
        void CheckInputData(object sender, EventArgs e);
        string GetState();
        bool CheckMoney(string money);
        void Cancel(object sender, EventArgs e);
    }
}
