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

        private static bool IsFizz(int number, out bool isDeluxe)
        {
            return IsSpecial(number, 3, out isDeluxe);
        }

        private static bool IsBuzz(int number, out bool isDeluxe)
        {
            return IsSpecial(number, 5, out isDeluxe);
        }

        private static bool IsSpecial(int number, int factor, out bool isDeluxe)
        {
            bool divides = number % factor == 0;
            bool contains = $"{number}".Contains($"{factor}");
            isDeluxe = divides && contains;
            return divides || contains;
        }

        private static bool IsFake(int number)
        {
            return number % 2 == 1;
        }

        private static bool IsOldDeluxe(int number)
        {
            if(number < 10)
            {
                return false;
            }
            var asString = number.ToString();
            for(int i = 1; i < asString.Length; i++)
            {
                if(asString[i] != asString[i-1])
                {
                    return false;
                }
            }
            return true;
        }

        private static List<string> GetSpecials(int number)
        {
            bool isDeluxe3, isDeluxe5;
            var list = new List<string>();
            if(IsFizz(number, out isDeluxe3))
            {
                list.Add("fizz");
            }
            if(IsBuzz(number, out isDeluxe5))
            {
                list.Add("buzz");
            }
            if (isDeluxe3 || isDeluxe5)
            {
                if (IsFake(number))
                {
                    list.Add("fake");
                }
                list.Add("deluxe");
            }
            return list;
        }
    }
}




