using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachineP
{
   public interface ICoffeeMach
    {
        void CheckInputData();
        void InitState();
        void Update();
    }
}
