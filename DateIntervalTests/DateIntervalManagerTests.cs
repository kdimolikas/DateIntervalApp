
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
                       
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => manager.SetDateInterval());
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
           
            Assert.AreEqual(0, manager1.Years);
            Assert.AreEqual(6, manager1.Months);
            Assert.AreEqual(0, manager1.Days);

            /*Second example*/
            DateIntervalManager manager2 = new DateIntervalManager(date3, date4);

            manager2.SetDateInterval();

            Assert.AreEqual(0, manager2.Years);
            Assert.AreEqual(9, manager2.Months);
            Assert.AreEqual(18, manager2.Days);

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
            manager.AddTime(years2Add, months2Add, days2Add);

            Assert.AreEqual(2, manager.Years,"Expected and actual years differ.");
            Assert.AreEqual(9, manager.Months, "Expected and actual months differ.");
            Assert.AreEqual(10, manager.Days, "Expected and actual days differ.");

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
           
            manager.SubtractTime(years2Sub, months2Sub, days2Sub);
            Assert.AreEqual(1, manager.Years, "Expected and actual years differ.");
            Assert.AreEqual(3, manager.Months, "Expected and actual months differ.");
            Assert.AreEqual(0, manager.Days, "Expected and actual days differ.");

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
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => manager.SubtractTime(years2Sub, months2Sub, days2Sub));

            /*Invalid subtraction(daysDiff<0)*/
            date1.AddYears(-3);
            months2Sub = 7;
            days2Sub = 10;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => manager.SubtractTime(years2Sub, months2Sub, days2Sub));

            /*Invalid subtraction(monthsDiff<0)*/
            date1.AddYears(3);
            months2Sub = 7;
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => manager.SubtractTime(years2Sub, months2Sub, days2Sub));
        }

        [TestMethod]
        [Description("Asserts that AdjustMonths method recalculates months" +
                     " when they exceed the corresponding limit.")]
        [Owner("KD")]
        [TestProperty("Date", "2019-07-19")]
        public void Test_AdjustMonths()
        {
        
            int yearDiff = 0;
            int monthDiff = 13;
                    
            DateIntervalManager.AdjustMonths(ref yearDiff,ref monthDiff);

            Assert.AreEqual(1,yearDiff,"Years interval is not the expected one");
            Assert.AreEqual(1,monthDiff,"Months interval is not the expected one");
        }

        [TestMethod]
        [Description("Asserts that AdjustDays method recalculates days" +
                     " when they exceed the corresponding limit.")]
        [Owner("KD")]
        [TestProperty("Date", "2019-07-19")]
        public void Test_AdjustDays()
        {
            int monthDiff = 0;
            int dayDiff = 53;
            
            DateIntervalManager.AdjustDays(ref monthDiff,ref dayDiff);

            Assert.AreEqual(1,monthDiff,"Months interval is not the expected one");
            Assert.AreEqual(23,dayDiff,"Days interval is not the expected one");
        }
    }
}