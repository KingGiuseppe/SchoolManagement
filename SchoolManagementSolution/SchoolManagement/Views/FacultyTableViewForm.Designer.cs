﻿namespace SchoolManagement.Views
{
    partial class FacultyTableViewForm
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
            this.facultyDataGridView = new System.Windows.Forms.DataGridView();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // facultyDataGridView
            // 
            this.facultyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facultyDataGridView.Location = new System.Drawing.Point(29, 37);
            this.facultyDataGridView.Name = "facultyDataGridView";
            this.facultyDataGridView.Size = new System.Drawing.Size(466, 215);
            this.facultyDataGridView.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(384, 269);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(111, 35);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // FacultyTableViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 354);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.facultyDataGridView);
            this.Name = "FacultyTableViewForm";
            this.Text = "FacultyTableViewForm";
            this.Load += new System.EventHandler(this.FacultyTableViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultyDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView facultyDataGridView;
        private System.Windows.Forms.Button backBtn;
    }
}