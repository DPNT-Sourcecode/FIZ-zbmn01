﻿using BeFaster.Runner.Exceptions;
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

        private static bool IsFake(int number)
        {
            return number % 2 == 1;
        }

        private static bool IsDeluxe(int number)
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
            var list = new List<string>();
            if(IsFizz(number))
            {
                list.Add("fizz");
            }
            if(IsBuzz(number))
            {
                list.Add("buzz");
            }
            if (IsDeluxe(number))
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



