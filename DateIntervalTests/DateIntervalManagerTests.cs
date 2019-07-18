
using Microsoft.VisualStudio.TestTools.UnitTesting;

using DateIntervalApp;

using System;

/// <summary>
/// Tests for the <c>DateIntervalManager</c> class.
/// </summary>
namespace DateIntervalTests
{
       

    [TestClass]
    public class DateIntervalManagerTests
    {


        [TestMethod]
        [Description("Asserts that an exception is thrown when dates' order is invalid.")]
        [Owner("KD")]
        [TestProperty("Date", "2019-07-16")]
        public void Test_SetDateInterval_Invalid_Date_Selection()
        {
            DateTime date1 = new DateTime(2020,12,31);
            DateTime date2 = new DateTime(2019,7,16);

            DateIntervalManager manager = new DateIntervalManager(date1, date2);
                       
            Assert.ThrowsException<ArgumentException>(() => manager.SetDateInterval());
        }



        [TestMethod]
        [Description("Asserts that the results of the SetDateInterval method.")]
        [Owner("KD")]
        [TestProperty("Date", "2019-07-17")]
        public void Test_SetDateInterval_Normal_Execution()
        {
            DateTime date1 = new DateTime(2019, 1, 31);
            DateTime date2 = new DateTime(2019, 7, 31);

            DateTime date3 = new DateTime(2018, 9, 15);
            DateTime date4 = new DateTime(2019, 7, 3);

            /*First example*/
            DateIntervalManager manager1 = new DateIntervalManager(date1, date2);

            manager1.SetDateInterval();
           
            Assert.AreEqual(0, manager1.GetDateInterval().years);
            Assert.AreEqual(6, manager1.GetDateInterval().months);
            Assert.AreEqual(0, manager1.GetDateInterval().days);

            /*Second example*/
            DateIntervalManager manager2 = new DateIntervalManager(date3, date4);

            manager2.SetDateInterval();

            Assert.AreEqual(0, manager2.GetDateInterval().years);
            Assert.AreEqual(9, manager2.GetDateInterval().months);
            Assert.AreEqual(18, manager2.GetDateInterval().days);

        }



        [TestMethod]
        [Description("Asserts that AddTime method adds {years,months,days} correctly.")]
        [Owner("KD")]
        [TestProperty("Date","2019-07-17")]
        public void Test_AddTime_Normal_Execution()
        {

            DateTime date1 = new DateTime(2019, 1, 1);
            DateTime date2 = new DateTime(2019, 7, 1);
            int years2Add = 2;
            int months2Add = 3;
            int days2Add = 10;

            DateIntervalManager manager = new DateIntervalManager(date1,date2);
            manager.SetDateInterval();
            manager.AddTime(years2Add, months2Add, days2Add);

            Assert.AreEqual(2, manager.GetDateInterval().years,"Expected and actual years differ.");
            Assert.AreEqual(9, manager.GetDateInterval().months, "Expected and actual months differ.");
            Assert.AreEqual(10, manager.GetDateInterval().days, "Expected and actual days differ.");

        }



        [TestMethod]
        [Description("Asserts that SubtractTime method subtracts {years,months,days} correctly.")]
        [Owner("KD")]
        [TestProperty("Date", "2019-07-17")]
        public void Test_SubtractTime_Normal_Execution()
        {
            int years2Sub = 2;
            int months2Sub = 3;
            int days2Sub = 9;

            /*Valid dates for subtraction*/
            DateTime date1 = new DateTime(2016, 1, 1);
            DateTime date2 = new DateTime(2019, 7, 10);
            DateIntervalManager manager = new DateIntervalManager(date1, date2);
            manager.SetDateInterval();
           
            
            manager.SubtractTime(years2Sub, months2Sub, days2Sub);
            Assert.AreEqual(1, manager.GetDateInterval().years, "Expected and actual years differ.");
            Assert.AreEqual(3, manager.GetDateInterval().months, "Expected and actual months differ.");
            Assert.AreEqual(0, manager.GetDateInterval().days, "Expected and actual days differ.");

        }



        [TestMethod]
        [Description("Asserts that SubtractTime method throws exception when at least" +
                     " one of the args makes subtraction invalid.")]
        [Owner("KD")]
        [TestProperty("Date", "2019-07-17")]
        public void Test_SubtractTime_Invalid_Execution()
        {
            int years2Sub = 2;
            int months2Sub = 3;
            int days2Sub = 9;

            /*Invalid subtraction(yearsDiff<=0)*/
            DateTime date1 = new DateTime(2019, 1, 1);
            DateTime date2 = new DateTime(2019, 7, 10);
            DateIntervalManager manager = new DateIntervalManager(date1, date2);
            manager.SetDateInterval();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => manager.SubtractTime(years2Sub, months2Sub, days2Sub));

            /*Invalid subtraction(daysDiff<0)*/
            date1.AddYears(-3);
            months2Sub = 7;
            days2Sub = 10;
            manager.SetDateInterval();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => manager.SubtractTime(years2Sub, months2Sub, days2Sub));

            /*Invalid subtraction(monthsDiff<0)*/
            date1.AddYears(3);
            months2Sub = 7;
            manager.SetDateInterval();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => manager.SubtractTime(years2Sub, months2Sub, days2Sub));


        }



    }


}