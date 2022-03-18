using System;
// Here we implement the Interface segregation principle by using different interfaces specific for one class implementation
// We do not have 1 big "fat" interface that all classes must implement and not use everything that the interface offers

namespace SOLIDPrinciples
{
    class DivideCalculatorOperation : Calculator, IOperation, IDivideCalculatorOperation
    {
        public void Calculate()
        {
            if (ValidateOperation())
            {
                Console.WriteLine("Divide operation:");
                Console.WriteLine(Factor1 / Factor2);
            }
            else Console.WriteLine("Not valid operation");
        }

        public bool ValidateOperation()
        {
            if (Factor2 == 0)
                return false;
            return true;
        }
    }
}
