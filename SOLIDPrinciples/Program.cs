using System;

//The Single responsible principle is applied by creating many classes which all have only one "job" to do that is very clear and specific.

namespace SOLIDPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMessages.StartingMessage();

            while (true) 
            {
                DisplayMessages.ChooseOptionMessage();
                int option = ReadInput.ReadOption();

                ChooseOption.Option(option);

                if (!DisplayMessages.NewOperation()) 
                {
                    DisplayMessages.EndingMessage();
                    return;
                }

                Pause();

                //List<IOperation> operations = new List<IOperation>
                //{
                //    new AddCalculatorOperation { Factor1 = factor1, Factor2 = factor2 },
                //    new SubtractCalculatorOperation { Factor1 = factor1, Factor2 = factor2 }
                //};

                //foreach (IOperation cal in operations) 
                //{
                //    cal.Calculate();
                //}
                
            }
        }

        public static void Pause() 
        {
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Continuing the application");
            Console.WriteLine();
        }
    }
}
