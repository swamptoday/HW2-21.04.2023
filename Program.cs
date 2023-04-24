using System;
using System.Linq;

namespace HW2_21._04._2023
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: finding the sum of digits in user's input and finding the max digit.");
            Task_1();
        }

        //take user's text input and finding the sum of digits in it, finding the max digit in text
        static void Task_1()
        {
            // defining sum and max as int values
            int sum = 0;
            int max = int.MinValue;
            //taking user's input
            Console.Write("Enter a text: ");
            char[] input = Console.ReadLine().ToCharArray();
            //running through each characther in text
            foreach (char c in input)
            {
                //defining whether character is digit
                if (char.IsDigit(c))
                {
                    //if so - converting int to char
                    int digit = c - '0';
                    //adding values to sum
                    sum += digit;
                    //defining whether max value can be changed
                    max = (digit > max) ? digit : max;
                }
            }
            //outputing sum result
            Console.WriteLine($"Sum of digits: {sum}");

            //outputing max value result
            Console.WriteLine($"Max digit: {max} \n");

        }
    }
}
