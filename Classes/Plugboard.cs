using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Plugboard
    {
        private string left;
        private string right;

        public Plugboard(List<Tuple<char, char>> pairs)
        {
            Keyboard keyboard = new Keyboard();
            left = keyboard.abc;
            right = keyboard.abc;

            foreach (var pair in pairs)
            {
                char A = pair.Item1;
                char B = pair.Item2;

                int pos_A = left.IndexOf(A);
                int pos_B = left.IndexOf(B);

                left = left.Substring(0, pos_A) + B + left.Substring(pos_A + 1);
                left = left.Substring(0, pos_B) + A + left.Substring(pos_B + 1);
            }
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
    }
}
