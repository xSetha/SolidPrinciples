using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples
{
    public class ReadInput
    {
        public static int ReadOption()
        {
            Console.WriteLine("Please enter the operation ID: ");
            string output = Console.ReadLine();
            int.TryParse(output, out int result);
            return result;
        }

        public static double? ReadFactor() 
        {
            Console.WriteLine("Input factor: ");
            if (double.TryParse(Console.ReadLine(), out double result))
            {
                return result;
            }
            else 
            {
                DisplayMessages.BadInputMessage();
                return ReadFactor();
            }
        }
    }
}
