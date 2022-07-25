namespace Aptean_Edge_Bank
{
    partial class CreditDebitForm
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
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ActivityDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IDtextBox
            // 
            this.IDtextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IDtextBox.Location = new System.Drawing.Point(174, 38);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(240, 26);
            this.IDtextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer ID";
            // 
            // ActivityDataGridView
            // 
            this.ActivityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActivityDataGridView.Location = new System.Drawing.Point(12, 83);
            this.ActivityDataGridView.Name = "ActivityDataGridView";
            this.ActivityDataGridView.RowHeadersWidth = 62;
            this.ActivityDataGridView.RowTemplate.Height = 28;
            this.ActivityDataGridView.Size = new System.Drawing.Size(842, 359);
            this.ActivityDataGridView.TabIndex = 9;
            // 
            // CreditDebitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 454);
            this.Controls.Add(this.ActivityDataGridView);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label1);
            this.Name = "CreditDebitForm";
            this.Text = "CreditDebitForm";
            this.Load += new System.EventHandler(this.CreditDebitForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ActivityDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ActivityDataGridView;
    }
}