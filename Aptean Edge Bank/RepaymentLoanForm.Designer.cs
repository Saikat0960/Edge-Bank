namespace Aptean_Edge_Bank
{
    partial class RepaymentLoanForm
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
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.AccountNotextBox = new System.Windows.Forms.TextBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Proceedbutton = new System.Windows.Forms.Button();
            this.LoantextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Location = new System.Drawing.Point(196, 221);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(189, 26);
            this.AmounttextBox.TabIndex = 15;
            this.AmounttextBox.TextChanged += new System.EventHandler(this.AmounttextBox_TextChanged);
            // 
            // AccountNotextBox
            // 
            this.AccountNotextBox.Location = new System.Drawing.Point(194, 146);
            this.AccountNotextBox.Name = "AccountNotextBox";
            this.AccountNotextBox.ReadOnly = true;
            this.AccountNotextBox.Size = new System.Drawing.Size(189, 26);
            this.AccountNotextBox.TabIndex = 14;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(194, 66);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(189, 26);
            this.IDtextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Account No";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Customer ID";
            // 
            // Proceedbutton
            // 
            this.Proceedbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Proceedbutton.Location = new System.Drawing.Point(166, 375);
            this.Proceedbutton.Name = "Proceedbutton";
            this.Proceedbutton.Size = new System.Drawing.Size(134, 38);
            this.Proceedbutton.TabIndex = 9;
            this.Proceedbutton.Text = "Proceed";
            this.Proceedbutton.UseVisualStyleBackColor = true;
            this.Proceedbutton.Click += new System.EventHandler(this.Proceedbutton_Click);
            // 
            // LoantextBox
            // 
            this.LoantextBox.Location = new System.Drawing.Point(194, 298);
            this.LoantextBox.Name = "LoantextBox";
            this.LoantextBox.ReadOnly = true;
            this.LoantextBox.Size = new System.Drawing.Size(189, 26);
            this.LoantextBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Remaining Loan";
            // 
            // RepaymentLoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoantextBox);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.AccountNotextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Proceedbutton);
            this.Name = "RepaymentLoanForm";
            this.Text = "ReapaymentLoanForm";
            this.Load += new System.EventHandler(this.RepaymentLoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AmounttextBox;
        private System.Windows.Forms.TextBox AccountNotextBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Proceedbutton;
        private System.Windows.Forms.TextBox LoantextBox;
        private System.Windows.Forms.Label label2;
    }
}