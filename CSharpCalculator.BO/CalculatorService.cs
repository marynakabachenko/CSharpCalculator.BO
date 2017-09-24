using System;
using System.Linq;
using NCalc;

namespace CSharpCalculator.BO
{
    public class CalculatorService
    {
        public static string ParseInput(string previousInput, string currentInput)
        {
            string currentInputValidated = ValidateInput(currentInput);

            if (previousInput == "0")
            {
                return (checkIfCurrentIsSign(previousInput, currentInputValidated));
            }
            else
            {
                if (Int32.TryParse(currentInputValidated, out int intcurrentInput))
                {
                    return (checkIfDeleteZero(previousInput, currentInputValidated));
                }
                else
                {
                    return (checkIfReadyToEvaluate(previousInput, currentInputValidated));
                }

            }

        }

        private static string ValidateInput(string currentInput)
        {
            if (Int32.TryParse(currentInput, out int intcurrentInput))
            {
                return (currentInput);
            }
            else
            {
                if (currentInput.Equals("+") || currentInput.Equals("-") || currentInput.Equals("/") || currentInput.Equals("*") || currentInput.Equals("="))
                {
                    return (currentInput);
                }
                else //is it used??
                {
                    return ("0");
                }
            }
        }

        private static string checkIfCurrentIsSign(string previousInput, string currentInputValidated)
        {
            if (currentInputValidated == "+" || currentInputValidated == "/" || currentInputValidated == "*" || currentInputValidated == "-" || currentInputValidated == "=")
            {
                return String.Concat(previousInput, currentInputValidated);
            }
            else
            {
                return String.Concat(previousInput.TrimStart('0'), currentInputValidated);
            }
        }

        private static string checkIfPreviousIsSign(string previousInput, string currentInputValidated)
        {
            if (previousInput.Last<char>() == '+' ||
                               previousInput.Last<char>() == '-' ||
                               previousInput.Last<char>() == '/' ||
                               previousInput.Last<char>() == '*' ||
                               previousInput.Last<char>() == '=')
            {
                return String.Concat(previousInput.TrimStart('0').TrimEnd(previousInput[previousInput.Length - 1]), currentInputValidated);
            }
            else
            {
                Int32.TryParse((String.Concat(previousInput.TrimStart('0'), currentInputValidated)), out int intFirstElement);
                return String.Concat(previousInput.TrimStart('0'), currentInputValidated);
            }
        }

        private static string checkIfReadyToEvaluate(string previousInput, string currentInputValidated)
        {
            Expression previousInputAll = new Expression(previousInput);
            bool previousParsed = Int32.TryParse(previousInput, out int previousIntInput);
            if (!previousInputAll.HasErrors() & previousParsed == false)
            {
                return (checkIfCurrentSignIsEqual(previousInput, currentInputValidated));
            }
            else
            {
                return (checkIfPreviousIsSign(previousInput, currentInputValidated));
            }
        }

        private static string checkIfCurrentSignIsEqual(string previousInput, string currentInputValidated)
        {
            if (currentInputValidated == "=")
            {
                return new Expression(previousInput).Evaluate().ToString();
            }
            else
            {
                string previousEvaluated = new Expression(previousInput).Evaluate().ToString();
                return String.Concat(previousEvaluated, currentInputValidated);
            }
        }
        private static string checkIfDeleteZero(string previousInput, string currentInputValidated)
        {
            if ((currentInputValidated != "0" &&
                previousInput.Last<char>() == '0' &&
                (previousInput.TrimEnd('0').Last<char>() == '+' ||
                previousInput.TrimEnd('0').Last<char>() == '-' ||
                previousInput.TrimEnd('0').Last<char>() == '/' ||
                previousInput.TrimEnd('0').Last<char>() == '*')) ||
                (currentInputValidated == "0" &&
                previousInput.Last<char>() == '0' &&
                (previousInput.TrimEnd('0').Last<char>() == '+' ||
                previousInput.TrimEnd('0').Last<char>() == '-' ||
                previousInput.TrimEnd('0').Last<char>() == '/' ||
                previousInput.TrimEnd('0').Last<char>() == '*')))
            {
                return String.Concat(previousInput.TrimEnd('0'),currentInputValidated);
            }
            else
            {
                return String.Concat(previousInput, currentInputValidated);        
            }
        }

    }

   
}
