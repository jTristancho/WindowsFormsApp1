namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRUN = new System.Windows.Forms.Button();
            this.txbMSN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRUN
            // 
            this.btnRUN.Location = new System.Drawing.Point(194, 176);
            this.btnRUN.Name = "btnRUN";
            this.btnRUN.Size = new System.Drawing.Size(75, 23);
            this.btnRUN.TabIndex = 0;
            this.btnRUN.Text = "&Run";
            this.btnRUN.UseVisualStyleBackColor = true;
            this.btnRUN.Click += new System.EventHandler(this.btnRUN_Click);
            // 
            // txbMSN
            // 
            this.txbMSN.Location = new System.Drawing.Point(13, 13);
            this.txbMSN.Multiline = true;
            this.txbMSN.Name = "txbMSN";
            this.txbMSN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbMSN.Size = new System.Drawing.Size(256, 157);
            this.txbMSN.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 211);
            this.Controls.Add(this.txbMSN);
            this.Controls.Add(this.btnRUN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "My First GitHub Repository";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRUN;
        private System.Windows.Forms.TextBox txbMSN;
    }
}

