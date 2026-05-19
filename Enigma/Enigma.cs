using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Classes;

namespace Enigma
{
    public partial class Enigma : Form
    {
        private readonly Rotor I = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 'Q');
        private readonly Rotor II = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", 'E');
        private readonly Rotor III = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", 'V');
        private readonly Rotor IV = new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", 'J');
        private readonly Rotor V = new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", 'Z');

        private readonly Reflector A = new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD");
        private readonly Reflector B = new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
        private readonly Reflector C = new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");

        private readonly Keyboard keyboard = new Keyboard();
        private Plugboard plugboard;

        public Enigma()
        {
            InitializeComponent();
            plugboardBox.MaxLength = 38;
            firstRotorBox.Text = "A";
            secondRotorBox.Text = "A";
            thirdRotorBox.Text = "A";
            firstRingBox.Text = "A";
            secondRingBox.Text = "A";
            thirdRingBox.Text = "A";
            firstRotorChooseBox.Text = "1";
            secondRotorChooseBox.Text = "2";
            thirdRotorChooseBox.Text = "3";
            reflectorBox.Text = "A";
        }

        private void cryptoButton_Click(object sender, EventArgs e)
        {
            string message = originalMessageBox.Text.ToUpper();
            originalMessageBox.Text = message;

            if (message.Length == 0)
            {
                MessageBox.Show("Error! Please enter the message.");
                return;
            }

            for (int i = 0; i < message.Length; i++)
            {
                if (!char.IsLetter(message[i]) && message[i] != ' ')
                {
                    MessageBox.Show("Error! Message can contain only A-Z symbols.");
                    return;
                }
            }

            string key = (firstRotorBox.Text + secondRotorBox.Text + thirdRotorBox.Text).ToUpper();
            string ring = (firstRingBox.Text + secondRingBox.Text + thirdRingBox.Text).ToUpper();
            string pairs = plugboardBox.Text.ToUpper();
            plugboardBox.Text = pairs;

            if (key.Length != 3 || ring.Length != 3)
            {
                MessageBox.Show("Error! Please enter 3 letters for key and ring.");
                return;
            }

            char fRotor = firstRotorChooseBox.Text[0];
            char sRotor = secondRotorChooseBox.Text[0];
            char tRotor = thirdRotorChooseBox.Text[0];
            char reflector = reflectorBox.Text[0];

            List<Tuple<char, char>> pairsList = new List<Tuple<char, char>>();
            for (int i = 0; i < pairs.Length; i += 2)
            {
                if (i >= pairs.Length - 1)
                {
                    MessageBox.Show("Error! Please enter pairs correctly.");
                    return;
                }

                if (pairs[0] == ' ')
                {
                    MessageBox.Show("Error! Pairs can start only with A-Z symbols.");
                    return;
                }

                if (pairs[i] == ' ')
                {
                    i--;
                    continue;
                }

                if (pairs[i] == ' ' || pairs[i + 1] == ' ')
                {
                    MessageBox.Show("Error! Please enter pairs correctly.");
                    return;
                }

                if (pairs[i] == pairs[i + 1])
                {
                    MessageBox.Show("Error! Pairs can't contain the same symbols.");
                    return;
                }

                if (!char.IsLetter(pairs[i]) || !char.IsLetter(pairs[i + 1]))
                {
                    MessageBox.Show("Error! Pairs can contain only A-Z symbols.");
                    return;
                }

                pairsList.Add(new Tuple<char, char>(pairs[i], pairs[i + 1]));
            }

            plugboard = new Plugboard(pairsList);
            Crypto crypto = new Crypto(I, II, III, IV, V, A, B, C, keyboard, plugboard);
            Dictionary<char, Rotor> rotors = new Dictionary<char, Rotor>
            {
                { '1', I },
                { '2', II },
                { '3', III },
                { '4', IV },
                { '5', V }
            };

            crypto.SetKey(key, fRotor, sRotor, tRotor);
            crypto.SetRings(ring, fRotor, sRotor, tRotor);
            newMessageBox.Text = crypto.Encrypt(message, fRotor, sRotor, tRotor, reflector);

            rotors[fRotor].Rotate(keyboard.abc.IndexOf(key[0]), false);
            rotors[sRotor].Rotate(keyboard.abc.IndexOf(key[1]), false);
            rotors[tRotor].Rotate(keyboard.abc.IndexOf(key[2]), false);
            rotors[fRotor].SetRing(Convert.ToInt32(ring[0] - 'A' + 1), true);
            rotors[sRotor].SetRing(Convert.ToInt32(ring[1] - 'A' + 1), true);
            rotors[tRotor].SetRing(Convert.ToInt32(ring[2] - 'A' + 1), true);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files(*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalMessageBox.Text = System.IO.File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, newMessageBox.Text);
            }
        }

        private void lblReflector_Click(object sender, EventArgs e)
        {

        }
    }
}
