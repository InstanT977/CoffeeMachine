using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class InputButton
    {
        public InputButton(char key)
        {
            _key = key.ToString();
        }
        private readonly string _key;

        public string Press()
        {
            return _key;
        }

        public void Release()
        {
            
        }
    }
}
