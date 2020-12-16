using System;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();
            DateModifier dm = new DateModifier(startDate, endDate);
            Console.WriteLine(dm.CalculateDateDifference(startDate, endDate));
            

            
            
           
        }
    }
}
