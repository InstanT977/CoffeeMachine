using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class BanknoteChecker
    {
        public int _result;
        public int _value;
        public Banknote _banknote;

        public bool Check(Banknote money)
        {
            var rand = new Random();
            if (rand.Next(0, 1000) > 950)
            {
                return false;
            }
            return true;
        }

    }
}
