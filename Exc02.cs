/*
2. Write a program in C# Sharp to read n number of values in an array and display it in reverse order. Go to the editor
Test Data :
Input the number of elements to store in the array :3
Input 3 number of elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 7
Expected Output:
The values store into the array are:
2 5 7
The values store into the array in reverse are :
7 5 2
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.WriteLine("Please enter the number of values in the array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[10];

            for ( i = 0; i < n; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array before reverse is: ");
            Console.WriteLine();
            for ( i = 0; i < n; i++)
            {
                Console.Write($" {array[i]} ");
            }
            Console.WriteLine("Array after reverse is: ");
            Console.WriteLine();
            for (i = n-1 ; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
