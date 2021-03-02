using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumOfMultiples = 0;

            for (int counter = 1; counter < 1000; counter++)
            {
                if (counter % 3 == 0 || counter % 5 == 0)
                {
                    sumOfMultiples += counter;
                }
            }

            Console.WriteLine($"The sum of multiples is {sumOfMultiples}");
        }
    }
}
