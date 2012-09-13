using System.Linq;

namespace SpecFlowTutorial
{
    /// <summary>
    /// Checks whether a string is a palindrome
    /// </summary>
    public class PalindromeChecker
    {
        public bool Check(string input)
        {
            string reversedInput = new string(input.ToCharArray().Reverse().ToArray());

            return input == reversedInput;
        }
    }
}
