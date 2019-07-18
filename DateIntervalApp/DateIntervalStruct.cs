

namespace DateIntervalApp
{

    /// <summary>
    /// Represents the interval between 2 dates.
    /// </summary>
    public struct DateIntervalStruct
    {


        public int years;
        public int months;
        public int days;


        public DateIntervalStruct(int y, int m, int d)
        {
            years = y;
            months = m;
            days = d;
        }


        /*Getters*/
        public int GetYears()
        {
            return years;
        }


        public int GetMonths()
        {
            return months;
        }


        public int GetDays()
        {
            return days;
        }


        /*Setters*/
        public void setYears(int y)
        {
            this.years = y;
        }

        public void setMonths(int m)
        {
            this.months = m;
        }

        public void setDays(int d)
        {
            this.days = d;
        }


    }

}