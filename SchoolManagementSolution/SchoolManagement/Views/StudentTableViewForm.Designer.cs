﻿
namespace SchoolManagement.Views
{
    partial class StudentTableViewForm
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
            this.backBtn = new System.Windows.Forms.Button();
            this.StudentTableGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(635, 224);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(87, 39);
            this.backBtn.TabIndex = 1;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StudentTableGrid
            // 
            this.StudentTableGrid.AllowUserToAddRows = false;
            this.StudentTableGrid.AllowUserToDeleteRows = false;
            this.StudentTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentTableGrid.Location = new System.Drawing.Point(34, 27);
            this.StudentTableGrid.Name = "StudentTableGrid";
            this.StudentTableGrid.ReadOnly = true;
            this.StudentTableGrid.Size = new System.Drawing.Size(688, 182);
            this.StudentTableGrid.TabIndex = 2;
            // 
            // StudentTableViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 310);
            this.Controls.Add(this.StudentTableGrid);
            this.Controls.Add(this.backBtn);
            this.Name = "StudentTableViewForm";
            this.Text = "StudentTableViewForm";
            this.Load += new System.EventHandler(this.StudentTableViewForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentTableGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.DataGridView StudentTableGrid;
    }
}