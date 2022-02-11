using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;

namespace CalculatorInterpretator.Controller
{
    public class CalculatorCore : IController
    {
        public string UserInput { get; set; }
        public string UserOutput { get; set; }
        private bool _isWork;

        public CalculatorCore()
        {
            _isWork = true;
        }

        public void Execute()
        {
            while (_isWork)
            {
                var input = Console.ReadLine();

                if (input == "0")
                {
                    _isWork = false;
                    break;
                }

                try
                {
                    UserOutput = Calculate(input).ToString(CultureInfo.InvariantCulture);
                }
                catch (Exception)
                {
                    
                    UserOutput = "Error";
                }

                Console.ForegroundColor = UserOutput == "Error" ? ConsoleColor.Red : ConsoleColor.Green;
                Console.WriteLine(">>> " + UserOutput);
                Console.ResetColor();
            }
        }

        public double Calculate(string input)
        {
            var operations = Regex.Matches(input!, @"\d+|\+|\-|\*|\/|\(|\)");

             return Convert.ToDouble(new DataTable().Compute(operations.Aggregate("", 
                     (current, match) => current + match.Value), 
                 null));
        }
    }
}