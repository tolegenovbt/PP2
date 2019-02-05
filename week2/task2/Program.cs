using System;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"...\input.txt", FileMode.Open, FileAccess.Read);
            FileStream f2 = new FileStream(@"...\output.txt", FileMode.Create, FileAccess.Write);
            StreamReader sr = new StreamReader(f);
            StreamWriter sw = new StreamWriter(f2); 
            string[] s = sr.ReadLine().Split();

            for (int i = 0; i < s.Length; i++)
            {
                int cnt = 0;
                int k = int.Parse(s[i]);
                if (k != 1)
                {
                    for (int j = 2; j <= k; j++)
                    {
                        if (k % j == 0)
                            cnt++;

                    }
                    if (cnt == 1)
                        sw.Write(k + " ");
                }

            }
            sw.Close();
            sr.Close();
            f.Close();
            f2.Close();



        }
    }
}
