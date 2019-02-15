using System;
using System.IO;
using System.Collections.Generic;


namespace FarManager
{
    enum Mode { directory, file }
    class Program
    {
        public static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\11111\tester");
            Folder folder = new Folder(dir);
            Stack<Folder> dirs = new Stack<Folder>();
            dirs.Push(folder);
            bool run = true;
            Mode mode = Mode.directory;
            while (run)
            {
                if (mode == Mode.directory)
                    dirs.Peek().Printer();
                ConsoleKeyInfo pressedkey = Console.ReadKey();
                switch (pressedkey.Key)
                {
                    case ConsoleKey.UpArrow:
                        dirs.Peek().Up();
                        break;

                    case ConsoleKey.DownArrow:
                        dirs.Peek().Down();
                        break;

                    case ConsoleKey.Delete:
                        dirs.Peek().Kill();
                        break;

                    case ConsoleKey.Enter:
                        FileSystemInfo selected = dirs.Peek().GetIndexObj();
                        if (selected.GetType() == typeof(DirectoryInfo))
                        {
                            dirs.Push(new Folder(selected as DirectoryInfo));
                        }
                        else
                        {
                            string fullpath = (selected as FileInfo).FullName;
                            FileStream fs = new FileStream(fullpath, FileMode.Open, FileAccess.Read);
                            StreamReader sr = new StreamReader(fs);

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.BackgroundColor = ConsoleColor.Black;

                            Console.Clear();
                            Console.Write(sr.ReadToEnd());
                            mode = Mode.file;

                            fs.Close();
                            sr.Close();
                        }
                        break;
                    case ConsoleKey.R:
                        FileSystemInfo select = dirs.Peek().GetIndexObj();
                        dirs.Peek().Rename(select);
                        break;

                    case ConsoleKey.Backspace:
                        if (dirs.Count > 1)
                            dirs.Pop();
                        break;

                    case ConsoleKey.Escape:
                        if (mode == Mode.directory)
                            run = false;
                        else
                            mode = Mode.directory;
                        break;

                    default:
                        break;
                }

            }
        }

    }
    class Folder
    {
        int Index;
        FileSystemInfo[] contents;
        public string FullPath;
        public string DirPath;


        public Folder(DirectoryInfo directory)
        {
            Index = 0;
            contents = directory.GetFileSystemInfos();
            DirPath = directory.FullName;
        }

        public void Up()
        {
            if (Index == 0)
                Index = contents.Length - 1;
            else
                Index--;
            FullPath = contents[Index].FullName;
        }
        public void Down()
        {
            if (Index == contents.Length - 1)
                Index = 0;
            else
                Index++;
            FullPath = contents[Index].FullName;
        }
        public FileSystemInfo GetIndexObj()
        {
            return contents[Index];
        }

        public void Printer()
        {
            Console.Clear();

            for (int i = 0; i < contents.Length; i++)
            {
                // Setup colors for foreground and background colors

                if (i == Index)
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }

                if (contents[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else // FileInfo
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                Console.WriteLine(contents[i].Name);
            }
        }
        public void Kill()
        {
            if (File.Exists(FullPath))
                File.Delete(FullPath);
            else
                Directory.Delete(FullPath);
        }
        public void Rename(FileSystemInfo fis)
        {
            Console.Clear();
            string newname = Console.ReadLine();
            string path = Path.Combine(DirPath, newname);
            if (fis.GetType() == typeof(DirectoryInfo))
            {
                Directory.Move(@FullPath, @path);
            }
            else
            {
                File.Copy(FullPath, path, true);
                File.Delete(FullPath);
            }
        }
        public void Refresh()
        {

        }
    }

}