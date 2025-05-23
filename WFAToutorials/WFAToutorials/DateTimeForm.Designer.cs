namespace WFAToutorials
{
    partial class DateTimeForm
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
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.lbl1DateTime = new System.Windows.Forms.Label();
            this.lbl2Date = new System.Windows.Forms.Label();
            this.lbl3DateDay = new System.Windows.Forms.Label();
            this.lbl4Time = new System.Windows.Forms.Label();
            this.lbl5TimeSecond = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.Location = new System.Drawing.Point(270, 50);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(212, 20);
            this.dtPicker.TabIndex = 0;
            this.dtPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl1DateTime
            // 
            this.lbl1DateTime.AutoSize = true;
            this.lbl1DateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1DateTime.Location = new System.Drawing.Point(149, 104);
            this.lbl1DateTime.Name = "lbl1DateTime";
            this.lbl1DateTime.Size = new System.Drawing.Size(57, 20);
            this.lbl1DateTime.TabIndex = 1;
            this.lbl1DateTime.Text = "label1";
            // 
            // lbl2Date
            // 
            this.lbl2Date.AutoSize = true;
            this.lbl2Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Date.Location = new System.Drawing.Point(149, 140);
            this.lbl2Date.Name = "lbl2Date";
            this.lbl2Date.Size = new System.Drawing.Size(57, 20);
            this.lbl2Date.TabIndex = 2;
            this.lbl2Date.Text = "label2";
            // 
            // lbl3DateDay
            // 
            this.lbl3DateDay.AutoSize = true;
            this.lbl3DateDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3DateDay.Location = new System.Drawing.Point(149, 177);
            this.lbl3DateDay.Name = "lbl3DateDay";
            this.lbl3DateDay.Size = new System.Drawing.Size(57, 20);
            this.lbl3DateDay.TabIndex = 3;
            this.lbl3DateDay.Text = "label3";
            // 
            // lbl4Time
            // 
            this.lbl4Time.AutoSize = true;
            this.lbl4Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4Time.Location = new System.Drawing.Point(149, 213);
            this.lbl4Time.Name = "lbl4Time";
            this.lbl4Time.Size = new System.Drawing.Size(57, 20);
            this.lbl4Time.TabIndex = 4;
            this.lbl4Time.Text = "label4";
            // 
            // lbl5TimeSecond
            // 
            this.lbl5TimeSecond.AutoSize = true;
            this.lbl5TimeSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5TimeSecond.Location = new System.Drawing.Point(149, 255);
            this.lbl5TimeSecond.Name = "lbl5TimeSecond";
            this.lbl5TimeSecond.Size = new System.Drawing.Size(57, 20);
            this.lbl5TimeSecond.TabIndex = 5;
            this.lbl5TimeSecond.Text = "label5";
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(642, 390);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(104, 35);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // DateTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lbl5TimeSecond);
            this.Controls.Add(this.lbl4Time);
            this.Controls.Add(this.lbl3DateDay);
            this.Controls.Add(this.lbl2Date);
            this.Controls.Add(this.lbl1DateTime);
            this.Controls.Add(this.dtPicker);
            this.Name = "DateTimeForm";
            this.Text = "DateTimeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DateTimeForm_FormClosing);
            this.Load += new System.EventHandler(this.DateTimeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Label lbl1DateTime;
        private System.Windows.Forms.Label lbl2Date;
        private System.Windows.Forms.Label lbl3DateDay;
        private System.Windows.Forms.Label lbl4Time;
        private System.Windows.Forms.Label lbl5TimeSecond;
        private System.Windows.Forms.Button btnShow;
    }
}