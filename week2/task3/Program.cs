using System;
using System.IO;

namespace task3
{
    class Program
    {
        public static void Main()
        {
            string s="";//string for leaving a space 
            DirectoryInfo dirInfo = new DirectoryInfo(@Console.ReadLine());//path to a directory
            DirectoryInfo[] dirs = dirInfo.GetDirectories();//getting  directories inside of the main directory
            FileSystemInfo[] fileInfos = dirInfo.GetFileSystemInfos();//getting files inside of the main directory
            FileSystemInfos(fileInfos,s);//calling the method
            Console.ReadKey();
        }

        static void FileSystemInfos(FileSystemInfo[] fileInfos, string s)
        {
            for(var i=0; i<fileInfos.Length;i++)//loop for show each of files and directories inside 
            {
                Console.WriteLine(s+fileInfos[i]);
                string r = s;//saving space in another string
                if (fileInfos[i].GetType() == typeof(DirectoryInfo))
                {
                    s += "     ";//adding space to previous space
                    DirectoryInfo d = new DirectoryInfo(fileInfos[i].FullName);
                    FileSystemInfo[] fs = d.GetFileSystemInfos();
                    FileSystemInfos(fs,s);//if the filesystem is a directory to repeat the method
                }
                s=r;//returning the previous space
            }
            
        }
    }
}