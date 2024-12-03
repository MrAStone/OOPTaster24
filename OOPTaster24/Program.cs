namespace OOPTaster24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair myChair = new Chair(4, false, "blue");
            Console.WriteLine(myChair.getNumLegs());
            Console.WriteLine(Binary.DecimalToBinary(11));
        }
    }

    class Chair
    {
        private int numLegs;
        private bool hasArms;
        private string colour;

        public Chair(int numChairLegs, bool chairHasArms, string chairColour)
        {
            numLegs = numChairLegs;
            hasArms = chairHasArms;
            colour = chairColour;
        }
        public int getNumLegs()
        {
            return numLegs;
        }
        public void throwChair()
        {

        }

    }
    class Binary
    {
        public static string DecimalToBinary(int decNum)
        {
            string result = "";
            while (decNum > 0)
            {
                result = (decNum % 2).ToString()+result;
                decNum /= 2;
            }
            return result;
        }
        public static int BinaryToDecimal(string binNum)
        {
            int result = 0;
            int binPow = 1;
            for (int i = binNum.Length - 1; i >= 0; i--)
            {
                if (binNum[i] == '1')
                {
                    result += binPow;
                }
                binPow *= 2;
            }

            return result;
        }
    }
}
