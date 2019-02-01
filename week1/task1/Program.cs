using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0; //to find number of prime integers 
            int n = int.Parse(Console.ReadLine()); //number of input integers 
            int[] array = new int[n]; //a new array to save prime numbers
            string[] s = Console.ReadLine().Split(); //the numbers
            for (int i = 0; i < n; i++)
            {
                int k = int.Parse(s[i]);
                if (k % 2 == 1)
                {
                    array[cnt++] = k; // to add this number to the array and to increase value of cnt +1
                }
            }
            Console.WriteLine(cnt); //the first output- number of the prime integers
            for (int i = 0; i < cnt; i++) //loop to output each of the prime integers
                Console.Write(array[i]+" ");
            Console.ReadKey();
        }
    }
}
