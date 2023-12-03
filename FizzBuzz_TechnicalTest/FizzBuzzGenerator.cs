using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz_TechnicalTest.ExtensionMethods;

namespace FizzBuzz_TechnicalTest
{
    public class FizzBuzzGenerator : IFizzBuzzGenerator
    {
        public List<string> GetFizzBuzz(IEnumerable<int> values)
        {
            int fizzDividerValue = 3;
            int buzzDividerValue = 5;

            List<string> results = new List<string>();

            if (!values.Any())
                return results;

            foreach (int value in values)
            {
                string result = "";

                if (!HasRemainder(value, fizzDividerValue))
                    result += "Fizz";

                if (!HasRemainder(value, buzzDividerValue))
                    result += "Buzz";

                if (result.IsNullOrEmpty())
                    result = value.ToString();

                results.Add(result);
            }

            return results;
        }

        public bool HasRemainder(int value, int dividingValue)
        {
            if (dividingValue == 0)
                return true;

            return (value % dividingValue) >= 1;
        }
    }
}
