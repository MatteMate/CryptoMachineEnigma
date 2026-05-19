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
        private string encryptedMessage = string.Empty;
        private Dictionary<char, Rotor> rotors;
        private Dictionary<char, Reflector> reflectors;
        public Crypto(Rotor I, Rotor II, Rotor III, Rotor IV, Rotor V, Reflector A, Reflector
        B, Reflector C, Keyboard keyboard, Plugboard plugboard, Dictionary<char, Rotor>? rotors =
        null, Dictionary<char, Reflector>? reflectors = null)
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
            this.rotors = rotors ?? new Dictionary<char, Rotor>
            {
                { '1', I },
                { '2', II },
                { '3', III },
                { '4', IV },
                { '5', V }
            };
            this.reflectors = reflectors ?? new Dictionary<char, Reflector>
            {
                { 'A', A },
                { 'B', B },
                { 'C', C }
            };
        }
        public void SetKey(string key, char fRotor, char sRotor, char tRotor)
        {
            rotors[fRotor].RotateLetter(key[0]);
            rotors[sRotor].RotateLetter(key[1]);
            rotors[tRotor].RotateLetter(key[2]);
        }
        public void SetRings(string ring, char fRotor, char sRotor, char tRotor)
        {
            rotors[fRotor].SetRing(Convert.ToInt32(ring[0] - 'A' + 1), false);
            rotors[sRotor].SetRing(Convert.ToInt32(ring[1] - 'A' + 1), false);
            rotors[tRotor].SetRing(Convert.ToInt32(ring[2] - 'A' + 1), false);
        }
        public void ResetRings(string ring, char fRotor, char sRotor, char tRotor)
        {
            rotors[fRotor].SetRing(Convert.ToInt32(ring[0] - 'A' + 1), true);
            rotors[sRotor].SetRing(Convert.ToInt32(ring[1] - 'A' + 1), true);
            rotors[tRotor].SetRing(Convert.ToInt32(ring[2] - 'A' + 1), true);
        }
        public string Encrypt(string message, char fRotor, char sRotor, char tRotor, char
        reflector)
        {
            encryptedMessage = string.Empty;
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            foreach (char letter in message)
            {
                if (letter == ' ' || letter == ',' || letter == '.' || letter == ':' ||
                letter == ';'
                || letter == '!' || letter == '?' || letter == '-')
                {
                    encryptedMessage += letter;
                    continue;
                }
                if (rotors[sRotor].GetLeft[0] == rotors[sRotor].GetNotch &&
                rotors[tRotor].GetLeft[0] == rotors[tRotor].GetNotch)
                {
                rotors[fRotor].Rotate();
                    rotors[sRotor].Rotate();
                    rotors[tRotor].Rotate();
                    count1++;
                    count2++;
                    count3++;
                }
                else if (rotors[sRotor].GetLeft[0] == rotors[sRotor].GetNotch)
                {
                    rotors[fRotor].Rotate();
                    rotors[sRotor].Rotate();
                    rotors[tRotor].Rotate();
                    count1++;
                    count2++;
                    count3++;
                }
                else if (rotors[tRotor].GetLeft[0] == rotors[tRotor].GetNotch)
                {
                    rotors[sRotor].Rotate();
                    rotors[tRotor].Rotate();
                    count2++;
                    count3++;
                }
                else
                {
                    rotors[tRotor].Rotate();
                    count3++;
                }
                int signal = keyboard.Forward(letter);
                signal = plugboard.ForwardSignal(signal);
                signal = rotors[tRotor].Forward(signal);
                signal = rotors[sRotor].Forward(signal);
                signal = rotors[fRotor].Forward(signal);
                signal = reflectors[reflector].Reflect(signal);
                signal = rotors[fRotor].Backward(signal);
                signal = rotors[sRotor].Backward(signal);
                signal = rotors[tRotor].Backward(signal);
                signal = plugboard.BackwardSignal(signal);
                char encryptedLetter = keyboard.Backward(signal);
                encryptedMessage += encryptedLetter;
            }
            rotors[fRotor].Rotate(count1, false);
            rotors[sRotor].Rotate(count2, false);
            rotors[tRotor].Rotate(count3, false);
            return encryptedMessage;
        }
    }
}
