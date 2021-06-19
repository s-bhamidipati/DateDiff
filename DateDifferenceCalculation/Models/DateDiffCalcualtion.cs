using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DateDifferenceCalculation.Models
{
    /// <summary>
    /// DateDiffCalcualtion Model
    /// </summary>
    public class DateDiffCalcualtion
    {
        /// <summary>
        /// Inital Class for Declaration
        /// </summary>
        public class DateDiff
        {
            public int days, month, year;

            public DateDiff(int days, int month, int year)
            {
                this.days = days;
                this.month = month;
                this.year = year;
            }
        };

        // To store number of days in
        // all months from January to Dec.
        static int[] monthDays = { 31, 28, 31,
                               30, 31, 30,
                               31, 31, 30,
                               31, 30, 31 };
        // This function counts number of
        // leap years before the given date
        static int countLeapYears(DateDiff d)
        {
            int years = d.year;

            // Check if the current year
            // needs to be considered
            // for the count of leap years or not
            if (d.month <= 2)
            {
                years--;
            }

            // An year is a leap year if it is
            // a multiple of 4, multiple of 400
            // and not a multiple of 100.
            return years / 4
                   - years / 100
                   + years / 400;
        }

        // This function returns number
        // of days between two given dates
        static int getDifference(DateDiff startDate, DateDiff endDate)
        {
            // COUNT TOTAL NUMBER OF DAYS
            // BEFORE FIRST DATE 'startDate'

            // initialize count using years and day
            int n1 = startDate.year * 365 + startDate.days;

            // Add days for months in given date
            for (int i = 0; i < startDate.month - 1; i++)
            {
                n1 += monthDays[i];
            }

            // Since every leap year is of 366 days,
            // Add a day for every leap year
            n1 += countLeapYears(startDate);

            // SIMILARLY, COUNT TOTAL
            // NUMBER OF DAYS BEFORE 'endDate'
            int n2 = endDate.year * 365 + endDate.days;
            for (int i = 0; i < endDate.month - 1; i++)
            {
                n2 += monthDays[i];
            }
            n2 += countLeapYears(endDate);

            // return difference between two counts
            return (n2 - n1);
        }

        /// <summary>
        /// Calling Method for Difference 
        /// </summary>
        /// <param name="userDate"></param>
        /// <returns>Difference between two given dates</returns>
        public static int Difference(UserRequest userDate)
        {
            int result = 0;
            string[] sDate = userDate.StartDate.Split('-');
            string[] eDate = userDate.EndDate.Split('-');

            DateDiff date1 = new DateDiff(int.Parse(sDate[2]), int.Parse(sDate[1]), int.Parse(sDate[0]));
            DateDiff date2 = new DateDiff(int.Parse(eDate[2]), int.Parse(eDate[1]), int.Parse(eDate[0]));

            // Function call
            result = getDifference(date1, date2);
            return result;
        }
    }
}