//Liskov substitution principle is applied here because we have a base abstract class that all the other classes inherit from
//Similar the open close principle is applied because we can extend the calculator
//class with as many functionalities but we don't need any changes in the Calcualtor class

namespace SOLIDPrinciples
{
    public abstract class Calculator
    {
        public double? Factor1 { get; set; }
        public double? Factor2 { get; set; }
    }
}
