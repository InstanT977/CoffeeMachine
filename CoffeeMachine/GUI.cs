using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Machine;
using CashMachine;
using MixMachine;
namespace CoffeeMachine
{
    public partial class GUI : Form
    {
        public ICoffeeMach _coffeeMachine;
        public InputPanel _inputPanel;
        public Display _display;
        public GUI()
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
        }

        private void pictureCup_Click(object sender, EventArgs e)
        {

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
        private void uiInputButton_T2_Click(object sender, EventArgs e)
        {

        }

        private void uiInformationButton_Click(object sender, EventArgs e)
        {

        }

        private void uiExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
