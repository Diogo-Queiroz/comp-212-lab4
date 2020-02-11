namespace Test
{
    partial class Form1
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
            this.ctlAlarmClock1 = new FE_301082193__Comp212_Lab4.ctlAlarmClock();
            this.dtpTest = new System.Windows.Forms.DateTimePicker();
            this.lblTest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ctlAlarmClock1
            // 
            this.ctlAlarmClock1.AlarmSet = false;
            this.ctlAlarmClock1.AlarmTime = new System.DateTime(((long)(0)));
            this.ctlAlarmClock1.ClockBackColor = System.Drawing.Color.Empty;
            this.ctlAlarmClock1.Location = new System.Drawing.Point(0, 0);
            this.ctlAlarmClock1.Name = "ctlAlarmClock1";
            this.ctlAlarmClock1.Size = new System.Drawing.Size(800, 450);
            this.ctlAlarmClock1.TabIndex = 0;
            // 
            // dtpTest
            // 
            this.dtpTest.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTest.Location = new System.Drawing.Point(513, 120);
            this.dtpTest.Name = "dtpTest";
            this.dtpTest.Size = new System.Drawing.Size(200, 20);
            this.dtpTest.TabIndex = 1;
            this.dtpTest.ValueChanged += new System.EventHandler(this.dtpTest_ValueChanged);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.Location = new System.Drawing.Point(510, 73);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 24);
            this.lblTest.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.dtpTest);
            this.Controls.Add(this.ctlAlarmClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FE_301082193__Comp212_Lab4.ctlAlarmClock ctlAlarmClock1;
        private System.Windows.Forms.DateTimePicker dtpTest;
        private System.Windows.Forms.Label lblTest;
    }
}

