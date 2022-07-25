using System;

namespace Aptean_Edge_Bank
{
    partial class EdgeBank
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolstripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AddusertoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.DeleteusertoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UpdatetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.CustomerListBox = new System.Windows.Forms.ListBox();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.BirthdatetextBox = new System.Windows.Forms.TextBox();
            this.DOJtextBox = new System.Windows.Forms.TextBox();
            this.AddresstextBox = new System.Windows.Forms.TextBox();
            this.StatustextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Loanbutton = new System.Windows.Forms.Button();
            this.AccountDetailsbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolstripLabel,
            this.toolStripSeparator2,
            this.toolStripSeparator1,
            this.AddusertoolStripButton,
            this.DeleteusertoolStripButton,
            this.UpdatetoolStripButton,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(843, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolstripLabel
            // 
            this.ToolstripLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolstripLabel.Name = "ToolstripLabel";
            this.ToolstripLabel.Size = new System.Drawing.Size(169, 33);
            this.ToolstripLabel.Text = "Aptean Edge Bank";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // AddusertoolStripButton
            // 
            this.AddusertoolStripButton.Image = global::Aptean_Edge_Bank.Properties.Resources.AddUser_16x;
            this.AddusertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddusertoolStripButton.Name = "AddusertoolStripButton";
            this.AddusertoolStripButton.Size = new System.Drawing.Size(156, 33);
            this.AddusertoolStripButton.Text = "Add Customer";
            this.AddusertoolStripButton.Click += new System.EventHandler(this.AddusertoolStripButton_Click);
            // 
            // DeleteusertoolStripButton
            // 
            this.DeleteusertoolStripButton.Image = global::Aptean_Edge_Bank.Properties.Resources.DeleteUser_16x;
            this.DeleteusertoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteusertoolStripButton.Name = "DeleteusertoolStripButton";
            this.DeleteusertoolStripButton.Size = new System.Drawing.Size(186, 33);
            this.DeleteusertoolStripButton.Text = "Remove Customer";
            this.DeleteusertoolStripButton.Click += new System.EventHandler(this.DeleteusertoolStripButton_Click);
            // 
            // UpdatetoolStripButton
            // 
            this.UpdatetoolStripButton.Image = global::Aptean_Edge_Bank.Properties.Resources.UpdateLinkedTable_16x;
            this.UpdatetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UpdatetoolStripButton.Name = "UpdatetoolStripButton";
            this.UpdatetoolStripButton.Size = new System.Drawing.Size(180, 33);
            this.UpdatetoolStripButton.Text = "Update Customer";
            this.UpdatetoolStripButton.Click += new System.EventHandler(this.UpdatetoolStripButton_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::Aptean_Edge_Bank.Properties.Resources.Refresh_16x;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 33);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // CustomerListBox
            // 
            this.CustomerListBox.FormattingEnabled = true;
            this.CustomerListBox.ItemHeight = 20;
            this.CustomerListBox.Location = new System.Drawing.Point(21, 55);
            this.CustomerListBox.Name = "CustomerListBox";
            this.CustomerListBox.Size = new System.Drawing.Size(372, 324);
            this.CustomerListBox.TabIndex = 1;
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(561, 55);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.ReadOnly = true;
            this.IDtextBox.Size = new System.Drawing.Size(230, 26);
            this.IDtextBox.TabIndex = 2;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(561, 104);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.ReadOnly = true;
            this.NametextBox.Size = new System.Drawing.Size(230, 26);
            this.NametextBox.TabIndex = 3;
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.Location = new System.Drawing.Point(561, 159);
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(230, 26);
            this.ContacttextBox.TabIndex = 4;
            // 
            // BirthdatetextBox
            // 
            this.BirthdatetextBox.Location = new System.Drawing.Point(561, 212);
            this.BirthdatetextBox.Name = "BirthdatetextBox";
            this.BirthdatetextBox.Size = new System.Drawing.Size(230, 26);
            this.BirthdatetextBox.TabIndex = 5;
            // 
            // DOJtextBox
            // 
            this.DOJtextBox.Location = new System.Drawing.Point(561, 271);
            this.DOJtextBox.Name = "DOJtextBox";
            this.DOJtextBox.ReadOnly = true;
            this.DOJtextBox.Size = new System.Drawing.Size(230, 26);
            this.DOJtextBox.TabIndex = 6;
            // 
            // AddresstextBox
            // 
            this.AddresstextBox.Location = new System.Drawing.Point(561, 326);
            this.AddresstextBox.Multiline = true;
            this.AddresstextBox.Name = "AddresstextBox";
            this.AddresstextBox.Size = new System.Drawing.Size(230, 88);
            this.AddresstextBox.TabIndex = 7;
            // 
            // StatustextBox
            // 
            this.StatustextBox.Location = new System.Drawing.Point(561, 442);
            this.StatustextBox.Name = "StatustextBox";
            this.StatustextBox.ReadOnly = true;
            this.StatustextBox.Size = new System.Drawing.Size(230, 26);
            this.StatustextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(436, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(436, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(436, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Birthdate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Date Of Joining";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Active Status";
            // 
            // Loanbutton
            // 
            this.Loanbutton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Loanbutton.Image = global::Aptean_Edge_Bank.Properties.Resources.CopyLongTextToClipboard_16x;
            this.Loanbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Loanbutton.Location = new System.Drawing.Point(127, 490);
            this.Loanbutton.Name = "Loanbutton";
            this.Loanbutton.Size = new System.Drawing.Size(157, 44);
            this.Loanbutton.TabIndex = 17;
            this.Loanbutton.Text = "Issue Loan";
            this.Loanbutton.UseVisualStyleBackColor = false;
            this.Loanbutton.Click += new System.EventHandler(this.Loanbutton_Click);
            // 
            // AccountDetailsbutton
            // 
            this.AccountDetailsbutton.Image = global::Aptean_Edge_Bank.Properties.Resources.ShowAllFiles_16x;
            this.AccountDetailsbutton.Location = new System.Drawing.Point(106, 422);
            this.AccountDetailsbutton.Name = "AccountDetailsbutton";
            this.AccountDetailsbutton.Size = new System.Drawing.Size(208, 46);
            this.AccountDetailsbutton.TabIndex = 16;
            this.AccountDetailsbutton.Text = "Show Account Details";
            this.AccountDetailsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AccountDetailsbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AccountDetailsbutton.UseVisualStyleBackColor = true;
            this.AccountDetailsbutton.Click += new System.EventHandler(this.AccountDetailsbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(586, 518);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(167, 33);
            this.Closebutton.TabIndex = 18;
            this.Closebutton.Text = "Logout";
            this.Closebutton.UseVisualStyleBackColor = true;
            this.Closebutton.Click += new System.EventHandler(this.Closebutton_Click);
            // 
            // EdgeBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(843, 578);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Loanbutton);
            this.Controls.Add(this.AccountDetailsbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatustextBox);
            this.Controls.Add(this.AddresstextBox);
            this.Controls.Add(this.DOJtextBox);
            this.Controls.Add(this.BirthdatetextBox);
            this.Controls.Add(this.ContacttextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.CustomerListBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "EdgeBank";
            this.Text = "BankApp";
            this.Load += new System.EventHandler(this.EdgeBank_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel ToolstripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton AddusertoolStripButton;
        private System.Windows.Forms.ToolStripButton DeleteusertoolStripButton;
        private System.Windows.Forms.ListBox CustomerListBox;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox ContacttextBox;
        private System.Windows.Forms.TextBox BirthdatetextBox;
        private System.Windows.Forms.TextBox DOJtextBox;
        private System.Windows.Forms.TextBox AddresstextBox;
        private System.Windows.Forms.TextBox StatustextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button AccountDetailsbutton;
        private System.Windows.Forms.ToolStripButton UpdatetoolStripButton;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button Loanbutton;
        private System.Windows.Forms.Button Closebutton;
    }
}

