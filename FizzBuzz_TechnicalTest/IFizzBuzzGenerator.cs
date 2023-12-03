using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_TechnicalTest
{
    public interface IFizzBuzzGenerator
    {
       List<string> GetFizzBuzzFromValues(IEnumerable<int> values);
       IEnumerable<int> GetValuesToInterpret(int StartNum, int stopNum);
    }
}
