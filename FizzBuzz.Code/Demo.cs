using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Code
{
    public class Demo
    {
        #region Private Helper Methods

        private bool IsNumberMultipleOfThree(int number) {
            return number % 3 == 0;
        }

        private bool IsNumberMultipleOfFive(int number) {
            return number % 5 == 0;
        }

        private bool IsNumberMultipleOfThreeAndFive(int number) {
            return IsNumberMultipleOfThree(number) & IsNumberMultipleOfFive(number);
        }
        #endregion

        private IEnumerable<string> GetCollection(int from, int to)
        {
            for (var i = from; i <= to; i++) {
                if (IsNumberMultipleOfThreeAndFive(i))
                    yield return "fizzbuzz";
                else if (IsNumberMultipleOfFive(i))
                    yield return "buzz";
                else if (IsNumberMultipleOfThree(i))
                    yield return "fizz";
                else
                    yield return i.ToString();
            }
        }

        public string Print(int from = 1, int to = 100)
        {
            return string.Join(" ", GetCollection(from, to).ToArray());
        }
    }
}
