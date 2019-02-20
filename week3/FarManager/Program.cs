using System;
using System.IO;
using System.Collections.Generic;


namespace FarManager
{
    enum Mode { directory, file }//для того чтобы знать файл или папка
    class Program
    {
        public static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\11111\tester");//даю путь к основному файлу
            Folder folder = new Folder(dir);//дается параметр для конструктора
            Stack<Folder> dirs = new Stack<Folder>();//новый стэк для запоминания расположении файлов
            dirs.Push(folder);//пушиться главная папка в стэк
            bool run = true;//программа будет работать пока true
            Mode mode = Mode.directory;// пока что в начале даем тип папку
            while (run)
            {
                if (mode == Mode.directory)//если папка то выполняется метод принтер
                    dirs.Peek().Printer();
                ConsoleKeyInfo pressedkey = Console.ReadKey();//будет считывать нажатую кнопку
                switch (pressedkey.Key)
                {
                    case ConsoleKey.UpArrow://для прогулки вверх и вниз
                        dirs.Peek().Up();
                        break;

                    case ConsoleKey.DownArrow://для прогулки вниз
                        dirs.Peek().Down();
                        break;

                    case ConsoleKey.Enter://заходит внутрь папки или же показывает текс внутри файла
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
                    case ConsoleKey.R://меняет имя 
                        //FileSystemInfo select = dirs.Peek().GetIndexObj();
                        dirs.Peek().Rename();
                        //dirs.Pop();
                        dirs.Peek().Printer();
                        break;

                    case ConsoleKey.Delete://удалить файл или папку
                        dirs.Peek().Kill();//вызывает для файлов или папок метод удаления
                        //dirs.Pop();
                        dirs.Peek().Printer();
                        break;

                    case ConsoleKey.Backspace://выходит из папки
                        if (dirs.Count > 1)
                            dirs.Pop();
                        break;

                    case ConsoleKey.Escape://выходит из файла
                        if (mode == Mode.directory)//если нажать внутри папки, выходит из программы 
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
        int Index;//индекс объектов внутри папки
        FileSystemInfo[] contents;//объекты внутри папок
        public string FullPath;//полный путь к объекту
        public string DirPath;//полный путь к папки внутри которой находится объект


        public Folder(DirectoryInfo directory)//конструктор с параметром DirectoryInfo
        {
            Index = 0;
            contents = directory.GetFileSystemInfos();
            DirPath = directory.FullName;
        }

        public void Up()//метод для прогулки вверх
        {
            if (Index == 0)//с первого объекта переходит к последнему
                Index = contents.Length - 1;
            else
                Index--;
            FullPath = contents[Index].FullName;//полный путь к выбранному файлу
        }
        public void Down()//вниз
        {
            if (Index == contents.Length - 1)//с последнего к первому
                Index = 0;
            else
                Index++;
            FullPath = contents[Index].FullName;
        }
        public FileSystemInfo GetIndexObj()//метод для получения индекса объекта
        {
            return contents[Index];
        }

        public void Printer()
        {
            Console.Clear();

            for (int i = 0; i < contents.Length; i++)
            {
                // цвета чтобы видеть курсор

                if (i == Index)//бэкграунд выбранного объекта
                {
                    Console.BackgroundColor = ConsoleColor.Cyan;
                }
                else//для остальных 
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                }

                if (contents[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;//папки белым цветом
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;//файлы зеленым
                }

                Console.WriteLine(contents[i].Name);
            }
        }
        public void Kill()//метод для удаления
        {
            if (File.Exists(FullPath))//удаляет выбранный файл
                File.Delete(FullPath);
            else
                Directory.Delete(FullPath);//выбранную папку
        }
        public void Rename()//переименовать
        {
            Console.Clear();//чистит консоль
            string newname = Console.ReadLine();//новое имя
            string path = Path.Combine(DirPath, newname);
            if (File.Exists(FullPath))
            {
                File.Copy(FullPath, path, true);//копирует
                File.Delete(FullPath);//удаляет
            }
            else
            {
                Directory.Move(@FullPath, @path);//сразу же копирует и удаляет
            }
        }
    }

}