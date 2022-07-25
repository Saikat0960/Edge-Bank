namespace Aptean_Edge_Bank
{
    partial class AddAccount
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerIDtextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Chequing = new System.Windows.Forms.RadioButton();
            this.Taxfree = new System.Windows.Forms.RadioButton();
            this.Liability = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(151, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(287, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Account Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Custmoer ID";
            // 
            // CustomerIDtextBox
            // 
            this.CustomerIDtextBox.Location = new System.Drawing.Point(216, 76);
            this.CustomerIDtextBox.Name = "CustomerIDtextBox";
            this.CustomerIDtextBox.ReadOnly = true;
            this.CustomerIDtextBox.Size = new System.Drawing.Size(159, 26);
            this.CustomerIDtextBox.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(436, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Chequing
            // 
            this.Chequing.AutoSize = true;
            this.Chequing.Location = new System.Drawing.Point(216, 162);
            this.Chequing.Name = "Chequing";
            this.Chequing.Size = new System.Drawing.Size(102, 24);
            this.Chequing.TabIndex = 9;
            this.Chequing.TabStop = true;
            this.Chequing.Text = "Chequing";
            this.Chequing.UseVisualStyleBackColor = true;
            // 
            // Taxfree
            // 
            this.Taxfree.AutoSize = true;
            this.Taxfree.Location = new System.Drawing.Point(216, 202);
            this.Taxfree.Name = "Taxfree";
            this.Taxfree.Size = new System.Drawing.Size(87, 24);
            this.Taxfree.TabIndex = 10;
            this.Taxfree.TabStop = true;
            this.Taxfree.Text = "Taxfree";
            this.Taxfree.UseVisualStyleBackColor = true;
            // 
            // Liability
            // 
            this.Liability.AutoSize = true;
            this.Liability.Location = new System.Drawing.Point(216, 242);
            this.Liability.Name = "Liability";
            this.Liability.Size = new System.Drawing.Size(85, 24);
            this.Liability.TabIndex = 11;
            this.Liability.TabStop = true;
            this.Liability.Text = "Liability";
            this.Liability.UseVisualStyleBackColor = true;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 378);
            this.Controls.Add(this.Liability);
            this.Controls.Add(this.Taxfree);
            this.Controls.Add(this.Chequing);
            this.Controls.Add(this.CustomerIDtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AddAccount";
            this.Text = "Add Account";
            this.Load += new System.EventHandler(this.AddAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerIDtextBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.RadioButton Chequing;
        private System.Windows.Forms.RadioButton Taxfree;
        private System.Windows.Forms.RadioButton Liability;
    }
}