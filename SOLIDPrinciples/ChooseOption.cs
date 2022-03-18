using System;

namespace SOLIDPrinciples
{
    public class ChooseOption
    {
        public static void Option(int option) 
        {
            IOperation op;

            double? factor1 = ReadInput.ReadFactor();
            double? factor2 = ReadInput.ReadFactor();

            switch (option)
            {
                case 1:
                    op = CreateOperation.CreateAddOperation(factor1, factor2);
                    op.Calculate();
                    break;
                case 2:
                    op = CreateOperation.CreateSubtractOperation(factor1, factor2);
                    op.Calculate();
                    break;
                case 3:
                    op = CreateOperation.CreateMultiplyOperation(factor1, factor2);
                    op.Calculate();
                    break;
                case 4:
                    op = CreateOperation.CreateDivideOperation(factor1, factor2);
                    op.Calculate();
                    break;
                case 5:
                    op = CreateOperation.CreateToThePowerOperation(factor1, factor2);
                    op.Calculate();
                    break;
                default:
                    Console.WriteLine("No case available.");
                    break;
            }
        }
    }
}
