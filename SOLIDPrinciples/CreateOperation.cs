//In this class we apply the Dependency inversion principle by using new instances in the same place
//And they are the base type of IOperation so they are the highest level possible in the program.

namespace SOLIDPrinciples
{
    public static class CreateOperation
    {
        public static IOperation CreateAddOperation(double? f1, double? f2) 
        {
            return new AddCalculatorOperation() { Factor1 = f1, Factor2 = f2};
        }
        public static IOperation CreateSubtractOperation(double? f1, double? f2)
        {
            return new SubtractCalculatorOperation() { Factor1 = f1, Factor2 = f2 };
        }
        public static IOperation CreateMultiplyOperation(double? f1, double? f2)
        {
            return new MultiplyCalculatorOperation() { Factor1 = f1, Factor2 = f2 };
        }
        public static IOperation CreateDivideOperation(double? f1, double? f2)
        {
            return new DivideCalculatorOperation() { Factor1 = f1, Factor2 = f2 };
        }
        public static IOperation CreateToThePowerOperation(double? f1, double? f2)
        {
            return new ToThePowerCalculatorOperation() { Factor1 = f1, Factor2 = f2 };
        }
    }
}

