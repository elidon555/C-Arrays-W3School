/*
Write a program in C# Sharp to copy the elements one array into another array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 15
element - 1 : 10
element - 2 : 12
Expected Output:
The elements stored in the first array are :
15 10 12
The elements copied into the second array are :
15 10 12
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            int sum = 0;
            Console.WriteLine("Please enter the number of values in the array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            int[] arraycopy = new int[n];

            for ( i = 0; i < n; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
                arraycopy[i] = array[i];
            }
            Console.WriteLine("Copied array is: ");

            for (i = 0; i < n; i++)
            {
                Console.Write($" {arraycopy[i]} ");
            }
          
        }
    }
}
