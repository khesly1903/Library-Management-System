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
            btnDueDateCheck = new Button();
            btnStudentHighestCheck = new Button();
            SuspendLayout();
            // 
            // lstReport
            // 
            lstReport.FormattingEnabled = true;
            lstReport.ItemHeight = 28;
            lstReport.Location = new Point(281, 183);
            lstReport.Margin = new Padding(4, 6, 4, 6);
            lstReport.Name = "lstReport";
            lstReport.Size = new Size(651, 368);
            lstReport.TabIndex = 0;
            // 
            // btnDueDateCheck
            // 
            btnDueDateCheck.Location = new Point(490, 32);
            btnDueDateCheck.Name = "btnDueDateCheck";
            btnDueDateCheck.Size = new Size(199, 123);
            btnDueDateCheck.TabIndex = 2;
            btnDueDateCheck.Text = "Tarihi yaklaşanlar";
            btnDueDateCheck.UseVisualStyleBackColor = true;
            btnDueDateCheck.Click += btnDueDateCheck_Click;
            // 
            // btnStudentHighestCheck
            // 
            btnStudentHighestCheck.Location = new Point(285, 32);
            btnStudentHighestCheck.Name = "btnStudentHighestCheck";
            btnStudentHighestCheck.Size = new Size(199, 124);
            btnStudentHighestCheck.TabIndex = 3;
            btnStudentHighestCheck.Text = "En çok okuyana göre sıralama";
            btnStudentHighestCheck.UseVisualStyleBackColor = true;
            btnStudentHighestCheck.Click += btnStudentHighestCheck_Click;
            // 
            // LoanReport
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1234, 611);
            Controls.Add(btnStudentHighestCheck);
            Controls.Add(btnDueDateCheck);
            Controls.Add(lstReport);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            Margin = new Padding(4, 6, 4, 6);
            Name = "LoanReport";
            Text = "LoanReport";
            Load += LoanReport_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstReport;
        private Button btnDueDateCheck;
        private Button btnStudentHighestCheck;
    }
}