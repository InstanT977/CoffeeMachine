using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixMachine
{
    public interface IMixMachine
    {
        bool MixAndPoWur();
        int? GetPrice(string code);
        void SendDrink();
    }
}
