namespace Outsurance.Assessment.WindowsForm
{
    partial class Form1
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
            this.SelectCSVFileLbl = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SelectReportDIrectoryLbl = new System.Windows.Forms.Label();
            this.GetCSVFileBtn = new System.Windows.Forms.Button();
            this.GetReportDirectoryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectCSVFileLbl
            // 
            this.SelectCSVFileLbl.AutoSize = true;
            this.SelectCSVFileLbl.Location = new System.Drawing.Point(12, 9);
            this.SelectCSVFileLbl.Name = "SelectCSVFileLbl";
            this.SelectCSVFileLbl.Size = new System.Drawing.Size(266, 13);
            this.SelectCSVFileLbl.TabIndex = 0;
            this.SelectCSVFileLbl.Text = "Please Select the CSV File with the Persons Particulars";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // SelectReportDIrectoryLbl
            // 
            this.SelectReportDIrectoryLbl.AutoSize = true;
            this.SelectReportDIrectoryLbl.Location = new System.Drawing.Point(12, 73);
            this.SelectReportDIrectoryLbl.Name = "SelectReportDIrectoryLbl";
            this.SelectReportDIrectoryLbl.Size = new System.Drawing.Size(236, 13);
            this.SelectReportDIrectoryLbl.TabIndex = 1;
            this.SelectReportDIrectoryLbl.Text = "Please Select the Ddirectory for the Report Files.";
            // 
            // GetCSVFileBtn
            // 
            this.GetCSVFileBtn.Location = new System.Drawing.Point(15, 25);
            this.GetCSVFileBtn.Name = "GetCSVFileBtn";
            this.GetCSVFileBtn.Size = new System.Drawing.Size(121, 23);
            this.GetCSVFileBtn.TabIndex = 2;
            this.GetCSVFileBtn.Text = "Select CSV File";
            this.GetCSVFileBtn.UseVisualStyleBackColor = true;
            this.GetCSVFileBtn.Click += new System.EventHandler(this.GetCSVFileBtn_Click);
            // 
            // GetReportDirectoryBtn
            // 
            this.GetReportDirectoryBtn.Location = new System.Drawing.Point(15, 89);
            this.GetReportDirectoryBtn.Name = "GetReportDirectoryBtn";
            this.GetReportDirectoryBtn.Size = new System.Drawing.Size(121, 23);
            this.GetReportDirectoryBtn.TabIndex = 3;
            this.GetReportDirectoryBtn.Text = "Select Report Directory";
            this.GetReportDirectoryBtn.UseVisualStyleBackColor = true;
            this.GetReportDirectoryBtn.Click += new System.EventHandler(this.GetReportDirectoryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 148);
            this.Controls.Add(this.GetReportDirectoryBtn);
            this.Controls.Add(this.GetCSVFileBtn);
            this.Controls.Add(this.SelectReportDIrectoryLbl);
            this.Controls.Add(this.SelectCSVFileLbl);
            this.Name = "Form1";
            this.Text = "Outsurance Assessment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectCSVFileLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label SelectReportDIrectoryLbl;
        private System.Windows.Forms.Button GetCSVFileBtn;
        private System.Windows.Forms.Button GetReportDirectoryBtn;
    }
}

