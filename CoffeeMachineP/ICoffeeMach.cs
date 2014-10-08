using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Machine
{
   public interface ICoffeeMach
    {
        void CheckInputData(object sender, EventArgs e);
        string InitState();
        bool CheckMoney(string money);
        void Update();
    }
}
