using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Follow the instructions provided in each comment below to complete the exercise.
            // Use the example given to guide your implementation.

            //Create a List called "numbers" - DONE!
            List<int> numbers = new List<int>();  //DO NOT ERASE THIS! You will use this in the exercise.
            
            //-----START HERE------------------------------------------

            int num = 0;

            do
            {
                num++;
                numbers.Add(num);
            } while (num < 100);

            
            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }

            
            Console.WriteLine("Increase:");

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
             

            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            for (int i = 199; i <= numbers.Count && i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
