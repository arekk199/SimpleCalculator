using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.CalculationProcessor.Instructions.Implementations
{
    internal class InstructionSubtract : InstructionAbstract, ICalculable
    {
        public override string Name => "SUBTRACT";

        public decimal Calculate(decimal left, decimal right)
        {
            return left - right;
        }
    }
}
