using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCalculator.BO
{
    public static class CalculatorService
    {
        public static string ParseInput(string prevoiusInput, string currentInput)
        {
            //prevoiusInput = "5";
            //currentInput = "7";

            var finalOutput = String.Concat(prevoiusInput, currentInput);
            
            return finalOutput;
        }
    }
}
