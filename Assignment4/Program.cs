/*
 Author: Pubuduni Karalliyadde
Date; 2/9/2023
This application demonstrates the use of arrays
based on user input
*/

using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer between 5 and 20: ");

            int input = int.Parse(Console.ReadLine());

            if (input >= 5 && input <= 20)
            {
                int[] even = new int[input];
                int[] odd = new int[input];
                int[] fibonacci = new int[input];

                //Initialize the sequence
                fibonacci[0] = 0;
                fibonacci[1] = 1;

                for (int i = 0; i < input; i++)
                {
                    even[1] = 2 + 1;

                    odd[i] = 2 * 1 + 1;

                    if (i >= 2)
                    {
                        fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                    }

                }

                foreach (int number in even)
                {
                    Console.WriteLine(number);
                }


                Console.WriteLine("");
                Console.WriteLine("Odd");
                foreach (int number in odd)
                {
                    Console.WriteLine(number);
                }

                Console.WriteLine("");
                Console.WriteLine("Fibonacci");
                foreach (int number in fibonacci)
                {
                    Console.WriteLine(number);
                }

                for (int i = 0; i < input; i++)
                {
                    Console.WriteLine("Fibonacci(" + i + ") = " + fibonacci[i]);
                }
            }
        }
    }
}

            
    


