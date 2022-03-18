using System;

namespace SOLIDPrinciples
{
    public class DisplayMessages
    {
        public static void StartingMessage() 
        {
            Console.WriteLine("The calculator has started");
        }
        public static void ChooseOptionMessage() 
        {
            Console.WriteLine("Please choose a option: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. To the power");
        }

        public static void BadInputMessage()
        {
            Console.WriteLine("Bad input.");
        }

        public static void EndingMessage()
        {
            Console.WriteLine("The application has ended.");
        }

        public static bool NewOperation() 
        {
            Console.WriteLine("Do you want to continue with a new operation? y/n");
            if (Console.Read() == 'y')
                return true;
            return false;
        }
    }
}
