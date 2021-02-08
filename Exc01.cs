/*
1. Write a program in C# to store elements in an array and print it. Go to the editor
Test Data :
Input 10 elements in the array :
element - 0 : 1
element - 1 : 1
element - 2 : 2
.......
Expected Output :
Elements in array are: 1 1 2 3 4 5 6 7 8 9
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare array and i for loop
            int[] array = new int[10];
            int i;

            //make loop for input
            for (i = 0; i < 10; i++)
            {
                Console.Write("Please enter element number {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();
            //loop to print
            for (i = 0; i < 10; i++)
            {
                Console.Write($" {array[i]} ");
            }
        }
    }
}
