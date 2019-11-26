using System;


namespace DateIntervalApp
{

    /// <summary>
    /// <c>DateIntervalManager</c> contains the business logic of the 
    /// <c>DateIntervalApp</c> application.
    /// </summary>
    public class DateIntervalManager
    {

        private static int MONTHS_LIMIT = 12;       
        private static int DAYS_LIMIT = 30;
        
        private DateTime date1;
        private DateTime date2;
        private DateIntervalStruct dateInterval;

        /// <summary>
        /// Get the years of the interval
        /// </summary>
        public int Years
        {
            get
            {
                return this.dateInterval.GetYears();
            }
        }

        /// <summary>
        ///Get the months of the interval 
        /// </summary>
        public int Months
        {
            get
            {
                return this.dateInterval.GetMonths();
            }
        }

        /// <summary>
        /// Get the days of the interval
        /// </summary>
        public int Days
        {
            get
            {
                return this.dateInterval.GetDays();
            }
        }

        public DateIntervalManager(DateTime d1, DateTime d2)
        {
            date1 = d1;
            date2 = d2;
        }

        public void SetFirstDate(DateTime d1)
        {
            this.date1 = d1;
        }

        public void SetSecondDate(DateTime d2)
        {
            this.date2 = d2;
        }

        /// <summary>
        /// Computes the interval between 2 dates.
        /// </summary>
        /// <remarks>
        /// The 2 dates are the DateTime fields of this class.
        /// </remarks>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the order of the 2 dates is invalid.
        /// </exception>
        public void SetDateInterval()
        {

            //interval in years, months, days
            int yearDiff = 0, monthDiff = 0, dayDiff = 0;

            //Reference date and input date
            int year1, year2, month1, month2, day1, day2;
            year1 = date1.Year;
            year2 = date2.Year;
            month1 = date1.Month;
            month2 = date2.Month;
            day1 = date1.Day;
            day2 = date2.Day;

            if (year1 > year2)
            {
                throw new ArgumentOutOfRangeException("year of second date must be equal or greater than that of the first date");
            }

            if (month1 > month2)
            {
                yearDiff = year2 - year1 - 1;
                monthDiff = (MONTHS_LIMIT + month2 - 1) - month1;
                dayDiff = DAYS_LIMIT - day1 + day2;
            }
            else
            {
                yearDiff = year2 - year1;

                if (day1 < day2)
                {
                    monthDiff = month2 - month1;
                    dayDiff = day2 - day1;
                }
                else
                {
                    monthDiff = month2 - month1 - 1;
                    dayDiff = DAYS_LIMIT - day1 + day2;
                }
            }

            /*Recalculate days if dayDiff is greater than DAYS_LIMIT*/
            AdjustDays(ref monthDiff, ref dayDiff);

            /*Recalculate months if monthDiff is greater than 12*/
            AdjustMonths(ref yearDiff, ref monthDiff);

            if (dateInterval.Equals(null))
            {
                dateInterval = new DateIntervalStruct(yearDiff, monthDiff, dayDiff);
            }
            else
            {
                dateInterval.SetYears(yearDiff);
                dateInterval.SetMonths(monthDiff);
                dateInterval.SetDays(dayDiff);
            }
        }

        public static void AdjustMonths(ref int yearDiff, ref int monthDiff)
        {
            while (monthDiff >= MONTHS_LIMIT)
            {
                monthDiff -= MONTHS_LIMIT;
                yearDiff += 1;
            }
        }

        public static void AdjustDays(ref int monthDiff, ref int dayDiff)
        {
            while (dayDiff >= DAYS_LIMIT)
            {
                dayDiff -= DAYS_LIMIT;
                monthDiff += 1;
            }
        }

        /// <summary>
        /// Add time to the given interval.
        /// </summary>
        /// <param name="years2Add">Years to add to the interval</param>
        /// <param name="months2Add">Months to add to the interval</param>
        /// <param name="days2Add">Days to add to the interval</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when one of the arguments makes the subtraction invalid.
        /// </exception>
        public void AddTime(int years2Add, int months2Add, int days2Add)
        {
            this.SetDateInterval();
            this.AddSubtractTime(years2Add, months2Add, days2Add);            
            this.SetDateInterval();
        }

        /// <summary>
        /// Subtract time from the given interval.
        /// </summary>
        /// <param name="years2Sub">Years to subtract from the interval</param>
        /// <param name="months2Sub">Months to subtract from the interval</param>
        /// <param name="days2Sub">Days to subtract from the interval</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when one of the arguments makes the subtraction invalid.
        /// </exception>
        public void SubtractTime(int years2Sub, int months2Sub, int days2Sub)
        {
            //Make arguments negative
            years2Sub = (years2Sub > 0) ? (-1) * years2Sub : years2Sub;
            months2Sub = (months2Sub > 0) ? (-1) * months2Sub : months2Sub;
            days2Sub = (days2Sub > 0) ? (-1) * days2Sub : days2Sub;

            this.SetDateInterval();
            this.AddSubtractTime(years2Sub, months2Sub, days2Sub);
            this.SetDateInterval();
        }       

        /// <summary>
        /// Add (or subtract) the given params from the second date
        /// </summary>
        /// <param name="years">Years to add(or subtract)</param>
        /// <param name="months">Months to add(or subtract)</param>
        /// <param name="days">Days to add(or subtract)</param>
        private void AddSubtractTime(int years, int months, int days)
        {
            DateTime oldDate = new DateTime();
            oldDate = date2;

            try
            {
                oldDate = oldDate.AddYears(years);
                oldDate = oldDate.AddMonths(months);
                oldDate = oldDate.AddDays(days);
                date2 = oldDate;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}