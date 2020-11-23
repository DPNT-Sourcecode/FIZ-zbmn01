using BeFaster.Runner.Exceptions;
using System.Collections.Generic;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var specials = GetSpecials(number);
            if(specials.Count > 0)
            {
                return string.Join(" ", specials.ToArray());
            }
            else
            {
                return number.ToString();
            }
        }

        private static bool IsFizz(int number)
        {
            return number % 3 == 0 || $"{number}".Contains("3");
        }

        private static bool IsBuzz(int number)
        {
            return number % 5 == 0 || $"{number}".Contains("5");
        }

        private static List<string> GetSpecials(int number)
        {
            var list = new List<string>();
            if(IsFizz(number))
            {
                list.Add("fizz");
            }
            if(IsBuzz(number))
            {
                list.Add("buzz");
            }
            return list;
        }
    }
}
