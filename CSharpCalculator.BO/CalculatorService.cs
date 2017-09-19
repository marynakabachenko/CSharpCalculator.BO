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
            string currentInputValidated = ValidateInput(currentInput);

            // string totalValue = String.Concat(previousInput.TrimStart('0'), currentInputValidated);
            if (previousInput == "0")
            {
                return String.Concat(previousInput.TrimStart('0'), currentInputValidated);
            }

            else
            {
                if ((previousInput.Last<char>()  == '+' ||
                    previousInput.Last<char>() == '-' ||
                    previousInput.Last<char>() == '/' ||
                    previousInput.Last<char>() == '*') &
                    (currentInputValidated == "+" ||
                    currentInputValidated == "-" ||
                    currentInputValidated == "/" ||
                    currentInputValidated == "*" ))
                {
                    return String.Concat(previousInput.TrimStart('0').TrimEnd(previousInput[previousInput.Length - 1]), currentInputValidated);
                }
                else
                {
                    return String.Concat(previousInput.TrimStart('0'), currentInputValidated);
                }
            }
            
        }

        public static string ValidateInput(string currentInput)
        {
            if (Int32.TryParse(currentInput, out int intcurrentInput1))
            {
                return (currentInput);
            }
            else
            {
                if (currentInput.Equals("+") || currentInput.Equals("-") || currentInput.Equals("/") || currentInput.Equals("*") || currentInput.Equals("="))
                {
                    return (currentInput);
                }
                else
                {
                    return ("0");
                }
            }
            
               

        }
    }
}
