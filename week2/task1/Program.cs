using System;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"C:\Users\11111\c#\labs\week2\task1\input.txt", FileMode.Open, FileAccess.Read);//giving path, mode and access for a file 
            StreamReader sr = new StreamReader(f);//creating a new streamreader
            string s = sr.ReadLine();//reading line into the file
            int cnt = 0;
            for(int i=0;i<s.Length/2;i++)
            {
                if(s[i]!=s[s.Length-1-i])//checking is the line polindrom 
                {
                    cnt++;
                }
            }
            if (cnt == 0)//if its a polindrom output "Yes"
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");//if not output "No"
            Console.ReadKey();
            sr.Close();
            f.Close();
        }
    }
}
