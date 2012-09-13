namespace SpecFlowTutorial
{
    public class FactorialCalculator
    {
        public int GetFactorial(int input)
        {
            int result = 1;

            for (int i = 1; i <= input; i++)
                result *= i;

            return result;
        }
    }
}
