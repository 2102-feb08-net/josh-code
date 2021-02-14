using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 6;

            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is less than 10.");
            }
            
            int c = 4;

            // if..else with "and"
            if((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("And the first number is equal to the second.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10.");
                Console.WriteLine("Or the first number is not equal to the second number.");
            }

            // if..else with "or"
            if((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10.");
                Console.WriteLine("And the first number is equal to the second.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10.");
                Console.WriteLine("Or the first number is not equal to the second number.");
            }
        }

        static void ExploreLoop()
        {
            int counter = 0;

            // while loop
            while (counter < 10)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }

            // reset counter
            counter = 0;

            // do..while loop
            do
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }while (counter < 10);

            // for loop
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"The index is at {index}");
            }

            // nested loops
            // one generates row, one generates column
            for (int row = 0; row < 11; row++)
            {
                for (int col = 0; col < 11; col++)
                {
                    Console.WriteLine($"The cell is at ({row} , {col})");
                }
            }
        }
        static void Main(string[] args)
        {
            ExploreIf();

            ExploreLoop();
        }
    }
}
