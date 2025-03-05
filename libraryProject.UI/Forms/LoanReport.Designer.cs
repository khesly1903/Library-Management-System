namespace libraryProject.UI.Forms
{
    partial class LoanReport
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
            lstReport = new ListBox();
            SuspendLayout();
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.ItemHeight = 15;
            lstReport.Location = new Point(165, 125);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(457, 199);
            lstReport.TabIndex = 0;
            // 
            // LoanReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstReport);
            Name = "LoanReport";
            Text = "LoanReport";
            Load += LoanReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstReport;
    }
}