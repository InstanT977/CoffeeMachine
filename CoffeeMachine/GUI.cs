using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeMachineP;
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
        }

    }
}
