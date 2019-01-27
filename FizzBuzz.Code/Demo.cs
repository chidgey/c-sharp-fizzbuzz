using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Code
{
    public class Demo
    {
        private IEnumerable<string> fizzBuzzSequence;

        #region Private Helper Methods

        private bool IsNumberMultipleOfThree(int number) => number % 3 == 0;

        private bool IsNumberMultipleOfFive(int number) {
            return number % 5 == 0;
        }

        private bool IsNumberMultipleOfThreeAndFive(int number) {
            return IsNumberMultipleOfThree(number) & IsNumberMultipleOfFive(number);
        }
        
        private bool HasNumberGotThreeInIt(int number) {
            return number.ToString().Contains("3");
        }

        private IEnumerable<string> GetCollection(int from, int to)
        {
            for (var i = from; i <= to; i++) {
                if (HasNumberGotThreeInIt(i))
                    yield return "lucky";
                else if (IsNumberMultipleOfThreeAndFive(i))
                    yield return "fizzbuzz";
                else if (IsNumberMultipleOfFive(i))
                    yield return "buzz";
                else if (IsNumberMultipleOfThree(i))
                    yield return "fizz";
                else
                    yield return i.ToString();
            }
        }

        private string GetCountOf(string searchTerm) {
            var count = fizzBuzzSequence.Count(x => x.Equals(searchTerm));
            return string.Concat(searchTerm, ": ", count);
        }

        private string GetCountOfIntegers() {
            var count = fizzBuzzSequence.Count(x => Char.IsNumber(x, 0));
            return string.Concat("integer: ", count);
        }
        #endregion

        public string Print(int from = 1, int to = 100)
        {
            fizzBuzzSequence =  GetCollection(from, to);
            var result = string.Join(" ", fizzBuzzSequence);
            result += string.Join(" ", "", GetCountOf("fizz"), GetCountOf("buzz"), 
                GetCountOf("fizzbuzz"), GetCountOf("lucky"), GetCountOfIntegers());
            return result;
        }
    }
}
