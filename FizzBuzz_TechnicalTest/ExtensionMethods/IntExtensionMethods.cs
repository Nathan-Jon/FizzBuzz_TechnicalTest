using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_TechnicalTest.ExtensionMethods
{
    public static class IntExtensionMethods
    {
        public static bool HasRemainder(this int value, int dividingNumber)
        {
            if (dividingNumber == 0)
                return true;

            return (value % dividingNumber) >= 1;
        }
    }
}
