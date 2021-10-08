using Skimmer.Library;
using System;

namespace Skimmer
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.WriteLine(Divisible.DivisibleNumbers(i));
            }
        }
    }
}
