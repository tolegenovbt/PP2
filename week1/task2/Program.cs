using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();//inputting information about a student and split it into 3 strings
            Student newby = new Student(s[0], s[1]);//creating a new student and giving value for the variables(for 'year' via parse)
            newby.year = int.Parse(s[2]);
            newby.addyear();
            newby.PrintInfo();
            Console.ReadKey();
        }
    }
    class Student
    {
        public string name; //variables
        public string id;
        public int year;

        public Student(string name, string id) //creating a constructer with 2 parameters
        {
            this.name = name;
            this.id = id;
        }
        public void addyear()//method for adding year
        {
            year++;
        }
        public void PrintInfo()//method for outputting information about the student 
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
}