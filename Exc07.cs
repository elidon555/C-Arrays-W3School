/*
7. Write a program in C# Sharp to merge two arrays of same size sorted in ascending order. Go to the editor
Test Data :
Input the number of elements to be stored in the first array :3
Input 3 elements in the array :
element - 0 : 1
element - 1 : 2
element - 2 : 3
Input the number of elements to be stored in the second array :3
Input 3 elements in the array:
element - 0 : 1
element - 1 : 2
element - 2 : 3
Expected Output:
The merged array in ascending order is :
1 1 2 2 3 3
*/

using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,m,i,j;
            int temp = 0;

            Console.WriteLine("Please enter the array size for array1");
            n = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[n];

            Console.WriteLine("Please enter array 1 elements");

            for (i = 0; i < n; i++)
            {
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }




            Console.WriteLine("Please enter the array size for array2");
            m = Convert.ToInt32(Console.ReadLine());
            int[] array2 = new int[m];

            Console.WriteLine("Please enter array 2 elements");
            for (i = 0; i < m; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }
            int k = n + m;
            int[] arrayMerge = new int[k];
            //Merge the array

            for (i = 0; i < n; i++)
            {
                arrayMerge[i] = array1[i];
            }

            for (j=0;j<m;j++)
            {
                arrayMerge[i] = array2[j];
                i++;
            }

            //Print merged array
            Console.WriteLine();
            for (i = 0; i < k; i++)
            {
                Console.Write($" {arrayMerge[i]}");
            }

            //Sorting the array

            for (i = 0; i < k; i++)
            {
                for (j=0; j < k-1; j++)
                {
                    if (arrayMerge[j] >= arrayMerge[j + 1])
                    {
                        temp = arrayMerge[j+1];
                        arrayMerge[j + 1] = arrayMerge[j];
                        arrayMerge[j] = temp;
                    }
                }
            }

            //Print merged  ascended array array
            Console.WriteLine();
            for (i = 0; i < k; i++)
            {
                Console.Write($" {arrayMerge[i]}");
            }
        }
    }
}
