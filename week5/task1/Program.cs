using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            string filename = "saveComplexNumbers.xml";
            ComplexNumbers ab = new ComplexNumbers(int.Parse(s[0]), int.Parse(s[1]));
            Save(ab, filename);

            ComplexNumbers cn = Load(filename);
            Console.WriteLine(cn.GetData());
        }

        static void Save(ComplexNumbers cn, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            XmlSerializer xml = new XmlSerializer(typeof(ComplexNumbers));
            xml.Serialize(fs, cn);
            fs.Close();
        }

        static ComplexNumbers Load(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            XmlSerializer xml = new XmlSerializer(typeof(ComplexNumbers));
            ComplexNumbers cn = xml.Deserialize(fs) as ComplexNumbers;
            fs.Close();
            return cn;
        }
    }
    public class ComplexNumbers
    {
        public ComplexNumbers()
        {

        }

        public int a,b;

        public ComplexNumbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public string GetData()
        {
            return this.a + "+" + this.b + "i";
        }
    }
}