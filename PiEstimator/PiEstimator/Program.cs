using System;
using System.Data;

namespace PiEstimator
{
    class Program
    {
        static void Main(string[] args)
        {
            long n;
            
            Console.WriteLine("Pi Estimator");
            Console.WriteLine("================================================");

            n = GetNumber("Enter number of iterations (n): ");

            double pi = EstimatePi(n);
            double diff = Math.Abs(pi - Math.PI);

            Console.WriteLine();
            Console.WriteLine($"Pi (estimate): {pi}, Pi (system): {Math.PI}, Difference: {diff}");
        }

        static double EstimatePi(long n)
        {
            Random rand = new Random(System.Environment.TickCount);
            double pi = 0.0;
            double xAxis = 0.0;
            double yAxis = 0.0;
            for (int i = 0; i < n; i++)
            {
                xAxis = rand.NextDouble();
                yAxis = rand.NextDouble();
                if (Math.Sqrt((xAxis * xAxis) + (yAxis * yAxis)) <= 1)
                {
                    pi += 1;
                }
            }
            // TODO: Calculate Pi
            //Note to self: nextDouble returns a number [0,1)
            return pi;
        }

        static long GetNumber(string prompt)
        {
            long output;

            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (Int64.TryParse(input, out output))
                {
                    return output;
                }
            }
        }
    }
}