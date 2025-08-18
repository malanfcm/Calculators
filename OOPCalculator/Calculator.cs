using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCalculator
{
    public class Calculator
    {
        private readonly Dictionary<string, IOperation> _operations;

        public Calculator() {
            _operations = new Dictionary<string, IOperation>(StringComparer.OrdinalIgnoreCase) {

                { "add", new Addition() },
                { "sub", new Subtraction() },
                { "mul", new Multiplication() },
                { "div", new Division() },

            };
        }

        public double Calculate(string operationKey, double a, double b)
        {
            return _operations[operationKey].Execute(a, b);
        }

    }
}
