using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;

namespace Enigma
{
    public partial class Enigma : Form
    {
        //компоненти Енігми (ротори та рефлектори)
        Rotor I = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", 'Q');
        Rotor II = new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", 'E');
        Rotor III = new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", 'V');
        Rotor IV = new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", 'J');
        Rotor V = new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", 'Z');

        Reflector A = new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD");
        Reflector B = new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
        Reflector C = new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");

        //клавіатура та плагборд
        Keyboard keyboard = new Keyboard();
        Plugboard plugboard;
        public Enigma()
        {
            InitializeComponent();
            List<Tuple<char, char>> pairs = new List<Tuple<char, char>>();
            pairs.Add(new Tuple<char, char>('A', 'R'));
            pairs.Add(new Tuple<char, char>('G', 'K'));
            pairs.Add(new Tuple<char, char>('O', 'X'));
            plugboard = new Plugboard(pairs);
        }

        private void cryptoButton_Click(object sender, EventArgs e)
        {
            string message = textBox1.Text.ToUpper();
            textBox1.Text = message;
            string key = textBox3.Text.ToUpper();
            textBox3.Text = key;
            string ring = textBox4.Text.ToUpper();
            textBox4.Text = ring;
            Crypto crypto = new Crypto(I, II, III, IV, V, A, B, C, keyboard, plugboard);
            crypto.SetKey(key);
            crypto.SetRings(ring);
            textBox2.Text = crypto.Encrypt(message);

            //повернення роторів у початкове положення
            I.Rotate(keyboard.abc.IndexOf(key[0]), false);
            II.Rotate(keyboard.abc.IndexOf(key[1]), false);
            III.Rotate(keyboard.abc.IndexOf(key[2]), false);
        }
    }
}
