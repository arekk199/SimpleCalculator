using SimpleCalculator.CalculationProcessor;
using System;
using System.IO;

namespace SimpleCalculator
{
    class Program
    {
        /// <summary>
        /// Simple calculator.
        /// </summary>
        /// <param name="args">File path</param>
        static void Main(string[] args)
        {
            string filePath;
            if (args.Length > 0)
            {
                filePath = args[0];
            }
            else
            {
                Console.Write("Please input file path: ");
                filePath = Console.ReadLine();
            }

            if (!IsPathValid(filePath))
            {
                Console.WriteLine("The path isn't valid or isn't exist.");
            }
            else
            {
                try { ProcessFile(filePath); }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
            Console.ReadLine();
        }

        private static bool IsPathValid(string filePath)
        {
            FileInfo fi = new(filePath);
            return fi.Exists;
        }

        private static void ProcessFile(string filePath)
        {
            Calculator calculationProcessor = new();
            StreamReader file = new(filePath);

            string line;
            while ((line = file.ReadLine()) != null)
            {
                calculationProcessor.EnquequeLine(line);
            }

            decimal result = calculationProcessor.Calculate();
            Console.WriteLine(result);
        }
    }
}
