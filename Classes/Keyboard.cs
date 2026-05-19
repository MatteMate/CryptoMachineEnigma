namespace Classes
{
    public class Keyboard
    {
        public string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public Keyboard()
        {
        }
        public int Forward(char letter)
        {
            int signal = abc.IndexOf(letter);
            return signal;
        }
        public char Backward(int signal)
        {
            char letter = abc[signal];
            return letter;
        }
    }
}
