using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CSharpCalculator.BO;

namespace CSharpCalculator.BO.Test
{
    [TestFixture] //contains unit test, all in [] are attribute. Attribute is a marker
    public class CalculatorServiceTest
    {
        [TestCase("1", "3", "13")]
        [TestCase("1", "24", "124")]
        [TestCase("0", "2", "2")]
        [TestCase("3", "r   776", "3")]
        [TestCase("9", "2*", "9")]
        [TestCase("6", "sdfghjkl", "6")]
        [TestCase("rtrtrt", "2", "0")]
        [TestCase("7", "+", "7+")]

        [TestCase("*100", "2", "0")]
        [TestCase("/51", "-", "0")]
        [TestCase("+", "2", "0")]
        [TestCase("-11", "24", "-1124")]

        [TestCase("5", "++", "5+")]
        [TestCase("6", "+-", "6+")]
        [TestCase("23", "fkdkd+", "23")]

        [TestCase("2", "*sdfsdf", "2*")]
        [TestCase("2", "/jjjj", "2/")]
        [TestCase("2", "+iiii", "2+")]
        [TestCase("2", "-pppp", "2-")]

        [TestCase("2", "/", "2/")]
        [TestCase("7", "*/*+", "7*")]

        [TestCase("", "5", "5")]
        [TestCase("-1", "-", "-1-")]
        [TestCase("-1", "-5", "-1-5")]

        [TestCase("-1", "-ghj", "-1-")]
        [TestCase("-ghjk", "-24", "0")]
        [TestCase("*bbbk", "-2", "0")]

        public void ParseInputTest(string prevoiusInput, string currentInput, string expectedResult)
        {
            //Arrange
            
            //Act
            var actualResult = CalculatorService.ParseInput(prevoiusInput, currentInput);
                                
            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

    }
}
