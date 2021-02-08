/*
9. Write a program in C# Sharp to find maximum and minimum element in an array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 45
element - 1 : 25
element - 2 : 21
Expected Output :
Maximum element is : 45
Minimum element is : 21
Click me to see the solution
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int min = 0;
            int max = 0;

            Console.WriteLine("Please enter the array size for array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Please enter array elements");

            for (i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Find max
            max = array[0];
            min = array[0];
            
            for (i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    
                }
                if (array[i] < min)
                {
                    min = array[i];

                }
            }

            Console.WriteLine($"Max element is: {max}\nMin element is: {min} ");
        }
    }
}
