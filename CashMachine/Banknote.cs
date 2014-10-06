using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Banknote
    {
        public int _value;

        public Banknote(string val)
        {
            _value = Int32.Parse(val);
        }
    }
}
