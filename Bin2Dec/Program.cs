using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter binary value:");
            string enteredValue = Console.ReadLine();
            char[] enteredValues = enteredValue.ToCharArray();
            double length = enteredValues.Length;
            double calculatedValue = 0;

            if (IsBin(enteredValue))
            {
                Console.WriteLine("Value is binary. Lets go!");
                for (int i = 0; i < length; i++)
                {
                    if (enteredValues[i] == '1') 
                        calculatedValue += Math.Pow(2, length - 1 - i);
                }
                Console.WriteLine(calculatedValue.ToString());
            } else Console.WriteLine("Entered value is not binary, please try again.");

            Console.ReadLine();
        }

        public static bool IsBin(string checkedValue)
        {
            foreach (char c in checkedValue)
            {
                if (c == '0' || c == '1')
                    return true;
                else Console.WriteLine("The {0} value is not binary!", c);
            }
            return false;
        }
    }
}
