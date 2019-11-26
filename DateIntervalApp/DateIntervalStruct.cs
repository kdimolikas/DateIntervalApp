

namespace DateIntervalApp
{

    /// <summary>
    /// Represents the interval between 2 dates.
    /// </summary>
    public struct DateIntervalStruct
    {

        private int years;
        private int months;
        private int days;

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
        public void SetYears(int y)
        {
            this.years = y;
        }

        public void SetMonths(int m)
        {
            this.months = m;
        }

        public void SetDays(int d)
        {
            this.days = d;
        }
    }
}