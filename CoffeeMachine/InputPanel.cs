using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class InputPanel
    {
        private GUI _owner;
        public bool _locked;
        public String _input;
        public List<InputButton> _buttonList;
        public event EventHandler ApplyButtonClicked;
        public event EventHandler ClearButtonClicked;
        //private static void OnKeyButtonClicked()
        //{
        //    EventHandler handler = KeyButtonClicked;
        //    if (handler != null) handler(null, EventArgs.Empty);
        //}

        public InputPanel(GUI owner)
        {
            InitializeButtons();
            _owner = owner;
        }

        private void InitializeButtons()
        {
            _buttonList = new List<InputButton>();
            for (var i = 0; i < 10; i++)
            {
                _buttonList.Add(new InputButton(i.ToString()));
            }
            _buttonList.Add(new InputButton("*"));
            _buttonList.Add(new InputButton("#"));
            _buttonList.Add(new InputButton("i"));
            _buttonList.Add(new InputButton("e"));
        }
        public void ReceiveKey(int code)
        {
            if (!_locked)
            {
                var pressedKey = _buttonList[code].Press();
                if (pressedKey == "*")
                {
                    ApplyButtonClicked(_input,new EventArgs());
                }
                if (pressedKey == "#")
                {
                    ClearButtonClicked(null, new EventArgs());
                    Thread.Sleep(1000);
                }
                _input += pressedKey;
                _owner._display.InputInfo = _input;

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
