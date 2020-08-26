using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            Console.WriteLine("blah");
            //Create a List called "numbers" - DONE
            var numbers = new List<int>();

            //Create a variable of type int and initialize the variable with a value of 0
            var firstNumber = 0;


            // Create a do-while loop
            // Increment your variable by 1
            // Then add your variable to "numbers"
            // While your variable is less than 100

            do
            {
                firstNumber++;
                numbers.Add(firstNumber);

            } while (firstNumber<100);


            // Create a while loop
            // While your variable is less than 200
                // Increment your variable by 1
                // Then add your variable to "numbers"
            while(firstNumber < 200)
            {
                numbers.Add(firstNumber);
                firstNumber++;
            }

            Console.WriteLine("Increase:");

            // Create a foreach loop
            // Write your variable to the console
            foreach(var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            Console.WriteLine("Decrease:");

            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            for(int i = 199; i <=numbers.Count && i>=0;i--)
            {
                Console.WriteLine($"{numbers[i]}");
                // Write to the console "numbers" at index i
            }
        }
    }
}
