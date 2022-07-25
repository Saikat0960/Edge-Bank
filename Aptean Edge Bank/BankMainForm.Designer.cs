namespace Aptean_Edge_Bank
{
    partial class BankMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Timelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exitbutton = new System.Windows.Forms.Button();
            this.BankInfobutton = new System.Windows.Forms.Button();
            this.CustomerLoginbutton = new System.Windows.Forms.Button();
            this.Adminbutton = new System.Windows.Forms.Button();
            this.DescriptiontextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.Timelabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 132);
            this.panel1.TabIndex = 0;
            // 
            // Timelabel
            // 
            this.Timelabel.AutoSize = true;
            this.Timelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timelabel.Location = new System.Drawing.Point(663, 41);
            this.Timelabel.Name = "Timelabel";
            this.Timelabel.Size = new System.Drawing.Size(99, 32);
            this.Timelabel.TabIndex = 1;
            this.Timelabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aptean Edge Bank";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.Exitbutton);
            this.panel2.Controls.Add(this.BankInfobutton);
            this.panel2.Controls.Add(this.CustomerLoginbutton);
            this.panel2.Controls.Add(this.Adminbutton);
            this.panel2.Controls.Add(this.DescriptiontextBox);
            this.panel2.Location = new System.Drawing.Point(0, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1047, 610);
            this.panel2.TabIndex = 1;
            // 
            // Exitbutton
            // 
            this.Exitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exitbutton.Location = new System.Drawing.Point(869, 504);
            this.Exitbutton.Name = "Exitbutton";
            this.Exitbutton.Size = new System.Drawing.Size(121, 40);
            this.Exitbutton.TabIndex = 8;
            this.Exitbutton.Text = "Exit";
            this.Exitbutton.UseVisualStyleBackColor = true;
            this.Exitbutton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // BankInfobutton
            // 
            this.BankInfobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankInfobutton.Location = new System.Drawing.Point(637, 355);
            this.BankInfobutton.Name = "BankInfobutton";
            this.BankInfobutton.Size = new System.Drawing.Size(246, 49);
            this.BankInfobutton.TabIndex = 7;
            this.BankInfobutton.Text = "Show Bank Info";
            this.BankInfobutton.UseVisualStyleBackColor = true;
            this.BankInfobutton.Click += new System.EventHandler(this.BankInfobutton_Click);
            // 
            // CustomerLoginbutton
            // 
            this.CustomerLoginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLoginbutton.Image = global::Aptean_Edge_Bank.Properties.Resources.LoginStatus_16x;
            this.CustomerLoginbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerLoginbutton.Location = new System.Drawing.Point(637, 226);
            this.CustomerLoginbutton.Name = "CustomerLoginbutton";
            this.CustomerLoginbutton.Size = new System.Drawing.Size(246, 53);
            this.CustomerLoginbutton.TabIndex = 6;
            this.CustomerLoginbutton.Text = "Customer Login";
            this.CustomerLoginbutton.UseVisualStyleBackColor = true;
            this.CustomerLoginbutton.Click += new System.EventHandler(this.CustomerLoginbutton_Click);
            // 
            // Adminbutton
            // 
            this.Adminbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbutton.Image = global::Aptean_Edge_Bank.Properties.Resources.LoginStatus_16x;
            this.Adminbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Adminbutton.Location = new System.Drawing.Point(637, 100);
            this.Adminbutton.Name = "Adminbutton";
            this.Adminbutton.Size = new System.Drawing.Size(246, 53);
            this.Adminbutton.TabIndex = 1;
            this.Adminbutton.Text = "Admin Login";
            this.Adminbutton.UseVisualStyleBackColor = true;
            this.Adminbutton.Click += new System.EventHandler(this.Adminbutton_Click);
            // 
            // DescriptiontextBox
            // 
            this.DescriptiontextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptiontextBox.Location = new System.Drawing.Point(51, 44);
            this.DescriptiontextBox.Multiline = true;
            this.DescriptiontextBox.Name = "DescriptiontextBox";
            this.DescriptiontextBox.ReadOnly = true;
            this.DescriptiontextBox.Size = new System.Drawing.Size(509, 438);
            this.DescriptiontextBox.TabIndex = 5;
            this.DescriptiontextBox.Text = resources.GetString("DescriptiontextBox.Text");
            // 
            // BankMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 747);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "BankMainForm";
            this.Text = "BankMainForm";
            this.Load += new System.EventHandler(this.BankMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Adminbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox DescriptiontextBox;
        private System.Windows.Forms.Button CustomerLoginbutton;
        private System.Windows.Forms.Label Timelabel;
        private System.Windows.Forms.Button BankInfobutton;
        private System.Windows.Forms.Button Exitbutton;
    }
}