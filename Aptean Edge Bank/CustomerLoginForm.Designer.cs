namespace Aptean_Edge_Bank
{
    partial class CustomerLoginForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.ChangePasswordbutton = new System.Windows.Forms.Button();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreditDebitbutton = new System.Windows.Forms.Button();
            this.Loanbutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Withdrawbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.Closebutton);
            this.panel2.Controls.Add(this.ChangePasswordbutton);
            this.panel2.Controls.Add(this.IDtextBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.CreditDebitbutton);
            this.panel2.Controls.Add(this.Loanbutton);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Withdrawbutton);
            this.panel2.Location = new System.Drawing.Point(-61, -5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(987, 503);
            this.panel2.TabIndex = 2;
            // 
            // ChangePasswordbutton
            // 
            this.ChangePasswordbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangePasswordbutton.Location = new System.Drawing.Point(732, 59);
            this.ChangePasswordbutton.Name = "ChangePasswordbutton";
            this.ChangePasswordbutton.Size = new System.Drawing.Size(182, 42);
            this.ChangePasswordbutton.TabIndex = 14;
            this.ChangePasswordbutton.Text = "Change Password";
            this.ChangePasswordbutton.UseVisualStyleBackColor = true;
            this.ChangePasswordbutton.Click += new System.EventHandler(this.ChangePasswordbutton_Click);
            // 
            // IDtextBox
            // 
            this.IDtextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IDtextBox.Location = new System.Drawing.Point(323, 67);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(240, 26);
            this.IDtextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Customer ID";
            // 
            // CreditDebitbutton
            // 
            this.CreditDebitbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditDebitbutton.Image = global::Aptean_Edge_Bank.Properties.Resources.InformationSymbol_16x;
            this.CreditDebitbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CreditDebitbutton.Location = new System.Drawing.Point(747, 194);
            this.CreditDebitbutton.Name = "CreditDebitbutton";
            this.CreditDebitbutton.Size = new System.Drawing.Size(148, 50);
            this.CreditDebitbutton.TabIndex = 4;
            this.CreditDebitbutton.Text = "Credit Debit";
            this.CreditDebitbutton.UseVisualStyleBackColor = true;
            this.CreditDebitbutton.Click += new System.EventHandler(this.CreditDebitbutton_Click);
            // 
            // Loanbutton
            // 
            this.Loanbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loanbutton.Image = global::Aptean_Edge_Bank.Properties.Resources.MoneyEditor_16x;
            this.Loanbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loanbutton.Location = new System.Drawing.Point(541, 193);
            this.Loanbutton.Name = "Loanbutton";
            this.Loanbutton.Size = new System.Drawing.Size(154, 50);
            this.Loanbutton.TabIndex = 3;
            this.Loanbutton.Text = "Loan Info";
            this.Loanbutton.UseVisualStyleBackColor = true;
            this.Loanbutton.Click += new System.EventHandler(this.Loanbutton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(420, 295);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 68);
            this.button4.TabIndex = 2;
            this.button4.Text = "Show All Accounts";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::Aptean_Edge_Bank.Properties.Resources.TransactionalComponent_16x;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(336, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 51);
            this.button3.TabIndex = 1;
            this.button3.Text = "Deposit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Withdrawbutton
            // 
            this.Withdrawbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdrawbutton.Image = global::Aptean_Edge_Bank.Properties.Resources.TransactionScope_16x;
            this.Withdrawbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Withdrawbutton.Location = new System.Drawing.Point(127, 193);
            this.Withdrawbutton.Name = "Withdrawbutton";
            this.Withdrawbutton.Size = new System.Drawing.Size(154, 51);
            this.Withdrawbutton.TabIndex = 0;
            this.Withdrawbutton.Text = "Withdraw";
            this.Withdrawbutton.UseVisualStyleBackColor = true;
            this.Withdrawbutton.Click += new System.EventHandler(this.Withdrawbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(767, 415);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(147, 37);
            this.Closebutton.TabIndex = 15;
            this.Closebutton.Text = "Logout";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // CustomerLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(926, 496);
            this.Controls.Add(this.panel2);
            this.Name = "CustomerLoginForm";
            this.Text = "CustomerLoginForm";
            this.Load += new System.EventHandler(this.CustomerLoginForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button CreditDebitbutton;
        private System.Windows.Forms.Button Loanbutton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Withdrawbutton;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChangePasswordbutton;
        private System.Windows.Forms.Button Closebutton;
    }
}