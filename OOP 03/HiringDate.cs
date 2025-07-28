using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            // Validate day
            Day = (day >= 1 && day <= 31) ? day : 1;

            // Validate month
            Month = (month >= 1 && month <= 12) ? month : 1;

            // Validate year
            Year = (year >= 1900 && year <= DateTime.Now.Year) ? year : 2000;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }
    }

}
