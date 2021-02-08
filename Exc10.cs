/*
10. Write a programin C# Sharp to separate odd and even integers in separate arrays. Go to the editor
Test Data :
Input the number of elements to be stored in the array :5
Input 5 elements in the array :
element - 0 : 25
element - 1 : 47
element - 2 : 42
element - 3 : 56
element - 4 : 32
Expected Output:
The Even elements are:
42 56 32
The Odd elements are :
25 47
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            int even = 0;
            int odd = 0;



            Console.WriteLine("Please enter the array size for array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            int[] arrayOdd = new int[n];
            int[] arrayEven = new int[n];
            Console.WriteLine("Please enter array elements");

            for (i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                if (array[i] % 2 == 0)
                {
                    arrayEven[even] = array[i];
                    even++;
                }
                if (array[i] % 2 == 1)
                {
                    arrayOdd[even] = array[i];
                    odd++;
                }
            }
            Console.WriteLine("Even elements are: ");
            for (i = 0; i < n - odd; i++)
            {
                Console.Write($" {arrayEven[i]}");
            }

            Console.WriteLine();

            Console.WriteLine("Odd elements are: ");
            for (i = 0; i < n - even; i++)
            {
                Console.Write($" {arrayOdd[i]}");
            }
        }
    }
}
