namespace Aptean_Edge_Bank
{
    partial class LoanForm
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
            this.Repaymentbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountNotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Repaymentbutton
            // 
            this.Repaymentbutton.Location = new System.Drawing.Point(241, 288);
            this.Repaymentbutton.Name = "Repaymentbutton";
            this.Repaymentbutton.Size = new System.Drawing.Size(148, 39);
            this.Repaymentbutton.TabIndex = 0;
            this.Repaymentbutton.Text = "Repayment";
            this.Repaymentbutton.UseVisualStyleBackColor = true;
            this.Repaymentbutton.Click += new System.EventHandler(this.Repaymentbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // IDtextBox
            // 
            this.IDtextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IDtextBox.Location = new System.Drawing.Point(283, 69);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(240, 26);
            this.IDtextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loan Amount";
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Location = new System.Drawing.Point(283, 185);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.ReadOnly = true;
            this.AmounttextBox.Size = new System.Drawing.Size(240, 26);
            this.AmounttextBox.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account No";
            // 
            // AccountNotextBox
            // 
            this.AccountNotextBox.Location = new System.Drawing.Point(283, 128);
            this.AccountNotextBox.Name = "AccountNotextBox";
            this.AccountNotextBox.ReadOnly = true;
            this.AccountNotextBox.Size = new System.Drawing.Size(240, 26);
            this.AccountNotextBox.TabIndex = 5;
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(674, 403);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.AccountNotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Repaymentbutton);
            this.Name = "LoanForm";
            this.Text = "LoanForm";
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Repaymentbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountNotextBox;
    }
}