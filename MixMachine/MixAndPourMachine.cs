using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using MixMachine;

namespace CoffeeMachine
{
   public class MixAndPourMachine :IMixMachine
   {
        private WaterContainer WaterContainer;
        private Timer _timer;
        public List<Reservoir> _reservoirs;
        public bool _isWork;
        public List<Recipe> _recipes;

        public CoupContainer _coupContainer;


       public MixAndPourMachine()
       {
           _timer.Elapsed += CheckWaterTemperature;
           _timer.Interval = 10000; // 10 seconds
           _timer.Start();
       }

       private void CheckWaterTemperature(object sender, ElapsedEventArgs e)
       {
           needHeating = WaterContainer.CheckTemperature();
           throw new NotImplementedException();
       }

       public void MixAndPour()
        {
            
        }
        public void SendDrink()
        {
            
        }

    }
}
