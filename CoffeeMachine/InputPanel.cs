using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class InputPanel
    {
        public bool _locked;
        public String _input;
        public List<InputButton> _buttonList;

        public InputPanel()
        {
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            _buttonList = new List<InputButton>();
            for (var i = 0; i < 10; i++)
            {
                _buttonList.Add(new InputButton((char)i));
            }
            _buttonList.Add(new InputButton('#'));
            _buttonList.Add(new InputButton('*'));
            _buttonList.Add(new InputButton('i'));
            _buttonList.Add(new InputButton('e'));
        }
        public void ReceiveKey(int code)
        {
            if (!_locked)
            {
                _input += _buttonList[code].Press();
            }
        }
        public void Lock()
        {
            _locked = true;
        }
        public void UnLock()
        {
            _locked = false;
        }
    }
}
