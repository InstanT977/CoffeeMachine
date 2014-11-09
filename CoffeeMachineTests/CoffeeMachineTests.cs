using System;
using System.Threading;
using CashMachine;
using CoffeeMachine;
using Machine;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeMachine = Machine.CoffeeMachine;
using MixMachine;

namespace CoffeeMachineTests
{
    [TestClass]
    public class CoffeeMachineTests
    {
        [TestMethod]
        public void CoffeeMachine_IncorrectInput_Test()
        {
            ICoffeeMach coffeeMachine;
            coffeeMachine = new Machine.CoffeeMachine();

            coffeeMachine.CheckInputData("(UmsSoft)", null);

            const StatesOfCoffeeMachine expectedState = StatesOfCoffeeMachine.SIncorrectInput;
            var expectedTextState = GetTestState(expectedState);
            var resultState = coffeeMachine.GetState();
            Assert.AreEqual(resultState, expectedTextState,"");
        }

        [TestMethod]
        public void Reservoirs_GetDrink_Test()
        {
            var reservoirs = new Reservoirs();
            const int count = 50;
            var drink = reservoirs.GetDrink(count);

            Assert.AreEqual(count,drink.DrinkCount);
        }

        [TestMethod]
        public void Reservoirs_DrinkExists()
        {
            var reservoirs = new Reservoirs();
            const int drinkCount = 50;
            const int reservoirVolume = 200;
            var result1 = reservoirs.CheckDrinkExists(drinkCount);
            var result2 = true;
            for (var i = drinkCount; i <= reservoirVolume; i += drinkCount)
            {
                reservoirs.GetDrink(i);
                result2 = reservoirs.CheckDrinkExists(i);
            }

            Assert.AreEqual(result1 && result2,false);
        }

        [TestMethod]
        public void CoffeeMachine_InputAdmin_Test()
        {
            var coffeeMachine = new Machine.CoffeeMachine();
            var needState = GetTestState(StatesOfCoffeeMachine.SAdmin);
            const string password = "771066582";
            coffeeMachine.CheckInputData(password,new EventArgs());
            var state = coffeeMachine.GetState();
            Assert.AreEqual(needState,state);
        }

        [TestMethod]
        public void MixAndPowurMachine_GetPrice_Test()
        {
            var mixMachine = new MixAndPourMachine();
            var priceList = mixMachine.GetPriceList();
            var priceCount = priceList.Count;
            var result1 = false;
            for (var i = 0; i < priceCount; i++)
            {
                result1 = mixMachine.GetPrice(i.ToString()) != null;
            }

            var result2 = mixMachine.GetPrice((priceCount + 1).ToString()) == null;

            Assert.AreEqual(result1 && result2,true);
        }

        [TestMethod]
        public void MixAndPowurMachine_SetPrice_Test()
        {
            var mixMachine = new MixAndPourMachine();
            const string code = "1";
            const int newPrice = 999;
            var price1 = mixMachine.GetPrice(code);

            mixMachine.SetPrice(code, newPrice);

            var price2 = mixMachine.GetPrice(code);

            Assert.AreEqual(price2,newPrice);
        }

        [TestMethod]
        public void MixAndPowurMAchine_CheckWaterTemperature_Test()
        {
            var mixMachine = new MixAndPourMachine();
            var i = 0;
            const int maxCounter = 100000;
            bool isError = false;
            while (!mixMachine.CheckWaterTemperature())
            {
                Thread.Sleep(1000);
                i++;
                if (i > maxCounter)
                {
                    break;
                    isError = true;
                }

            }
            Assert.AreEqual(isError,false);
        }

        [TestMethod]
        public void Acceptor_GetMoney_Test()
        {
            IAcceptor acceptor;
            acceptor = new Acceptor();
            var rand = new Random();

            for(var i=0;i<1000000;i++)
            {
                var money = rand.Next(10, 5000);
                acceptor.GetMoney(money.ToString());
                if (acceptor.Failed())
                {
                    break;
                }
            }
            Assert.AreEqual(acceptor.Failed(),true);
        }

        public string GetTestState(StatesOfCoffeeMachine testState)
        {
            switch (testState)
            {
                case StatesOfCoffeeMachine.SReady:
                    return "Готов к работе!";
                case StatesOfCoffeeMachine.SAdmin:
                    return "Вы авторизрованы!";
                case StatesOfCoffeeMachine.SDone:
                    return "Готово!";
                case StatesOfCoffeeMachine.SDrinkRequest:
                    return "Запрос напитка...";
                case StatesOfCoffeeMachine.SEmptyReservoir:
                    return "Отсутствуют ингридиенты!";
                case StatesOfCoffeeMachine.SLock:
                    return "Заблокировано.";
                case StatesOfCoffeeMachine.SMoneyRequest:
                    return "Запрос средств...";
                case StatesOfCoffeeMachine.SPriceRequest:
                    return "Запрос цены напитка";
                case StatesOfCoffeeMachine.SPriceChanged:
                    return "Цена успешно изменена!";
                case StatesOfCoffeeMachine.SUnlock:
                    return "Разблокирование...";
                case StatesOfCoffeeMachine.SWaterHeating:
                    return "Нагрев воды...";
                case StatesOfCoffeeMachine.SIncorrectInput:
                    return "Некорректный ввод!";
                case StatesOfCoffeeMachine.SNotEnoughMoney:
                    return "Недостаточно средств!";
                case StatesOfCoffeeMachine.SReservoirsFilled:
                    return "Резервуары пополнены.";
                case StatesOfCoffeeMachine.SCashCleared:
                    return "Получены средства автомата";
                case StatesOfCoffeeMachine.SAccountCleared:
                    return "Выдача сдачи";
                case StatesOfCoffeeMachine.SDrinkCodeRequest:
                    return "Введите код напитка";
                case StatesOfCoffeeMachine.SDrinkNewPriceRequest:
                    return "Введите новую цену напитка";
                default:
                    return "";
            }
        }
    }


}
