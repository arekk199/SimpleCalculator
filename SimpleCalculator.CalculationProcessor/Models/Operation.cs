using SimpleCalculator.CalculationProcessor.Instructions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.CalculationProcessor.Models
{
    internal class Operation
    {
        public Operation(InstructionAbstract instruction, decimal number)
        {
            Instruction = instruction;
            Number = number;
        }

        public InstructionAbstract Instruction { get; set; }
        public decimal Number { get; set; }
    }
}
