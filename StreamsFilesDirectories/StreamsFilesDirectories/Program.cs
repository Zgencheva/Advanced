using System;
using System.IO;

namespace StreamsFilesDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../input.txt");
            string student = reader.ReadLine();
            var stdent2 = reader.Read(); //ascii code
            //var allStudents = reader.ReadToEnd();
            //Console.WriteLine(allStudents);
            while (student != null)
            {
                Console.WriteLine(student);
                student = reader.ReadLine();
            }
           
            reader.Close();
            
            //StreamWriter writer = new StreamWriter("../../../students.txt"); //makes the file
            //// "../" moves the file one folder backwords
            ////it`s written in: E:\C#-Advanced-Repo\StreamsFilesDirectories\StreamsFilesDirectories\bin\Debug\netcoreapp3.1
            //writer.WriteLine("Second student!!!"); //input data
            //writer.WriteLine("Third student!!!"); //input data
            
            //writer.Close(); //should be closed



        }
    }
}
