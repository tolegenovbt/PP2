using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"...\input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(f);
            string s = sr.ReadLine();
            int cnt = 0;
            for(int i=0;i<s.Length/2;i++)
            {
                if(s[i]!=s[s.Length-1-i])
                {
                    cnt++;
                }
            }
            if (cnt == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
            sr.Close();
            f.Close();
        }
    }
}
