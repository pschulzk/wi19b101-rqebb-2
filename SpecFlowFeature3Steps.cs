using System;
using TechTalk.SpecFlow;
using Xunit;

namespace wi19b101_rqebb
{
    [Binding]
    public class SpecFlowFeature3Steps
    {
        double number;
        double actual;

        [Given(@"\[TAN] the first number is (.*)")]
        public void GivenTANTheFirstNumberIs(int p0)
        {
            number = p0;
        }
        
        [When(@"\[TAN] the Cosinus calculation is performed")]
        public void WhenTANTheCosinusCalculationIsPerformed()
        {
            actual = Calculator.GetTan(number);
        }
        
        [Then(@"\[TAN] the result should be (.*)")]
        public void ThenTANTheResultShouldBe(Decimal p0)
        {
            var exptected = (double)p0;
            Assert.Equal(exptected, actual, 5);
        }
    }
}
