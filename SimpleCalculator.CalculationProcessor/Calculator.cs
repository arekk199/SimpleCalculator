using SimpleCalculator.CalculationProcessor.Instructions;
using SimpleCalculator.CalculationProcessor.Instructions.Implementations;
using SimpleCalculator.CalculationProcessor.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator.CalculationProcessor
{
    public class Calculator
    {
        private List<Operation> operations = new List<Operation>();
        public void EnquequeLine(string line)
        {
            operations.Add(ReadOperationFromLine(line));
        }
        public decimal Calculate()
        {
            Operation apply = operations.Last();

            if (apply.Instruction.GetType() != typeof(InstructionApply))
                throw new ArgumentException($"The last line isn't the apply instruction.");

            if (operations.Where(x => x.Instruction.GetType() == typeof(InstructionApply)).Count() > 1)
                throw new ArgumentException($"There are more than one apply instructions.");

            var calculableOperations = operations.Where(x => x.Instruction as ICalculable != null);

            var result = apply.Number;
            foreach (var operation in calculableOperations)
            {
                var instruction = operation.Instruction as ICalculable;
                result = instruction.Calculate(result, operation.Number);
            }
            return result;
        }

        private static Operation ReadOperationFromLine(string line)
        {
            string[] elements = line.Split(' ');
            if (elements.Length != 2)
            {
                throw new ArgumentException($"Line: {line} should contain two elements. Instruction and number separated by empty character.");
            }

            var instruction = InstructionFactory.FindInstruction(elements[0]);
            if(instruction is null)
                throw new ArgumentException($"Line: {line} contains unknown instruction ({elements[0]}).");

            if (!decimal.TryParse(elements[1], out decimal number))
                throw new ArgumentException($"Line: {line} contains wrong number format ({elements[1]}).");

            var operation = new Operation(instruction, number);
            return operation;
        }
    }
}
