using System;
using System.IO;

namespace Student_data_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = "E:\\Project\\Project 1\\Student Details.txt";
            string studentfile = File.ReadAllText(path);
            Console.WriteLine(studentfile);
        }
    }
}


