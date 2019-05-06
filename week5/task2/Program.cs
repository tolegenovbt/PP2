using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Mark
    {
        int points;
        string mark;
        public Mark()
        {
            
        }
        string GetLetter(int points)
        {
            if (95 <= points && points >= 100)
                return "A";
            if (90 <= points && points >= 94)
                return "A-";
            if (85 <= points && points >= 89)
                return "B+";
            if (80 <= points && points >= 84)
                return "B";
            if (75 <= points && points >= 79)
                return "B-";
            if (70 <= points && points >= 74)
                return "C+";
            if (65 <= points && points >= 69)
                return "C";
            if (60 <= points && points >= 64)
                return "C-";
            if (55 <= points && points >= 59)
                return "D+";
            if (50 <= points && points >= 54)
                return "D";
            else
                return "F";

        }
        class Program
        {
            static void Main(string[] args)
            {
                Mark mark = new Mark();
                List<string> s= new List<string>();
                int n = int.Parse(Console.ReadLine());
                for(int i =0;i<n; i++)
                {
                    int k = int.Parse(Console.ReadLine());
                    s.Add(mark.GetLetter(k));
                }
            }
        }
    }
}
