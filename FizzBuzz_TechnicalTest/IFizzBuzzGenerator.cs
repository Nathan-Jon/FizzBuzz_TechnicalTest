using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_TechnicalTest
{
    public interface IFizzBuzzGenerator
    {
        List<string> GetFizzBuzz(IEnumerable<int> values);
    }
}
