
namespace Week4LabGui
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.ValidationBtn = new System.Windows.Forms.Button();
            this.ssnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SSNValBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is your phone number?";

            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(358, 399);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(282, 200);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 2;
            // 
            // ValidationBtn
            // 
            this.ValidationBtn.Location = new System.Drawing.Point(529, 194);
            this.ValidationBtn.Name = "ValidationBtn";
            this.ValidationBtn.Size = new System.Drawing.Size(208, 31);
            this.ValidationBtn.TabIndex = 3;
            this.ValidationBtn.Text = "Check if Valid";
            this.ValidationBtn.UseVisualStyleBackColor = true;
            this.ValidationBtn.Click += new System.EventHandler(this.ValidationBtn_Click);
            // 
            // ssnName
            // 
            this.ssnName.Location = new System.Drawing.Point(282, 137);
            this.ssnName.Name = "ssnName";
            this.ssnName.Size = new System.Drawing.Size(208, 20);
            this.ssnName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "What is your Social Security #";
            // 
            // SSNValBtn
            // 
            this.SSNValBtn.Location = new System.Drawing.Point(529, 131);
            this.SSNValBtn.Name = "SSNValBtn";
            this.SSNValBtn.Size = new System.Drawing.Size(208, 31);
            this.SSNValBtn.TabIndex = 6;
            this.SSNValBtn.Text = "Check if Valid";
            this.SSNValBtn.UseVisualStyleBackColor = true;
            this.SSNValBtn.Click += new System.EventHandler(this.SSNValBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SSNValBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ssnName);
            this.Controls.Add(this.ValidationBtn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button ValidationBtn;
        private System.Windows.Forms.TextBox ssnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SSNValBtn;
    }
}

