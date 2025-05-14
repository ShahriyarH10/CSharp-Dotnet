namespace WindowsFormsApp1
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.lblSkills = new System.Windows.Forms.Label();
            this.cbCSharp = new System.Windows.Forms.CheckBox();
            this.cbJava = new System.Windows.Forms.CheckBox();
            this.cbCpp = new System.Windows.Forms.CheckBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblDob = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnPasswordRelated = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(222, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(191, 22);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(222, 97);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Job Registration Form";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(222, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(191, 22);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(143, 136);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(70, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(158, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gender:";
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(225, 170);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(58, 20);
            this.rbtnMale.TabIndex = 8;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(310, 171);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(74, 20);
            this.rbtnFemale.TabIndex = 9;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // lblSkills
            // 
            this.lblSkills.AutoSize = true;
            this.lblSkills.Location = new System.Drawing.Point(169, 205);
            this.lblSkills.Name = "lblSkills";
            this.lblSkills.Size = new System.Drawing.Size(42, 16);
            this.lblSkills.TabIndex = 10;
            this.lblSkills.Text = "Skills:";
            // 
            // cbCSharp
            // 
            this.cbCSharp.AutoSize = true;
            this.cbCSharp.Location = new System.Drawing.Point(225, 204);
            this.cbCSharp.Name = "cbCSharp";
            this.cbCSharp.Size = new System.Drawing.Size(45, 20);
            this.cbCSharp.TabIndex = 11;
            this.cbCSharp.Text = "C#";
            this.cbCSharp.UseVisualStyleBackColor = true;
            // 
            // cbJava
            // 
            this.cbJava.AutoSize = true;
            this.cbJava.Location = new System.Drawing.Point(276, 204);
            this.cbJava.Name = "cbJava";
            this.cbJava.Size = new System.Drawing.Size(59, 20);
            this.cbJava.TabIndex = 12;
            this.cbJava.Text = "Java";
            this.cbJava.UseVisualStyleBackColor = true;
            // 
            // cbCpp
            // 
            this.cbCpp.AutoSize = true;
            this.cbCpp.Location = new System.Drawing.Point(341, 205);
            this.cbCpp.Name = "cbCpp";
            this.cbCpp.Size = new System.Drawing.Size(52, 20);
            this.cbCpp.TabIndex = 13;
            this.cbCpp.Text = "C++";
            this.cbCpp.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(310, 338);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(158, 44);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(173, 239);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(37, 16);
            this.lblDob.TabIndex = 15;
            this.lblDob.Text = "DoB:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 234);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // btnPasswordRelated
            // 
            this.btnPasswordRelated.Location = new System.Drawing.Point(419, 130);
            this.btnPasswordRelated.Name = "btnPasswordRelated";
            this.btnPasswordRelated.Size = new System.Drawing.Size(112, 28);
            this.btnPasswordRelated.TabIndex = 17;
            this.btnPasswordRelated.Text = "Show/Hide";
            this.btnPasswordRelated.UseVisualStyleBackColor = true;
            this.btnPasswordRelated.Click += new System.EventHandler(this.btnPasswordRelated_Click);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(310, 338);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(158, 44);
            this.btnShow.TabIndex = 18;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPasswordRelated);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cbCpp);
            this.Controls.Add(this.cbJava);
            this.Controls.Add(this.cbCSharp);
            this.Controls.Add(this.lblSkills);
            this.Controls.Add(this.rbtnFemale);
            this.Controls.Add(this.rbtnMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShow);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.Label lblSkills;
        private System.Windows.Forms.CheckBox cbCSharp;
        private System.Windows.Forms.CheckBox cbJava;
        private System.Windows.Forms.CheckBox cbCpp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnPasswordRelated;
        private System.Windows.Forms.Button btnShow;
    }
}