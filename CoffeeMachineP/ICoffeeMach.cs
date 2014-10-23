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

        event EventHandler PriceChanged;

        event EventHandler WaterHeatingStateChanged;
        void CheckInputData(object sender, EventArgs e);
        string GetState();
        bool CheckMoney(string money);
        void SetDefaultState(object sender, EventArgs e);
        Dictionary<string, int> GetPriceList();
    }
}
