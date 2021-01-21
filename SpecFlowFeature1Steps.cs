using System;
using TechTalk.SpecFlow;
using Xunit;

namespace wi19b101_rqebb
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number;
        double actual;

        [Given(@"\[SIN] the first number is (.*)")]
        public void GivenSINTheFirstNumberIs(int p0)
        {
            number = p0;
        }
        
        [When(@"\[SIN] the Sinus calculation is performed")]
        public void WhenSINTheSinusCalculationIsPerformed()
        {
            actual = Calculator.GetSin(number);
        }
        
        [Then(@"\[SIN] the result should be (.*)")]
        public void ThenSINTheResultShouldBe(Decimal p0)
        {
            var exptected = (double) p0;
            Assert.Equal(exptected, actual, 5);
        }
    }
}
