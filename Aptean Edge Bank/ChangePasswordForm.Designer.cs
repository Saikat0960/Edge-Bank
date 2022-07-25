namespace Aptean_Edge_Bank
{
    partial class ChangePasswordForm
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
            this.NewPasstextBox = new System.Windows.Forms.TextBox();
            this.CurrentPasstextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Proceedbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPasstextBox
            // 
            this.NewPasstextBox.Location = new System.Drawing.Point(223, 254);
            this.NewPasstextBox.Name = "NewPasstextBox";
            this.NewPasstextBox.Size = new System.Drawing.Size(189, 26);
            this.NewPasstextBox.TabIndex = 15;
            // 
            // CurrentPasstextBox
            // 
            this.CurrentPasstextBox.Location = new System.Drawing.Point(223, 157);
            this.CurrentPasstextBox.Name = "CurrentPasstextBox";
            this.CurrentPasstextBox.Size = new System.Drawing.Size(189, 26);
            this.CurrentPasstextBox.TabIndex = 14;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(223, 77);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(189, 26);
            this.IDtextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Current Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer ID";
            // 
            // Proceedbutton
            // 
            this.Proceedbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Proceedbutton.Location = new System.Drawing.Point(209, 335);
            this.Proceedbutton.Name = "Proceedbutton";
            this.Proceedbutton.Size = new System.Drawing.Size(134, 38);
            this.Proceedbutton.TabIndex = 9;
            this.Proceedbutton.Text = "Change";
            this.Proceedbutton.UseVisualStyleBackColor = true;
            this.Proceedbutton.Click += new System.EventHandler(this.Proceedbutton_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.Controls.Add(this.NewPasstextBox);
            this.Controls.Add(this.CurrentPasstextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Proceedbutton);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NewPasstextBox;
        private System.Windows.Forms.TextBox CurrentPasstextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Proceedbutton;
    }
}