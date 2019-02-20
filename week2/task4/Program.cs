using System;
using System.IO;

namespace task4
{
    class Program
    {
        public static void Main()
        {
            string path = Console.ReadLine();//giving path for the first file
            string name = Console.ReadLine();//name of the file
            string path2 = Console.ReadLine();//where file is createn 
            string name2 = Console.ReadLine();//name of the second file
            path = Path.Combine(path, name); //combining path for the first file
            path2 = Path.Combine(path2, name2);//combining path for the second file
            File.WriteAllText(path, "To infinity and beyond");//writing a text in the file
            File.Copy(path,path2,true);//copying one files text into another one
            File.Delete(path);//deleting the original file
        }
    }
}
