/*
3. Write a program in C# Sharp to find the sum of all elements of the array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 2
element - 1 : 5
element - 2 : 8
Expected Output :
Sum of all elements stored in the array is : 15
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

            for ( i = 0; i < n; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());
                sum += array[i];
            }

            Console.WriteLine($"Array sum is: {sum} ");
          
        }
    }
}
