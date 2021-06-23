using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.CalculationProcessor.Instructions.Implementations
{
    internal class InstructionAdd : InstructionAbstract, ICalculable
    {
        public override string Name => "ADD";

        public decimal Calculate(decimal left, decimal right)
        {
            return left + right;
        }
    }
}
