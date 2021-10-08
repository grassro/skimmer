namespace Skimmer.Library
{
    public static class Divisible
    {
        public static string DivisibleNumbers(int number)
        {
            number = number + 1;

            if (number % 3 == 0 && number % 5 == 0)
            {
                 return $"{number} Fizz Buzz";
            }
            else if (number % 3 == 0)
            {
                return  $"{number} Fizz";
            }
            else if (number % 5 == 0)
            {
                return $"{number} Buzz";
            }
            else
            {
                return number.ToString();
            }
        }
    }
}
