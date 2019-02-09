using System;
using System.IO;

namespace task3
{
    class Program
    {
        public static void Main()
        {
            string s="";
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\11111\c#\labs\week2");
            DirectoryInfo[] dirs = dirInfo.GetDirectories();
            FileSystemInfo[] fileInfos = dirInfo.GetFileSystemInfos();
            
            FileSystemInfos(fileInfos,s);
            Console.ReadKey();
        }

        //static void Dirs(DirectoryInfo[] dirs)
        //{
        //    for (var i = 0; i < dirs.Length; i++)
        //    {
        //        Console.WriteLine(dirs[i].FullName);


        //        if (dirs[i].GetType() == typeof(DirectoryInfo))
        //        {
        //            var fInfos = (dirs[i] as DirectoryInfo).GetFileSystemInfos();
        //            Dirs();
        //        }
        //    }
        //}

        //static void Files(FileInfo[] files)
        //{ 
        //    for(var i=0; i < files.Length; i++)
        //    {
        //        Console.WriteLine(files[i].FullName);
        //    }

        //}

        static void FileSystemInfos(FileSystemInfo[] fileInfos, string s)
        {
            for(var i=0; i<fileInfos.Length;i++)
            {
                Console.WriteLine(s+fileInfos[i]);
                string r = s;
                if (fileInfos[i].GetType() == typeof(DirectoryInfo))
                {
                    s += "     ";
                    //var fInfos = (fileInfos[i] as DirectoryInfo).GetFileSystemInfos();
                    DirectoryInfo d = new DirectoryInfo(fileInfos[i].FullName);
                    FileSystemInfo[] fs = d.GetFileSystemInfos();
                    FileSystemInfos(fs,s);
                    
                }
                s=r;
            }
            
        }
    }
}