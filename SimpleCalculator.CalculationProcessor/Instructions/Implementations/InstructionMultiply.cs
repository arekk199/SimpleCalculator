using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.CalculationProcessor.Instructions.Implementations
{
    internal class InstructionMultiply : InstructionAbstract, ICalculable
    {
        public override string Name => "MULTIPLY";

        public decimal Calculate(decimal left, decimal right)
        {
            return left * right;
        }
    }
}
