using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            if (IsFizz(number) && IsBuzz(number))
            {
                return "fizz buzz";
            }
            else if (IsFizz(number))
            {
                return "fizz";
            }
            else if (IsBuzz(number))
            {
                return "buzz";
            }
            else
            {
                return number.ToString();
            }
        }

        private static bool IsFizz(int number)
        {
            return number % 3 == 0;
        }

        private static bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }
    }
}


