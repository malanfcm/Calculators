using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator
{
    public interface IOperation
    {
        string Name { get; }
        double Execute(double a, double b);
    }

    public class Addition : IOperation
    {
        public string Name => "Addition";
        public double Execute(double a, double b) => a + b;
    }

    public class Subtraction : IOperation
    {
        public string Name => "Addition";
        public double Execute(double a, double b) => a - b;
    }

    public class Multiplication : IOperation
    {
        public string Name => "Addition";
        public double Execute(double a, double b) => a * b;
    }

    public class Division : IOperation
    {
        public string Name => "Addition";
        public double Execute(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot divide by zero");
            {
                return a / b;
            }
        }
    }
}
