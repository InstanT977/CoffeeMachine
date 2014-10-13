using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachine
{
    public class Display
    {
        private GUI _owner;

        public Display(GUI owner)
        {
            _owner = owner;
        }
        /// <summary>
        /// Информация для пользователя
        /// </summary>
        public String MainInfo
        {
            get
            {
                return _owner.uiDisplayUserInformation.Text;
            }
            set
            {
                _owner.uiDisplayUserInformation.Text = value;
                _owner.uiDisplayUserInformation.Refresh();
            }
        }

        /// <summary>
        /// Вводимые символы
        /// </summary>
        public String InputInfo
        {
            get
            {
                return _owner.uiDisplayInput.Text;
            }
            set
            {
                _owner.uiDisplayInput.Text = value;
                _owner.uiDisplayInput.Refresh();
            }
        }
        /// <summary>
        /// Состояние счета
        /// </summary>
        public String MoneyInfo
        {
            get
            {
                return _owner.uiDisplayDepositCount.Text;
            }
            set
            {
                _owner.uiDisplayDepositCount.Text = value;
            }
        }
    }
}
