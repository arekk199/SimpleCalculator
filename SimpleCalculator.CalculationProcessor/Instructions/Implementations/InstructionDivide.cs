using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.CalculationProcessor.Instructions.Implementations
{
    internal class InstructionDivide : InstructionAbstract, ICalculable
    {
        public override string Name => "DIVIDE";

        public decimal Calculate(decimal left, decimal right)
        {
            return left / right;
        }
    }
}
