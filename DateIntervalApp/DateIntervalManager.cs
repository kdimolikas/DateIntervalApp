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



        public DateIntervalManager(DateTime d1, DateTime d2)
        {
            date1 = d1;
            date2 = d2;
        }


        public DateIntervalStruct GetDateInterval()
        {
            return this.dateInterval;
        }


        public void SetDate1(DateTime d1)
        {
            this.date1 = d1;
        }


        public void SetDate2(DateTime d2)
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

                throw new ArgumentException("year of second date must be equal or greater than that of the first date");
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
            adjustDays(ref monthDiff, ref dayDiff);

            /*Recalculate months if monthDiff is greater than 12*/
            adjustMonths(ref yearDiff, ref monthDiff);


            if (dateInterval.Equals(null))
            {
                dateInterval = new DateIntervalStruct(yearDiff, monthDiff, dayDiff);
            }
            else
            {
                dateInterval.setYears(yearDiff);
                dateInterval.setMonths(monthDiff);
                dateInterval.setDays(dayDiff);
            }


        }


        public static void adjustMonths(ref int yearDiff, ref int monthDiff)
        {
            while (monthDiff >= MONTHS_LIMIT)
            {
                monthDiff -= MONTHS_LIMIT;
                yearDiff += 1;

            }
        }


        public static void adjustDays(ref int monthDiff, ref int dayDiff)
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
        public void AddTime(int years2Add, int months2Add, int days2Add)
        {
                       
            DateIntervalStruct finalInterval = dateInterval;

            finalInterval.setYears(finalInterval.GetYears() + years2Add);
            finalInterval.setMonths(finalInterval.GetMonths() + months2Add);
            finalInterval.setDays(finalInterval.GetDays() + days2Add);

            int yearInt = finalInterval.GetYears();
            int monthInt = finalInterval.GetMonths();
            int dayInt = finalInterval.GetDays();


            adjustDays(ref monthInt, ref dayInt);          

            adjustMonths(ref yearInt , ref monthInt);

            finalInterval.setYears(yearInt);
            finalInterval.setMonths(monthInt);


            dateInterval = finalInterval;



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

            
            DateIntervalStruct finalInterval = dateInterval;

            finalInterval.setYears(finalInterval.GetYears() - years2Sub);
            finalInterval.setMonths(finalInterval.GetMonths() - months2Sub);
            finalInterval.setDays(finalInterval.GetDays() - days2Sub);

            if (finalInterval.GetYears() < 0)
            {
                Console.WriteLine("(ERROR): Years to subtract cannot exceed years of the given interval.");
                finalInterval = dateInterval;
                throw new ArgumentOutOfRangeException("Invalid number of years to subtract.");

            }
            else
            {
                while (finalInterval.GetDays() < 0)
                {
                    if (finalInterval.GetMonths() > 0)
                    {
                        finalInterval.setDays(finalInterval.GetDays() + DAYS_LIMIT);
                        finalInterval.setMonths(finalInterval.GetMonths() - 1);
                    }
                    else
                    {
                        Console.WriteLine("(ERROR): Cannot complete the subtraction");
                        finalInterval = dateInterval;
                        throw new ArgumentOutOfRangeException("Invalid number of days to subtract.");
                    }

                }


                while (finalInterval.GetMonths() < 0)
                {

                   
                    if (finalInterval.GetYears() > 0)
                    {
                        finalInterval.setMonths(finalInterval.GetMonths() + MONTHS_LIMIT);
                        finalInterval.setYears(finalInterval.GetYears() - 1);
                    }
                    else
                    {
                        Console.WriteLine("(ERROR): Cannot complete the subtraction");
                        finalInterval = dateInterval;
                        throw new ArgumentOutOfRangeException("Invalid number of months to subtract.");
                    }

                }

            }

            dateInterval = finalInterval;


        }

        
    }


}