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
