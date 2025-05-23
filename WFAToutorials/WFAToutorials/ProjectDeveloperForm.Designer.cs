namespace WFAToutorials
{
    partial class ProjectDeveloperForm
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
            this.rbtnCs = new System.Windows.Forms.RadioButton();
            this.rbtnJava = new System.Windows.Forms.RadioButton();
            this.rbtnCpp = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbtnCs
            // 
            this.rbtnCs.AutoSize = true;
            this.rbtnCs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCs.Location = new System.Drawing.Point(333, 151);
            this.rbtnCs.Name = "rbtnCs";
            this.rbtnCs.Size = new System.Drawing.Size(135, 24);
            this.rbtnCs.TabIndex = 0;
            this.rbtnCs.TabStop = true;
            this.rbtnCs.Text = "C# Developer";
            this.rbtnCs.UseVisualStyleBackColor = true;
            // 
            // rbtnJava
            // 
            this.rbtnJava.AutoSize = true;
            this.rbtnJava.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnJava.Location = new System.Drawing.Point(333, 194);
            this.rbtnJava.Name = "rbtnJava";
            this.rbtnJava.Size = new System.Drawing.Size(140, 24);
            this.rbtnJava.TabIndex = 2;
            this.rbtnJava.TabStop = true;
            this.rbtnJava.Text = "Java Develper\r\n";
            this.rbtnJava.UseVisualStyleBackColor = true;
            // 
            // rbtnCpp
            // 
            this.rbtnCpp.AutoSize = true;
            this.rbtnCpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCpp.Location = new System.Drawing.Point(333, 240);
            this.rbtnCpp.Name = "rbtnCpp";
            this.rbtnCpp.Size = new System.Drawing.Size(145, 24);
            this.rbtnCpp.TabIndex = 3;
            this.rbtnCpp.TabStop = true;
            this.rbtnCpp.Text = "C++ Developer";
            this.rbtnCpp.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(578, 372);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 40);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ProjectDeveloperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rbtnCpp);
            this.Controls.Add(this.rbtnJava);
            this.Controls.Add(this.rbtnCs);
            this.Name = "ProjectDeveloperForm";
            this.Text = "ProjectDeveloperForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectDeveloperForm_FormClosing);
            this.Load += new System.EventHandler(this.ProjectDeveloperForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtnCs;
        private System.Windows.Forms.RadioButton rbtnJava;
        private System.Windows.Forms.RadioButton rbtnCpp;
        private System.Windows.Forms.Button btnSubmit;
    }
}