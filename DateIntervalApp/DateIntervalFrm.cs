using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace DateIntervalApp
{
    
    /// <summary>
    /// Contains the event handlers of the application. 
    /// </summary>
    public partial class DateIntervalFrm : Form
    {
        
        private DateIntervalManager interval;
        private static float FONT_SIZE = 26.0F;

        public DateIntervalFrm()
        {
            InitializeComponent();
            /*Setup event handlers*/
            NumericSubtractYears.ValueChanged += Numeric_ValueChanged;
            NumericSubtractMonths.ValueChanged += Numeric_ValueChanged;
            NumericSubtractDays.ValueChanged += Numeric_ValueChanged;
            NumericAddYears.ValueChanged += Numeric_ValueChanged;
            NumericAddMonths.ValueChanged += Numeric_ValueChanged;
            NumericAddDays.ValueChanged += Numeric_ValueChanged;
            dateTimePicker1.ValueChanged += Numeric_ValueChanged;
            dateTimePicker2.ValueChanged += Numeric_ValueChanged;
            
            NumericAddYears.Validating += Numeric_Validating;
            NumericAddMonths.Validating += Numeric_Validating;
            NumericAddDays.Validating += Numeric_Validating;
            NumericSubtractYears.Validating += Numeric_Validating;
            dateTimePicker1.Validating += Numeric_Validating;
            dateTimePicker2.Validating += Numeric_Validating;

            interval = new DateIntervalManager(dateTimePicker1.Value, dateTimePicker2.Value);
            interval.SetDateInterval();

            this.DisplayInterval();
            this.UpdateLimits();
        }
                      
        /// <summary>
        /// <c>DisplayInterval</c> method displays the interval between two dates.
        /// </summary>
        private void DisplayInterval()
        {   
            DisplayYears();
            DisplayMonths();
            DisplayDays();
        }    

        private void DisplayYears()
        {
            TextBoxYears.Clear();
            TextBoxYears.SelectionAlignment = HorizontalAlignment.Right;
            TextBoxYears.SelectionFont = new System.Drawing.Font(Font.OriginalFontName, 8);
            TextBoxYears.AppendText("years" + Environment.NewLine);
            TextBoxYears.SelectionAlignment = HorizontalAlignment.Center;
            TextBoxYears.SelectionFont = new System.Drawing.Font(Font.OriginalFontName, FONT_SIZE);
            TextBoxYears.AppendText(interval.Years.ToString());
        }

        private void DisplayMonths()
        {
            TextBoxMonths.Clear();
            TextBoxMonths.SelectionAlignment = HorizontalAlignment.Right;
            TextBoxMonths.SelectionFont = new System.Drawing.Font(Font.OriginalFontName, 8);
            TextBoxMonths.AppendText("months" + Environment.NewLine);
            TextBoxMonths.SelectionAlignment = HorizontalAlignment.Center;
            TextBoxMonths.SelectionFont = new System.Drawing.Font(Font.OriginalFontName, FONT_SIZE);
            TextBoxMonths.AppendText(interval.Months.ToString());
        }

        private void DisplayDays()
        {
            TextBoxDays.Clear();
            TextBoxDays.SelectionAlignment = HorizontalAlignment.Right;
            TextBoxDays.SelectionFont = new System.Drawing.Font(Font.OriginalFontName, 8);
            TextBoxDays.AppendText("days" + Environment.NewLine);
            TextBoxDays.SelectionAlignment = HorizontalAlignment.Center;
            TextBoxDays.SelectionFont = new System.Drawing.Font(Font.OriginalFontName, FONT_SIZE);
            TextBoxDays.AppendText(interval.Days.ToString());
        }

        /// <summary>
        /// Update numeric max and min limits 
        /// </summary>
        private void UpdateLimits()
        {
            NumericSubtractYears.Maximum = interval.Years 
                                           + NumericAddYears.Value
                                           - NumericSubtractYears.Value;
            NumericSubtractYears.Minimum = 0;
        }

        //*****************Event handlers***************//
        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                interval.SetFirstDate(dateTimePicker1.Value);
                interval.SetSecondDate(dateTimePicker2.Value);
                interval.AddTime(Decimal.ToInt32(NumericAddYears.Value),
                                 Decimal.ToInt32(NumericAddMonths.Value),
                                 Decimal.ToInt32(NumericAddDays.Value));
                interval.SubtractTime(Decimal.ToInt32(NumericSubtractYears.Value),
                                      Decimal.ToInt32(NumericSubtractMonths.Value),
                                      Decimal.ToInt32(NumericSubtractDays.Value));
                this.DisplayInterval(); 
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Out of range", "Range Exception", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Numeric_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                UpdateLimits();
            }
            catch (ArgumentOutOfRangeException)
            {
                e.Cancel = true;
            }     
        }
    }
}