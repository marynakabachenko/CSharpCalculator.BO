using System;
using System.Linq;
using NCalc;

namespace CSharpCalculator.BO
{
    public static class CalculatorService
    {
        public static string ParseInput(string previousInput, string currentInput)
        {
            string currentInputValidated = ValidateInput(currentInput);

            if (previousInput == "0")
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
            else
            {
                if (Int32.TryParse(currentInputValidated, out int intcurrentInput))
                {
                    Int32.TryParse((String.Concat(previousInput, currentInputValidated)), out int intFirstElement);
                    return String.Concat(previousInput, currentInputValidated);
                }
                else
                {
                    Expression previousInputAll = new Expression(previousInput);
                    bool previousParsed = Int32.TryParse(previousInput, out int previousIntInput);
                    if (!previousInputAll.HasErrors() & previousParsed == false)
                    {
                        if (currentInput == "=")
                        {
                            return new Expression(previousInput).Evaluate().ToString();
                        }
                        else
                        {
                            string previousEvaluated =    new Expression(previousInput).Evaluate().ToString();
                            return String.Concat(previousEvaluated, currentInputValidated);
                        }
                    
                    }
                    else
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
                            //evaluate 
                            Int32.TryParse((String.Concat(previousInput.TrimStart('0'), currentInputValidated)), out int intFirstElement);
                            return String.Concat(previousInput.TrimStart('0'), currentInputValidated);
                           
                        }
                    } 
                    
                }

            }
                       
        }

        public static string ValidateInput(string currentInput)
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
    }
}
