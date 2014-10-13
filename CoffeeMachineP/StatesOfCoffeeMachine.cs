using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public enum StatesOfCoffeeMachine
    {
           SDrinkRequest,
           SPriceRequest,
           SDone,
           SMoneyRequest,
           SEmptyReservoir,
           SUnlock,
           SLock,
           SAdmin,
           SWaterHeating,
           SIncorrectInput,
           SNotEnoughMoney,
           SReservoirsFilled,
           SCashCleared,
           SDrinkCodeRequest,
           SDrinkNewPriceRequest
    }
}
