﻿
namespace MediaBazaar
{
    partial class FormRemoveEmployee
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxReasonTermination = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpContractEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reason for termination:";
            // 
            // tbxReasonTermination
            // 
            this.tbxReasonTermination.Location = new System.Drawing.Point(166, 51);
            this.tbxReasonTermination.Name = "tbxReasonTermination";
            this.tbxReasonTermination.Size = new System.Drawing.Size(139, 23);
            this.tbxReasonTermination.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contract end date:";
            // 
            // dtpContractEndDate
            // 
            this.dtpContractEndDate.Location = new System.Drawing.Point(166, 101);
            this.dtpContractEndDate.Name = "dtpContractEndDate";
            this.dtpContractEndDate.Size = new System.Drawing.Size(139, 23);
            this.dtpContractEndDate.TabIndex = 3;
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(64, 9);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(256, 25);
            this.lblEmployee.TabIndex = 4;
            this.lblEmployee.Text = "<Employee ID> <Employee>";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormRemoveEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 177);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.dtpContractEndDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxReasonTermination);
            this.Controls.Add(this.label1);
            this.Name = "FormRemoveEmployee";
            this.Text = "FormRemoveEmployee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxReasonTermination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpContractEndDate;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button button1;
    }
}