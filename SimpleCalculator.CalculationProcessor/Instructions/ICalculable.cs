using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.CalculationProcessor.Instructions
{
    internal interface ICalculable
    {
        decimal Calculate(decimal left, decimal right);
    }
}
