/*
6. Write a program in C# Sharp to print all unique elements in an array. Go to the editor
Test Data :
Input the number of elements to be stored in the array :3
Input 3 elements in the array :
element - 0 : 1
element - 1 : 5
element - 2 : 1
Expected Output :
The unique elements found in the array are :
5
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j;
            int duplicate = 0;
            Console.WriteLine("Please enter the number of values in the array");
            n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
           

            for ( i = 0; i < n; i++)
            {
                array[i]= Convert.ToInt32(Console.ReadLine());   
            }
            Console.WriteLine("Array with unique values has these elements: ");
            
            for (j = 0; j < n; j++)
            {

                for (i = 0; i < n; i++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        duplicate++;
                        break;
                    }
                    
                }
                if (duplicate == 0)
                {
                    Console.Write($" {array[j]} ");
                }
                duplicate = 0;
            }
        }
    }
}
