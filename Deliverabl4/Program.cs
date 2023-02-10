using System;
using System.Linq;


namespace Deliverabl4;

class Program
{
    static void Main(string[] args)
    {
        /*
         * You can store multiple variables of the same data type
         * Declare an array by specifying elements
         * Variables are ordered and has an index beginning
         * C# arrays are objects of the base type System.Array
         */

        //Declare a single dimesnion array
        int[] numbers = { 1, 2, 3, 4, 5, };
        int[] numbers2 = new int[5] { 6, 7, 8, 9, 10 };

        //Create an array of strings
        string[] cars = { "Mercedes", "Audi", "Ford", "Honda" };
        Console.WriteLine(cars[0]);

        cars[0] = "Kia";
        Console.WriteLine(cars[0]);

        //Declare multidemnsioal array
        int[,,] multiDimensionalArray = { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 1, 2, 3 }, { 4, 5, 6 } } };
        multiDimensionalArray[0, 0, 0] = 5;
        Console.WriteLine(multiDimensionalArray[0, 0, 0]);

        //Properties
        int len = numbers.Length;
        int Dim = multiDimensionalArray.Rank;

        Console.WriteLine("Number's length is: " + len.ToString());
        Console.WriteLine("MultiDimesnionalArray dimensinos are: " + Dim.ToString());

        //Loop
        Console.WriteLine("For Loop");
        for (int i=0; i<cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
        Console.WriteLine("Foreach");

        foreach(string element in cars)
        {
            Console.WriteLine(element);
        }

        int idx = 0;
        foreach(int number in numbers)
        {
            numbers[idx]=2*number+1;
            Console.WriteLine(numbers[idx]);
            idx++;
        }
        //Sort an array
        Console.WriteLine("");
        Console.WriteLine("Sorting");
        int[] myNumbers = { 5, 2, 8, 9 };
     
        foreach(int number in myNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("The max value in myNumbers is " + myNumbers.Max().ToString());
        Console.WriteLine("The sum value in myNumbers is " + myNumbers.Max().ToString());
    }
}

