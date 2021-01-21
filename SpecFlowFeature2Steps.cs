using System;
using TechTalk.SpecFlow;
using Xunit;

namespace wi19b101_rqebb
{
    [Binding]
    public class SpecFlowFeature2Steps
    {
        double number;
        double actual;

        [Given(@"\[COS] the first number is (.*)")]
        public void GivenCOSTheFirstNumberIs(int p0)
        {
            number = p0;
        }
        
        [When(@"\[COS] the Cosinus calculation is performed")]
        public void WhenCOSTheCosinusCalculationIsPerformed()
        {
            actual = Calculator.GetCos(number);
        }
        
        [Then(@"\[COS] the result should be (.*)")]
        public void ThenCOSTheResultShouldBe(Decimal p0)
        {
            var exptected = (double)p0;
            Assert.Equal(exptected, actual, 5);
        }
    }
}
