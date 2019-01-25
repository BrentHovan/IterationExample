using System;

namespace IterationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter an integer value between 1 and 100. ");
                string input;
                int n;
                input = Console.ReadLine();
                n = int.Parse(input);

                if (n > 0 && n < 101)
                {
                    for (int i = 1; i < n + 1; i++)
                    {
                        Console.WriteLine("You have entered " + n + ". This is the current integer value in the loop: " + i + ".");
                    }
                    Console.ReadKey();
                }
                else
                {
                    Console.Write("Invalid number entered. Your penchant for noncompliance is noted, human.");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Invalid input. Your penchant for noncompliance is noted, human.");
                Console.ReadKey();
            }
        }
    }
}
