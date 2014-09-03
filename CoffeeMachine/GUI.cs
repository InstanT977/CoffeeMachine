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
            _display = new Display();
            _inputPanel = new InputPanel();
            _coffeeMachine = new Machine.CoffeeMachine();
        }

        private void pictureCup_Click(object sender, EventArgs e)
        {

        }

        private void UiInputButtonClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                var code = (int)btn.Tag;
                _inputPanel.ReceiveKey(code);
            }
        }

        private void uiInputButton1_Click(object sender, EventArgs e)
        {
            _inputPanel.ReceiveKey(1);
        }

        private void uiInputButton2_Click(object sender, EventArgs e)
        {
            _inputPanel.ReceiveKey(2);
        }

        private void uiInputButton3_Click(object sender, EventArgs e)
        {
            _inputPanel.ReceiveKey(3);
        }

        private void uiInputButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void uiInputButton5_Click(object sender, EventArgs e)
        {

        }

        private void uiInputButton6_Click(object sender, EventArgs e)
        {

        }

        private void uiInputButton7_Click(object sender, EventArgs e)
        {

        }

        private void uiInputButton8_Click(object sender, EventArgs e)
        {

        }

        private void uiInputButton9_Click(object sender, EventArgs e)
        {

        }

        private void uiInputButton_T1_Click(object sender, EventArgs e)
        {

        }

        private void uiInputButton0_Click(object sender, EventArgs e)
        {

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
