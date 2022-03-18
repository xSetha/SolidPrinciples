using System;

namespace SOLIDPrinciples
{
    public class AddCalculatorOperation : Calculator, IOperation
    {
        public void Calculate() 
        {
            Console.WriteLine("Add operation:");
            Console.WriteLine(Factor1 + Factor2);
        }
    }
}
