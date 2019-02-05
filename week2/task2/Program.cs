using System;
using System.IO;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream(@"...\input.txt", FileMode.Open, FileAccess.Read);//адрес откуда будут считываться данные
            FileStream f2 = new FileStream(@"...\output.txt", FileMode.Create, FileAccess.Write);//адрес куда будет сохранятся новый файл
            StreamReader sr = new StreamReader(f);//для инпута
            StreamWriter sw = new StreamWriter(f2); //для аутпута
            string[] s = sr.ReadLine().Split();// разделяет строку в аргументы и кладет их в массив

            for (int i = 0; i < s.Length; i++)
            {
                int cnt = 0;
                int k = int.Parse(s[i]);//парсит число из массива т.к. изначально его тип - стринг
                if (k != 1)
                {
                    for (int j = 2; j <= k; j++)
                    {
                        if (k % j == 0)
                            cnt++;//увеличивается каждый раз, когда число из массива делиться на j без остатка

                    }
                    if (cnt == 1)//если число из массива делиться без остатка только само на себя, всписывает это число в sw
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
