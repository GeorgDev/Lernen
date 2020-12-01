using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Lernen
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        double number;

        [Given(@"is pi")]
        public void GivenIsPi()
        {
            number = Math.PI;
        }
        
        [When(@"Sinus is applied")]
        public void WhenSinusIsApplied()
        {
            number = Math.Sin(number);
        }
        
        [When(@"Cosinus is applied")]
        public void WhenCosinusIsApplied()
        {
            number = Math.Cos(number);
        }
        
        [When(@"Tangens is applied")]
        public void WhenTangensIsApplied()
        {
            number = Math.Tan(number);
        }
        
        [Then(@"the result is (.*)")]
        public void ThenTheResultIs(int p0)
        {
            double expected = p0;
            double actual = Math.Round(number);
            Assert.Equal(expected, actual);

        }
    }
}
