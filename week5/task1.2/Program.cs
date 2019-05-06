using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace task1n2
{
    [Serializable]
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string s2 = Console.ReadLine();
            ComplexNumbers cn = new ComplexNumbers(int.Parse(s), int.Parse(s2));
            string filename = "../../saves/save.dat";
            Save(cn, filename);
            Load(filename);
            cn.GetInfo();
        }
        static void Save(ComplexNumbers cn,string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, cn);
            fs.Close();
        }
        static ComplexNumbers Load(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            ComplexNumbers cn = bf.Deserialize(fs) as ComplexNumbers;
            fs.Close();
            return cn;
        }
    }
    class ComplexNumbers
    {
        int a,b;
        public ComplexNumbers(int a,int b)
        {
            this.a = a;
            this.b = b;
        }
        public string GetInfo()
        {
            return this.a + "+" + this.b + "i";
        }
    }
}
