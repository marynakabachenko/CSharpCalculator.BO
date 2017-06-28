using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator.BO
{
    public static class CalculatorService
    {
        public static string ParseInput(string previousInput, string currentInput)
        {
            if (previousInput.Length == 0)
            {
                previousInput = "0";
            }

            if (Int32.TryParse(previousInput, out int intpreviousInput))
            {

            }
            else
            {

                if (previousInput[0].Equals('-'))
                {
                    if (Int32.TryParse(previousInput.Substring(1, previousInput.Length-1), out int intpreviousInput1))
                    {

                    }
                    else return ("0");

                }
                else return ("0");
            }

            if (Int32.TryParse(currentInput, out int intcurrentInput1))
            {
                return String.Concat(previousInput, currentInput).TrimStart('0');
            }
            else
            {

                if (currentInput.Substring(0,1).Equals("+") || currentInput.Substring(0, 1).Equals("-") ||currentInput.Substring(0, 1).Equals("/") || currentInput.Substring(0, 1).Equals("*"))
                {
                    if (Int32.TryParse(currentInput.Substring(1, currentInput.Length-1), out int intcurrentInput))
                    {
                        return String.Concat(previousInput, currentInput).TrimStart('0');
                    }
                    else return String.Concat(previousInput, currentInput.Substring(0,1));
                }
                else
                {
                    return (previousInput);
                }

            }


        }
    }
}
