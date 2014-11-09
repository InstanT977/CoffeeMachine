using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Machine;
using CashMachine;
using MixMachine;
namespace CoffeeMachine
{
    public partial class GuiForm : Form
    {
        public ICoffeeMach _coffeeMachine;
        public InputPanel _inputPanel;
        public Display _display;
        public GuiForm()
        {
            InitializeComponent();
            InitializeMainComponents();
        }

        private void InitializeMainComponents()
        {
            _display = new Display(this);
            _inputPanel = new InputPanel(this);
            _coffeeMachine = new Machine.CoffeeMachine();
            _inputPanel.ApplyButtonClicked += _coffeeMachine.CheckInputData;
            _inputPanel.ClearButtonClicked += _coffeeMachine.SetDefaultState;
            _coffeeMachine.StateChanged += ChangeMainDisplayState;
            _coffeeMachine.AccountChanged += ChangeAccountState;
            _coffeeMachine.PriceChanged += SetInformation;
            _coffeeMachine.WaterHeatingStateChanged += _display.ChangeHeatingLight;
            _coffeeMachine.DrinkCooked += ShowCup;
            ChangeMainDisplayState(null,null);
            SetInformation(null, null);
            uiCashButton.Click += _inputPanel.uiWidthrowCashButtonClick;
        }

        private void pictureCup_Click(object sender, EventArgs e)
        {
            pictureCup.Hide();
        }

        public void SetInformation(object sender, EventArgs e)
        {
            const string start =
                @"* - Принять , # - Отмена
---------------------------------";
            var priceLst = _coffeeMachine.GetPriceList();
            string txt = start;
            int code = 0;
            foreach (var price in priceLst)
            {
                txt += price.Key + " - Код: " + code + Environment.NewLine;
                txt += "Цена: " + price.Value + " руб." + Environment.NewLine;
                txt += "---------------------------------" + Environment.NewLine;
                code++;
            }
            _display.InformationMenu = txt;

        }

        private void ShowCup(object sender, EventArgs e)
        {
            pictureCup.Show();
        }

        private void ChangeMainDisplayState(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            _display.MainInfo = _coffeeMachine.GetState();
            Invalidate();
        }


        private void ChangeAccountState(object sender, EventArgs e)
        {
            _display.MoneyInfo = sender.ToString();
        }
        private void UiInputButtonClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                int code = Convert.ToInt32(btn.Tag.ToString());
                _inputPanel.ReceiveKey(code);
            }
        }



        private void uiInformationButton_Click(object sender, EventArgs e)
        {
            uiInfoPanel.Visible = !uiInfoPanel.Visible;
        }

        private void uiExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uiPickMoney_Click(object sender, EventArgs e)
        {
            uiMoneyPanel.Visible = !uiMoneyPanel.Visible;
        }

        private void UiMoneyInsertClick(object sender, EventArgs e)
        {
            var money = ((Button) sender).Tag.ToString();
            var result = _coffeeMachine.CheckMoney(money);
        }
    }
}
