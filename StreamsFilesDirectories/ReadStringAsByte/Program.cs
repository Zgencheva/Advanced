using System;
using System.IO;
using System.Text;

namespace ReadStringAsByte
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Хей, това е текст in english";
            using (FileStream stream = new FileStream("../../../input.txt", FileMode.OpenOrCreate))
            {
                byte[] byteText = Encoding.UTF8.GetBytes(text);
                
                stream.Write(byteText, 0, byteText.Length);
            }


        }
    }
}
