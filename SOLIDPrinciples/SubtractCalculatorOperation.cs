using System;

namespace SOLIDPrinciples
{
    public class SubtractCalculatorOperation : Calculator, IOperation
    {
        public void Calculate()
        {
            Console.WriteLine("Subtract operation:");
            Console.WriteLine(Factor1 - Factor2);
        }
    }
}
