namespace DateIntervalApp
{
    partial class DateIntervalFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DateIntervalFrm));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.NumericAddYears = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NumericAddMonths = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NumericAddDays = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NumericSubtractYears = new System.Windows.Forms.NumericUpDown();
            this.NumericSubtractMonths = new System.Windows.Forms.NumericUpDown();
            this.NumericSubtractDays = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxYears = new System.Windows.Forms.RichTextBox();
            this.TextBoxMonths = new System.Windows.Forms.RichTextBox();
            this.TextBoxDays = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAddYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAddMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAddDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSubtractYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSubtractMonths)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSubtractDays)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker1.MaxDate = new System.DateTime(2200, 2, 2, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 19);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 2, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2019, 11, 26, 18, 19, 14, 0);
            // 
            // NumericAddYears
            // 
            this.NumericAddYears.Location = new System.Drawing.Point(54, 28);
            this.NumericAddYears.Name = "NumericAddYears";
            this.NumericAddYears.Size = new System.Drawing.Size(39, 20);
            this.NumericAddYears.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label5.Location = new System.Drawing.Point(10, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Years";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label6.Location = new System.Drawing.Point(99, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Months";
            // 
            // NumericAddMonths
            // 
            this.NumericAddMonths.Location = new System.Drawing.Point(153, 29);
            this.NumericAddMonths.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.NumericAddMonths.Name = "NumericAddMonths";
            this.NumericAddMonths.Size = new System.Drawing.Size(39, 20);
            this.NumericAddMonths.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label7.Location = new System.Drawing.Point(208, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Days";
            // 
            // NumericAddDays
            // 
            this.NumericAddDays.Location = new System.Drawing.Point(248, 29);
            this.NumericAddDays.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumericAddDays.Name = "NumericAddDays";
            this.NumericAddDays.Size = new System.Drawing.Size(39, 20);
            this.NumericAddDays.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label8.Location = new System.Drawing.Point(10, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Years";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label9.Location = new System.Drawing.Point(99, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Months";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label10.Location = new System.Drawing.Point(208, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Days";
            // 
            // NumericSubtractYears
            // 
            this.NumericSubtractYears.Location = new System.Drawing.Point(54, 19);
            this.NumericSubtractYears.Name = "NumericSubtractYears";
            this.NumericSubtractYears.Size = new System.Drawing.Size(39, 20);
            this.NumericSubtractYears.TabIndex = 16;
            // 
            // NumericSubtractMonths
            // 
            this.NumericSubtractMonths.Location = new System.Drawing.Point(153, 19);
            this.NumericSubtractMonths.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.NumericSubtractMonths.Name = "NumericSubtractMonths";
            this.NumericSubtractMonths.Size = new System.Drawing.Size(39, 20);
            this.NumericSubtractMonths.TabIndex = 17;
            // 
            // NumericSubtractDays
            // 
            this.NumericSubtractDays.Location = new System.Drawing.Point(247, 19);
            this.NumericSubtractDays.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.NumericSubtractDays.Name = "NumericSubtractDays";
            this.NumericSubtractDays.Size = new System.Drawing.Size(39, 20);
            this.NumericSubtractDays.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(16, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 50);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Date";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Location = new System.Drawing.Point(16, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(216, 50);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Second Date";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.NumericAddYears);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.NumericAddMonths);
            this.groupBox3.Controls.Add(this.NumericAddDays);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(3, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 60);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Time to add";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.NumericSubtractYears);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.NumericSubtractMonths);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.NumericSubtractDays);
            this.groupBox4.Location = new System.Drawing.Point(3, 201);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(326, 54);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time to subtract";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxYears, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxMonths, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxDays, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 261);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 100);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // TextBoxYears
            // 
            this.TextBoxYears.BackColor = System.Drawing.Color.MintCream;
            this.TextBoxYears.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxYears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxYears.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxYears.ForeColor = System.Drawing.Color.Teal;
            this.TextBoxYears.Location = new System.Drawing.Point(3, 3);
            this.TextBoxYears.Name = "TextBoxYears";
            this.TextBoxYears.ReadOnly = true;
            this.TextBoxYears.Size = new System.Drawing.Size(104, 94);
            this.TextBoxYears.TabIndex = 24;
            this.TextBoxYears.Text = "";
            // 
            // TextBoxMonths
            // 
            this.TextBoxMonths.BackColor = System.Drawing.Color.MintCream;
            this.TextBoxMonths.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMonths.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxMonths.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMonths.ForeColor = System.Drawing.Color.Teal;
            this.TextBoxMonths.Location = new System.Drawing.Point(113, 3);
            this.TextBoxMonths.Name = "TextBoxMonths";
            this.TextBoxMonths.ReadOnly = true;
            this.TextBoxMonths.Size = new System.Drawing.Size(104, 94);
            this.TextBoxMonths.TabIndex = 25;
            this.TextBoxMonths.Text = "";
            // 
            // TextBoxDays
            // 
            this.TextBoxDays.BackColor = System.Drawing.Color.MintCream;
            this.TextBoxDays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxDays.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxDays.ForeColor = System.Drawing.Color.Teal;
            this.TextBoxDays.Location = new System.Drawing.Point(223, 3);
            this.TextBoxDays.Name = "TextBoxDays";
            this.TextBoxDays.ReadOnly = true;
            this.TextBoxDays.Size = new System.Drawing.Size(106, 94);
            this.TextBoxDays.TabIndex = 26;
            this.TextBoxDays.Text = "";
            // 
            // DateIntervalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(332, 361);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DateIntervalFrm";
            this.Text = "DateInterval";
            ((System.ComponentModel.ISupportInitialize)(this.NumericAddYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAddMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericAddDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSubtractYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSubtractMonths)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSubtractDays)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.NumericUpDown NumericAddYears;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NumericAddMonths;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NumericAddDays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NumericSubtractYears;
        private System.Windows.Forms.NumericUpDown NumericSubtractMonths;
        private System.Windows.Forms.NumericUpDown NumericSubtractDays;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox TextBoxYears;
        private System.Windows.Forms.RichTextBox TextBoxMonths;
        private System.Windows.Forms.RichTextBox TextBoxDays;
    }
}

