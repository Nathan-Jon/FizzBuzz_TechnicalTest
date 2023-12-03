using FizzBuzz_TechnicalTest.ExtensionMethods;

namespace FizzBuzz_TechnicalTest
{
    public class FizzBuzzGenerator : IFizzBuzzGenerator
    {
        private int FizzDividerValue { get; set; }
        private int BuzzDividerValue { get; set; }

        public FizzBuzzGenerator(int fizzDividerValue, int buzzDividerValue)
        {
            FizzDividerValue = fizzDividerValue;
            BuzzDividerValue = buzzDividerValue;
        }

        public IEnumerable<int> GetValuesToInterpret(int StartNum, int stopNum)
        {
            if (StartNum > stopNum)
            {
                Console.WriteLine($"Cannot Generate a list of values with a {nameof(StartNum)} greater than the {nameof(stopNum)}");
                return Enumerable.Empty<int>();

            }
            return Enumerable.Range(StartNum, stopNum);
        }

        public List<string> GetFizzBuzzFromValues(IEnumerable<int> values)
        {
            return values.Select(GetFizzBuzzFromValue).ToList();
        }

        public string GetFizzBuzzFromValue(int value)
        {
            if (value == 0)
                return value.ToString();

            string result = "";

            if (!value.HasRemainder(FizzDividerValue))
                result += "Fizz";

            if (!value.HasRemainder(BuzzDividerValue))
                result += "Buzz";

            if (result.IsNullOrEmpty())
                result = value.ToString();

            return result;
        }
    }
}
