using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Classes
{
    public class Reflector : Rotor
    {
        private string left;
        private string right;
        public Reflector(string wiring) : base(wiring, ' ')
        {
            Keyboard keyboard = new Keyboard();
            left = keyboard.abc;
            right = wiring;
        }
        public int Reflect(int signal)
        {
            return Forward(signal);
        }
    }
}
