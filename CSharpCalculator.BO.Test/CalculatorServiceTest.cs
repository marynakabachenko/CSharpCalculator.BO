using NUnit.Framework;

namespace CSharpCalculator.BO.Test
{
    [TestFixture] //contains unit test, all in [] are attribute. Attribute is a marker
    public class CalculatorServiceTest
    {
        [TestCase("1", "3", "13")]
        [TestCase("0", "2", "2")]
        [TestCase("0", "0", "0")]
        [TestCase("0", "-", "0-")]
        
        [TestCase("0", "c", "0")]
        [TestCase("7", "/", "7/")]

        [TestCase("2*100", "2", "2*1002")]
        [TestCase("5/51", "0", "5/510")]
        [TestCase("7*0", "0", "7*0")]
        [TestCase("7*0", "7", "7*7")]
        [TestCase("156-0", "5", "156-5")]

        [TestCase("156+", "-", "156-")]
        
        [TestCase("156-", "3", "156-3")]
        [TestCase("156-3", "=", "153")]
        [TestCase("153-3", "=", "150")]
        [TestCase("2003-3", "-", "2000-")]
        [TestCase("150*2", "+", "300+")]
        
        [TestCase("-1", "-", "-1-")]
        [TestCase("-1-", "5", "-1-5")]

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
