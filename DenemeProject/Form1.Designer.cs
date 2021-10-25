
namespace DenemeProject
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
            this.tbx_Date = new System.Windows.Forms.TextBox();
            this.tbx_Time = new System.Windows.Forms.TextBox();
            this.tbx_SerialNumber = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_Date
            // 
            this.tbx_Date.Location = new System.Drawing.Point(109, 54);
            this.tbx_Date.Name = "tbx_Date";
            this.tbx_Date.Size = new System.Drawing.Size(100, 22);
            this.tbx_Date.TabIndex = 0;
            // 
            // tbx_Time
            // 
            this.tbx_Time.Location = new System.Drawing.Point(109, 109);
            this.tbx_Time.Name = "tbx_Time";
            this.tbx_Time.Size = new System.Drawing.Size(100, 22);
            this.tbx_Time.TabIndex = 1;
            // 
            // tbx_SerialNumber
            // 
            this.tbx_SerialNumber.Location = new System.Drawing.Point(109, 164);
            this.tbx_SerialNumber.Name = "tbx_SerialNumber";
            this.tbx_SerialNumber.Size = new System.Drawing.Size(100, 22);
            this.tbx_SerialNumber.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 68);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbx_SerialNumber);
            this.Controls.Add(this.tbx_Time);
            this.Controls.Add(this.tbx_Date);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_Date;
        private System.Windows.Forms.TextBox tbx_Time;
        private System.Windows.Forms.TextBox tbx_SerialNumber;
        private System.Windows.Forms.Button button1;
    }
}

