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
           
            if (Int32.TryParse(previousInput, out int intpreviousInput)) ;
            else return ("0");
           
            if (Int32.TryParse(currentInput, out int intcurrentInput))
                return String.Concat(previousInput, currentInput).TrimStart('0');
            else
                return (previousInput);
                                  
                      
        }
    }
}
