using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class CoupContainer
    {
        private const int DefaultCoupCount = 50;
        private int _count;
        public bool IsEmpty;

        public void GetCoup()
        {
            if (!IsEmpty)
            {
                _count--;
            }

            if (_count == 0)
            {
                IsEmpty = true;
            }

    }
        public void AddCoup()
        {
            _count = DefaultCoupCount;
        }
    }
}
