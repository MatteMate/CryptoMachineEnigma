using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Rotor
    {
        private string left;
        private string right;
        private char notch;

        public Rotor(string wiring, char notch)
        {
            Keyboard keyboard = new Keyboard();
            left = keyboard.abc;
            right = wiring;
            this.notch = notch;
        }

        public char GetNotch
        {
            get { return notch; }
            set { notch = value;}
        }

        public string GetLeft
        {
            get { return left; }
            set { left = value; }
        }

        public string GetRight
        {
            get { return right; }
            set { right = value; }
        }

        public int Forward(int signal)
        {
            char letter = right[signal];
            int pos = left.IndexOf(letter);
            return pos;
        }

        public int Backward(int signal)
        {
            char letter = left[signal];
            int pos = right.IndexOf(letter);
            return pos;
        }

        public void Rotate(int n = 1, bool Forward = true)
        {
            for (int i = 0; i < n; i++)
            {
                if (Forward)
                {
                    left = left.Substring(1) + left[0];
                    right = right.Substring(1) + right[0];
                }
                else
                {
                    left = left[left.Length - 1] + left.Substring(0, left.Length - 1);
                    right = right[right.Length - 1] + right.Substring(0, right.Length - 1);
                }
            }
        }

        public void RotateLetter(char letter)
        {
            Keyboard keyboard = new Keyboard();
            int n = keyboard.abc.IndexOf(letter);
            Rotate(n);
        }

        public void SetRing(int n, bool Forward)
        {
            Keyboard keyboard = new Keyboard();
            Rotate(n - 1, Forward);
            int nNotch = keyboard.abc.IndexOf(notch);
            notch = keyboard.abc[Math.Abs((nNotch - n) % 26)];
        }
    }

}
