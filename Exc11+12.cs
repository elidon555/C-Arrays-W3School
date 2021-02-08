/*
11. Write a program in C# Sharp to sort elements of array in ascending/descending order. Go to the editor
Test Data :
Input the size of array : 5
Input 5 elements in the array :
element - 0 : 2
element - 1 : 7
element - 2 : 4
element - 3 : 5
element - 4 : 9
Expected Output :
Elements of array in sorted ascending order:
2 4 5 7 9
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, j;
            int even = 0;
            int odd = 0;
            int temp = 0;




            Console.WriteLine("Please enter the array size for array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];


            Console.WriteLine("Please enter array elements");

            for (i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Even elements are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write($" {array[i]}");
            }

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n - 1; j++)
                {
                    if (array[j] > array[j + 1]) //Change arrow for descending
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;


                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Sorted elements are: ");
            for (i = 0; i < n; i++)
            {
                Console.Write($" {array[i]}");
            }

        }
    }
}
