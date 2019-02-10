using System;
using System.IO;

namespace task3
{
    class Program
    {
        public static void Main()
        {
            string s="";
            DirectoryInfo dirInfo = new DirectoryInfo(@Console.ReadLine());
            DirectoryInfo[] dirs = dirInfo.GetDirectories();
            FileSystemInfo[] fileInfos = dirInfo.GetFileSystemInfos();
            FileSystemInfos(fileInfos,s);
            Console.ReadKey();
        }

        static void FileSystemInfos(FileSystemInfo[] fileInfos, string s)
        {
            for(var i=0; i<fileInfos.Length;i++)
            {
                Console.WriteLine(s+fileInfos[i]);
                string r = s;
                if (fileInfos[i].GetType() == typeof(DirectoryInfo))
                {
                    s += "     ";
                    DirectoryInfo d = new DirectoryInfo(fileInfos[i].FullName);
                    FileSystemInfo[] fs = d.GetFileSystemInfos();
                    FileSystemInfos(fs,s);
                }
                s=r;
            }
            
        }
    }
}