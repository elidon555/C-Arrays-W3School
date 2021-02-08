/*
8. Write a program in C# Sharp to count the frequency of each element of an array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 25
element - 1 : 12
element - 2 : 43
Expected Output :
Frequency of all elements of array :
25 occurs 1 times
12 occurs 1 times
43 occurs 1 times
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j,n;
            int frequency = 0;
            Console.WriteLine("Please enter the array size for array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];

            Console.WriteLine("Please enter array elements");

            for (i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        frequency++;
                        
                    }
                    
                }

                Console.WriteLine($" {array[i]} occours {frequency} times.");
                frequency = 0;
            }

        }
    }
}
