namespace Aptean_Edge_Bank
{
    partial class AmountForm
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
            this.Proceedbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.AccountNotextBox = new System.Windows.Forms.TextBox();
            this.AmounttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Proceedbutton
            // 
            this.Proceedbutton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Proceedbutton.Location = new System.Drawing.Point(170, 324);
            this.Proceedbutton.Name = "Proceedbutton";
            this.Proceedbutton.Size = new System.Drawing.Size(134, 38);
            this.Proceedbutton.TabIndex = 0;
            this.Proceedbutton.Text = "Proceed";
            this.Proceedbutton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Account No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(184, 66);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(189, 26);
            this.IDtextBox.TabIndex = 5;
            // 
            // AccountNotextBox
            // 
            this.AccountNotextBox.Location = new System.Drawing.Point(184, 146);
            this.AccountNotextBox.Name = "AccountNotextBox";
            this.AccountNotextBox.Size = new System.Drawing.Size(189, 26);
            this.AccountNotextBox.TabIndex = 7;
            // 
            // AmounttextBox
            // 
            this.AmounttextBox.Location = new System.Drawing.Point(184, 243);
            this.AmounttextBox.Name = "AmounttextBox";
            this.AmounttextBox.Size = new System.Drawing.Size(189, 26);
            this.AmounttextBox.TabIndex = 8;
            // 
            // AmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(463, 409);
            this.Controls.Add(this.AmounttextBox);
            this.Controls.Add(this.AccountNotextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Proceedbutton);
            this.Name = "AmountForm";
            this.Text = "AmountForm";
            this.Load += new System.EventHandler(this.AmountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Proceedbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox AccountNotextBox;
        private System.Windows.Forms.TextBox AmounttextBox;
    }
}