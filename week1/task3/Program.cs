using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());//number of input integers
            int[] array = new int[n];//a new array for saving the input integers
            string[] s = Console.ReadLine().Split();//intputting the integers as a string and splitting them
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(s[i]);//string to integer
            }
            WW(array, n);//calling the function and giving the array with integers and number of the integers
            Console.ReadKey();
        }
        static void WW(int[] array, int n)//function for doubling the array
        {
            int[] array2 = new int[2 * n];//creating  a new array with 2*n elements
            int j = 0; //for elements of the first array
            for (int i = 0; i < 2 * n; i++)
            {
                array2[i++] = array[j];//saving each element of the first array as a 2 elements in a row in the second array
                array2[i] = array[j];
                j++;
            }
            for(int i=0; i<2*n; i++)//outputting the second array
            {
                Console.Write(array2[i]+" ");
            }
        }
    }
}