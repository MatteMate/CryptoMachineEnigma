using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Crypto
    {
        private Rotor I;
        private Rotor II;
        private Rotor III;
        private Rotor IV;
        private Rotor V;
        private Reflector A;
        private Reflector B;
        private Reflector C;
        private Keyboard keyboard;
        private Plugboard plugboard;
        private string encryptedMessage;

        public Crypto(Rotor I, Rotor II, Rotor III, Rotor IV, Rotor V, Reflector A, Reflector B, Reflector C, Keyboard keyboard, Plugboard plugboard)
        {
            this.I = I;
            this.II = II;
            this.III = III;
            this.IV = IV;
            this.V = V;
            this.A = A;
            this.B = B;
            this.C = C;
            this.keyboard = keyboard;
            this.plugboard = plugboard;
        }

        public void SetKey(string key)
        {
            I.RotateLetter(key[0]);
            II.RotateLetter(key[1]);
            III.RotateLetter(key[2]);
        }

        public void SetRings(string ring)
        {
            I.SetRing(Convert.ToInt32(ring[0] - 'A' + 1), false);
            II.SetRing(Convert.ToInt32(ring[1] - 'A' + 1), false);
            III.SetRing(Convert.ToInt32(ring[2] - 'A' + 1), false);
        }

        public void ResetRings(string ring)
        {
            I.SetRing(Convert.ToInt32(ring[0] - 'A' + 1), true);
            II.SetRing(Convert.ToInt32(ring[1] - 'A' + 1), true);
            III.SetRing(Convert.ToInt32(ring[2] - 'A' + 1), true);
        }

        public string Encrypt(string message)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            foreach (char letter in message)
            {
                if (letter == ' ')
                {
                    encryptedMessage += ' ';
                    continue;
                }

                if (II.GetLeft[0] == II.GetNotch && III.GetLeft[0] == III.GetNotch)
                {
                    I.Rotate();
                    II.Rotate();
                    III.Rotate();
                    count1++;
                    count2++;
                    count3++;
                }
                else if (II.GetLeft[0] == II.GetNotch)
                {
                    I.Rotate();
                    II.Rotate();
                    III.Rotate();
                    count1++;
                    count2++;
                    count3++;
                }
                else if (III.GetLeft[0] == III.GetNotch)
                {
                    II.Rotate();
                    III.Rotate();
                    count2++;
                    count3++;
                }
                else
                {
                    III.Rotate();
                    count3++;
                }

                int signal = keyboard.Forward(letter);
                signal = plugboard.Forward(signal);
                signal = III.Forward(signal);
                signal = II.Forward(signal);
                signal = I.Forward(signal);
                signal = B.Reflect(signal);
                signal = I.Backward(signal);
                signal = II.Backward(signal);
                signal = III.Backward(signal);
                signal = plugboard.Backward(signal);
                char encryptedLetter = keyboard.Backward(signal);
                encryptedMessage += encryptedLetter;
            }
            I.Rotate(count1, false);
            II.Rotate(count2, false);
            III.Rotate(count3, false);
            return encryptedMessage;
        }
    }
}
