using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MixMachine;

namespace CoffeeMachine
{
   public class MixAndPourMachine :IMixMachine
    {
        public List<Reservoir> _reservoirs;
        public bool _isWork;
        public List<Recipe> _recipes;

        public CoupContainer _coupContainer;

        public void MixAndPour()
        {
            
        }
        public void SendDrink()
        {
            
        }

    }
}
