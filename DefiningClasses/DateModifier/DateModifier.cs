using System;
using System.Collections.Generic;
using System.Text;

namespace DateModifier
{
    public class DateModifier
    {
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public DateModifier(string startDate, string endDate)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public int CalculateDateDifference(string startDate, string endDate)
        {

            string[] stDate = startDate.Split();
            string[] edDay = endDate.Split();

            DateTime myDate1 = DateTime.ParseExact($"{stDate[0]}-{stDate[1]}-{stDate[2]}", "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);
            DateTime myDate2 = DateTime.ParseExact($"{edDay[0]}-{edDay[1]}-{edDay[2]}", "yyyy-MM-dd",
                                       System.Globalization.CultureInfo.InvariantCulture);

            if (myDate1 > myDate2)
            {
                var difference = myDate1 - myDate2;
                return difference.Days;
            }
            else
            {
                var difference = myDate2 - myDate1;
                return difference.Days;
            }
            
        }
    }
}
