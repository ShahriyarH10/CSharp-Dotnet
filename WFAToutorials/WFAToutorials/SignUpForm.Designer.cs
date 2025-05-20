namespace WFAToutorials
{
    partial class SignUpForm
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
            this.txtLName = new System.Windows.Forms.TextBox();
            this.lblLName = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblFName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.gbServices = new System.Windows.Forms.GroupBox();
            this.cbSMS = new System.Windows.Forms.CheckBox();
            this.cbReports = new System.Windows.Forms.CheckBox();
            this.cbTransaction = new System.Windows.Forms.CheckBox();
            this.lblSMS = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.lblTransaction = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.gbServices.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(271, 93);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(457, 20);
            this.txtLName.TabIndex = 7;
            this.txtLName.UseSystemPasswordChar = true;
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(178, 95);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(85, 16);
            this.lblLName.TabIndex = 6;
            this.lblLName.Text = "Last Name:";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(271, 53);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(457, 20);
            this.txtFName.TabIndex = 5;
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(177, 55);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(86, 16);
            this.lblFName.TabIndex = 4;
            this.lblFName.Text = "First Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(271, 137);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.UseSystemPasswordChar = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(151, 139);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(112, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email Address:";
            // 
            // gbServices
            // 
            this.gbServices.Controls.Add(this.lblTransaction);
            this.gbServices.Controls.Add(this.lblReports);
            this.gbServices.Controls.Add(this.lblSMS);
            this.gbServices.Controls.Add(this.cbTransaction);
            this.gbServices.Controls.Add(this.cbReports);
            this.gbServices.Controls.Add(this.cbSMS);
            this.gbServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbServices.Location = new System.Drawing.Point(154, 194);
            this.gbServices.Name = "gbServices";
            this.gbServices.Size = new System.Drawing.Size(574, 191);
            this.gbServices.TabIndex = 10;
            this.gbServices.TabStop = false;
            this.gbServices.Text = "Services";
            // 
            // cbSMS
            // 
            this.cbSMS.AutoSize = true;
            this.cbSMS.Location = new System.Drawing.Point(117, 34);
            this.cbSMS.Name = "cbSMS";
            this.cbSMS.Size = new System.Drawing.Size(140, 20);
            this.cbSMS.TabIndex = 0;
            this.cbSMS.Text = "SMS Notification";
            this.cbSMS.UseVisualStyleBackColor = true;
            // 
            // cbReports
            // 
            this.cbReports.AutoSize = true;
            this.cbReports.Location = new System.Drawing.Point(117, 72);
            this.cbReports.Name = "cbReports";
            this.cbReports.Size = new System.Drawing.Size(81, 20);
            this.cbReports.TabIndex = 1;
            this.cbReports.Text = "Reports";
            this.cbReports.UseVisualStyleBackColor = true;
            // 
            // cbTransaction
            // 
            this.cbTransaction.AutoSize = true;
            this.cbTransaction.Location = new System.Drawing.Point(117, 109);
            this.cbTransaction.Name = "cbTransaction";
            this.cbTransaction.Size = new System.Drawing.Size(167, 20);
            this.cbTransaction.TabIndex = 2;
            this.cbTransaction.Text = "Transaction Reports";
            this.cbTransaction.UseVisualStyleBackColor = true;
            // 
            // lblSMS
            // 
            this.lblSMS.AutoSize = true;
            this.lblSMS.Location = new System.Drawing.Point(315, 35);
            this.lblSMS.Name = "lblSMS";
            this.lblSMS.Size = new System.Drawing.Size(51, 16);
            this.lblSMS.TabIndex = 3;
            this.lblSMS.Text = "...........";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Location = new System.Drawing.Point(315, 76);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(51, 16);
            this.lblReports.TabIndex = 4;
            this.lblReports.Text = "...........";
            // 
            // lblTransaction
            // 
            this.lblTransaction.AutoSize = true;
            this.lblTransaction.Location = new System.Drawing.Point(315, 113);
            this.lblTransaction.Name = "lblTransaction";
            this.lblTransaction.Size = new System.Drawing.Size(51, 16);
            this.lblTransaction.TabIndex = 5;
            this.lblTransaction.Text = "...........";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.Location = new System.Drawing.Point(647, 406);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(81, 32);
            this.btnSignUp.TabIndex = 11;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.gbServices);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.lblLName);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblFName);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.gbServices.ResumeLayout(false);
            this.gbServices.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox gbServices;
        private System.Windows.Forms.CheckBox cbTransaction;
        private System.Windows.Forms.CheckBox cbReports;
        private System.Windows.Forms.CheckBox cbSMS;
        private System.Windows.Forms.Label lblTransaction;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Label lblSMS;
        private System.Windows.Forms.Button btnSignUp;
    }
}