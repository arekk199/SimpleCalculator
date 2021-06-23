using System;
using Xunit;

namespace SimpleCalculator.CalculationProcessor.Test
{
    public class ProcessorTest
    {
        [Fact]
        public void TestProcessor_CorrectCalculation_v1()
        {
            string[] lines = new string[] { "add 2",
                              "multiply 3",
                               "apply 10" };
            Calculator calculationProcessor = new();

            foreach (var line in lines)
                calculationProcessor.EnquequeLine(line);

            decimal result = calculationProcessor.Calculate();
            Assert.Equal(36, result);
        }

        [Fact]
        public void TestProcessor_CorrectCalculation_v2()
        {
            string[] lines = new string[] { "multiply 3",
                                            "add 2",
                                            "apply 10" };
            Calculator calculationProcessor = new();

            foreach (var line in lines)
                calculationProcessor.EnquequeLine(line);

            decimal result = calculationProcessor.Calculate();
            Assert.Equal(32, result);
        }
    }
}
