using System;
using System.Collections.Generic;
using System.Collections;

namespace NumberInReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {

            // creating different variables
            int inputAmount;
            int i;
            Stack numbers = new Stack();

            Console.WriteLine("Now i will show you how i can reverse a serial of numbers");
            Console.WriteLine("How many numbers should we work with?");
            inputAmount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type {0} numbers:\n", inputAmount);
            for (i = 0; i<inputAmount; i++)
            {
                Console.WriteLine("Element - {0}: ", i+1);
                numbers.Push(Console.ReadLine());
            }

            Console.WriteLine("The numbers in reversed order are the following");
            while (numbers.Count > 0)
            {
                Console.WriteLine(numbers.Pop() + " ");
            }

        }
    }
}
