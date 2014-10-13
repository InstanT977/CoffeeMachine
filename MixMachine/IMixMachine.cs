using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixMachine
{
    public interface IMixMachine
    {
        bool DrinkExists(string code);
        bool FillReservoirs();

        bool MixAndPoWur(string code);

        int? GetPrice(string code);

        bool SetPrice(string code);

        void SendDrink();

        Dictionary<string, int> GetPriceList();
    }
}
