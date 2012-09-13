using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowTutorial
{
    [Binding]
    public class PalindromeSteps
    {
        [Given("the input word \"(.+)\"")]
        public void GivenTheInputWord(string word)
        {
            ScenarioContext.Current.Add("INPUT_WORD", word);
        }

        [When(@"I ask whether the input word is a palindrome")]
        public void WhenIAskWhetherTheInputWordIsAPalindrome()
        {
            if (ScenarioContext.Current.ContainsKey("INPUT_WORD"))
            {
                string inputWord = ScenarioContext.Current.Get<string>("INPUT_WORD");

                PalindromeChecker palindromeChecker = new PalindromeChecker();
                string result = palindromeChecker.Check(inputWord) ? "Yes" : "No";

                ScenarioContext.Current.Add("RESULT", result);
            }
            else
                Assert.Fail("Input word not found.");
        }

        [Then("I should get the response \"(.+)\"")]
        public void ThenIShouldGetTheResponse(string targetResponse)
        {
            if (ScenarioContext.Current.ContainsKey("RESULT"))
            {
                string actualResponse = ScenarioContext.Current.Get<string>("RESULT");

                Assert.That(actualResponse, Is.EqualTo(targetResponse));
            }
            else
                Assert.Fail("Result not found.");
        }
    }
}
