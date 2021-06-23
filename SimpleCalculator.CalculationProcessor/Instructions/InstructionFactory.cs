using SimpleCalculator.CalculationProcessor.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.CalculationProcessor.Instructions
{
    internal static class InstructionFactory
    {
        public static InstructionAbstract FindInstruction(string name)
        {

            var implementations = AbstractClassImplementationsHelper.GetEnumerableOfType<InstructionAbstract>().ToList();

            var foundType = implementations.FirstOrDefault(x => string.Compare(x.Name, name, true) == 0);
            if (foundType is null)
                throw new ArgumentException($"Instruction {name} not found.");

            return foundType;
        }
    }
}
