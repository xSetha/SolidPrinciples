using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciples
{
    class MultiplyCalculatorOperation : Calculator, IOperation
    {
        public void Calculate()
        {
            Console.WriteLine("Multiply operation:");
            Console.WriteLine(Factor1 * Factor2);
        }
    }
}
