using System;

using System.Windows.Forms;


namespace DateIntervalApp
{


    /// <summary>
    /// Contains the event handlers of the application. 
    /// </summary>
    public partial class DateIntervalFrm : Form
    {
        

        private DateIntervalManager manager;



        public DateIntervalFrm()
        {
            InitializeComponent();
            manager = new DateIntervalManager(dateTimePicker1.Value, dateTimePicker2.Value);

        }
                      

        /// <summary>
        /// <c>DisplayInterval</c> method displays the interval between two dates.
        /// </summary>
        private void DisplayInterval()
        {

            textBox1.AppendText("**** Time elapsed ****"+System.Environment.NewLine);
            textBox1.AppendText("Years: "+ manager.GetDateInterval().years+ System.Environment.NewLine);
            textBox1.AppendText("Months: "+ manager.GetDateInterval().months+ System.Environment.NewLine);
            textBox1.AppendText("Days: "+ manager.GetDateInterval().days+ System.Environment.NewLine);
            textBox1.AppendText("**** Time elapsed ****");


        }
        
               


        //*****************Event handlers***************//

        //Go button
        private void goBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
           
            manager.SetDateInterval();
            manager.AddTime(Convert.ToInt32(numericUpDown1.Value),
                Convert.ToInt32(numericUpDown2.Value),
                Convert.ToInt32(numericUpDown3.Value));
            manager.SubtractTime(Convert.ToInt32(numericUpDown4.Value),
                 Convert.ToInt32(numericUpDown5.Value),
                 Convert.ToInt32(numericUpDown6.Value));

            this.DisplayInterval();

        }


        //Clear button
        private void clearBtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }



        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            manager.SetDate1(dateTimePicker1.Value);
        }



        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            manager.SetDate2(dateTimePicker2.Value);
        }


    }
}