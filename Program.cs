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
            Console.WriteLine("Task 2: finding the index of max value in text with probability of spaces before text starts.");
            Task_2();
            Console.WriteLine("Task 3: finding the amount of pages in the biggest book.");
            Task_3();
            Console.WriteLine("Task 4: finding the index of the max value (if more than one, find the index of the first one and last one).");
            Task_4();
        }

        //Task 1: taking user's text input and finding the sum of digits in it, finding the max digit in text
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

        // find the index of max value in text with probability of spaces before text starts
        static void Task_2()
        {
            // defining max as int value
            int max = int.MinValue;
            int index = 0;
            //defining text beginning as bool value to control whether it's beginning of the text, so if there are spaces after first non-space chararter - they will count as index
            bool text_begin = false;
            //taking user's input
            Console.Write("Enter a text: ");
            char[] input = Console.ReadLine().ToCharArray();
            //running through each characther in text
            foreach (char c in input)
            {
                // checking whether it's a space before text starts
                if ((c == ' ') && (text_begin == false))
                {
                    // if so decremating index
                    index--;
                }
                // checking whether it a text start
                else if ((c != ' ') && (text_begin == false))
                {
                    // if so - declare that text has begun 
                    text_begin = true;
                }
                //defining whether character is digit
                if (char.IsDigit(c))
                {
                    //if so - converting int to char
                    int digit = c - '0';
                    //defining whether max value can be changed
                    max = (digit > max) ? digit : max;
                }
            }
            // find the first index that fits max found value
            index += Array.IndexOf(input, Convert.ToChar(max.ToString()));
            //outputing index result
            Console.WriteLine($"Index of max digit: {index} \n");
        }

        // find the amount of pages in the biggest book
        static void Task_3()
        {
            // initializing a random with a seed based on the current time, so we have different arrays every time
            Random rand = new Random();
            // creating an array for amount of pages in 100 books
            int[] pages = new int[100]; 

            for (int i = 0; i < pages.Length; i++)
            {
                // generating random amount of pages for every book
                pages[i] = rand.Next(50, 1001); 
            }

            //outputing max page result
            Console.WriteLine($"Amount of the pages in the biggest book: {pages.Max()} \n");
        }

        //find the index of the max value (if more than one, find the index of the first one and last one)
        static void Task_4()
        {
            // defining max as int value
            int max = int.MinValue;
            // initializing a random with a seed based on the current time, so we have different arrays every time
            Random rand = new Random();
            // creating an array for max speed of 40 cars
            int[] speeds = new int[40];

            for (int i = 0; i < speeds.Length; i++)
            {
                // generating random max speed for every car
                speeds[i] = rand.Next(200, 400);
            }

            // finding the max value in array
            foreach (int s in speeds)
            {
                max = (s > max) ? s : max;
            }

            // checkung whether there are more than one max value and outputing indexes in the needed form
            if (speeds.Count(x => x == max) != 1)
            {
                Console.WriteLine("There are more than one max value.\n");
                //outputing index of the first max value
                Console.WriteLine($"Index of the first max value: {Array.IndexOf(speeds, max)} ");
                //outputing index of the last max value
                Console.WriteLine($"Index of the last max value: { Array.LastIndexOf(speeds, max)} \n");
            }
            else
            {
                Console.WriteLine("There are only one max value.");
                //outputing index of the max value
                Console.WriteLine($"Index of the max value: {Array.IndexOf(speeds, max)} \n");
            }
        }
    }
}
