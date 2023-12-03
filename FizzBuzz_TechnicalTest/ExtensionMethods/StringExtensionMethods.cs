using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz_TechnicalTest.ExtensionMethods
{
    public static class StringExtensionMethods
    {
        public static bool IsNullOrEmpty(this string? value)
        {
            if (value == null)
                return true;

            if (!value.Any())
                return true;

            return false;
        }
    }
}
