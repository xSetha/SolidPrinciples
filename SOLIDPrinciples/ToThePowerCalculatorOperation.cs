using System;

namespace SOLIDPrinciples
{
    class ToThePowerCalculatorOperation : Calculator, IOperation
    {
        public void Calculate()
        {
            Console.WriteLine($"{Factor1} to the power of {Factor2} is :");
            Console.WriteLine(Math.Pow((double)(Factor1), (double)(Factor2)));
        }
    }
}
