using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using CalculatorInterpretator.Controller;

namespace CalculatorInterpretator
{
    internal static class Program
    {
        private static void Main()
        {
            var calculatorCore = new CalculatorCore();
            calculatorCore.Execute();
        }
    }
}