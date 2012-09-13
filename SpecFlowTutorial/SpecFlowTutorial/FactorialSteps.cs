using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowTutorial
{
    [Binding]
    public class FactorialSteps
    {
        [Given(@"I have an input of (\d+)")]
        public void GivenIHaveAnInputOf(string input)
        {
            int inputNumeric = int.Parse(input);
            ScenarioContext.Current.Add("INPUT", inputNumeric);
        }

        [When(@"I calculate the factorial of the input")]
        public void WhenICalculateTheFactorialOfTheInput()
        {
            if (ScenarioContext.Current.ContainsKey("INPUT"))
            {
                int input = ScenarioContext.Current.Get<int>("INPUT");
                var factorialCalculator = new FactorialCalculator();
                int result = factorialCalculator.GetFactorial(input);

                ScenarioContext.Current.Add("RESULT", result);
            }
            else
                Assert.Fail("Input not found");
        }

        [Then(@"the result should be (\d+)")]
        public void ThenTheResultShouldBe(string targetResult)
        {
            if (ScenarioContext.Current.ContainsKey("RESULT"))
            {
                int actualResult = ScenarioContext.Current.Get<int>("RESULT");
                Assert.That(actualResult, Is.EqualTo(int.Parse(targetResult)));
            }
            else
                Assert.Fail("Result not found.");
        }
    }
}
