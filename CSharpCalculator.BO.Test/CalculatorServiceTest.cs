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
        [TestCase("1", "2", "13")] // says that below is test
        [TestCase("1", "3", "13")]
        [TestCase("1", "24", "124")]
        [TestCase("0", "2", "02")]
        public void ParseInputTest(string prevoiusInput, string currentInput, string expectedResult)
        {
            //arrange
            //var expectedResult = "13";

            //Act
            var actualResult = CalculatorService.ParseInput(prevoiusInput, currentInput);
                                
            //Assert
            //Assert.AreEqual(expectedResult, actualResult);
           Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

    }
}
