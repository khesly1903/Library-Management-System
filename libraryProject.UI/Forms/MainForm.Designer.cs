namespace libraryProject.UI.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnGoStudentAddForm;
        private System.Windows.Forms.Button btnGoAuthorAddForm;
        private System.Windows.Forms.Button btnGoBookAddForm;
        private System.Windows.Forms.Button btnGoPublisherAddForm;
        private System.Windows.Forms.Button btnGoLoanForm;
        private System.Windows.Forms.Panel mainPanel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnGoStudentAddForm = new Button();
            btnGoAuthorAddForm = new Button();
            btnGoBookAddForm = new Button();
            btnGoPublisherAddForm = new Button();
            btnGoLoanForm = new Button();
            mainPanel = new Panel();
            btnGoReturnForm = new Button();
            btnGoReport = new Button();
            SuspendLayout();
            // 
            // btnGoStudentAddForm
            // 
            btnGoStudentAddForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoStudentAddForm.FlatStyle = FlatStyle.Flat;
            btnGoStudentAddForm.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGoStudentAddForm.ForeColor = Color.White;
            btnGoStudentAddForm.Location = new Point(538, 12);
            btnGoStudentAddForm.Name = "btnGoStudentAddForm";
            btnGoStudentAddForm.Size = new Size(250, 40);
            btnGoStudentAddForm.TabIndex = 0;
            btnGoStudentAddForm.Text = "Öğrenci";
            btnGoStudentAddForm.UseVisualStyleBackColor = false;
            btnGoStudentAddForm.Click += btnGoStudentAddForm_Click;
            // 
            // btnGoAuthorAddForm
            // 
            btnGoAuthorAddForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoAuthorAddForm.FlatStyle = FlatStyle.Flat;
            btnGoAuthorAddForm.ForeColor = Color.White;
            btnGoAuthorAddForm.Location = new Point(794, 12);
            btnGoAuthorAddForm.Name = "btnGoAuthorAddForm";
            btnGoAuthorAddForm.Size = new Size(250, 40);
            btnGoAuthorAddForm.TabIndex = 1;
            btnGoAuthorAddForm.Text = "Yazar ";
            btnGoAuthorAddForm.UseVisualStyleBackColor = false;
            btnGoAuthorAddForm.Click += btnGoAuthorAddForm_Click;
            // 
            // btnGoBookAddForm
            // 
            btnGoBookAddForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoBookAddForm.FlatStyle = FlatStyle.Flat;
            btnGoBookAddForm.ForeColor = Color.White;
            btnGoBookAddForm.Location = new Point(538, 58);
            btnGoBookAddForm.Name = "btnGoBookAddForm";
            btnGoBookAddForm.Size = new Size(250, 40);
            btnGoBookAddForm.TabIndex = 2;
            btnGoBookAddForm.Text = "Kitap ";
            btnGoBookAddForm.UseVisualStyleBackColor = false;
            btnGoBookAddForm.Click += btnGoBookAddForm_Click;
            // 
            // btnGoPublisherAddForm
            // 
            btnGoPublisherAddForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoPublisherAddForm.FlatStyle = FlatStyle.Flat;
            btnGoPublisherAddForm.ForeColor = Color.White;
            btnGoPublisherAddForm.Location = new Point(794, 58);
            btnGoPublisherAddForm.Name = "btnGoPublisherAddForm";
            btnGoPublisherAddForm.Size = new Size(250, 40);
            btnGoPublisherAddForm.TabIndex = 3;
            btnGoPublisherAddForm.Text = "Yayınevi ";
            btnGoPublisherAddForm.UseVisualStyleBackColor = false;
            btnGoPublisherAddForm.Click += btnGoPublisherAddForm_Click;
            // 
            // btnGoLoanForm
            // 
            btnGoLoanForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoLoanForm.FlatStyle = FlatStyle.Flat;
            btnGoLoanForm.ForeColor = Color.White;
            btnGoLoanForm.Location = new Point(12, 12);
            btnGoLoanForm.Name = "btnGoLoanForm";
            btnGoLoanForm.Size = new Size(250, 40);
            btnGoLoanForm.TabIndex = 4;
            btnGoLoanForm.Text = "Kitap Ver";
            btnGoLoanForm.UseVisualStyleBackColor = false;
            btnGoLoanForm.Click += btnGoLoanForm_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(12, 127);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1035, 472);
            mainPanel.TabIndex = 5;
            // 
            // btnGoReturnForm
            // 
            btnGoReturnForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoReturnForm.FlatStyle = FlatStyle.Flat;
            btnGoReturnForm.ForeColor = Color.White;
            btnGoReturnForm.Location = new Point(12, 58);
            btnGoReturnForm.Name = "btnGoReturnForm";
            btnGoReturnForm.Size = new Size(250, 40);
            btnGoReturnForm.TabIndex = 6;
            btnGoReturnForm.Text = "Kitap Al";
            btnGoReturnForm.UseVisualStyleBackColor = false;
            btnGoReturnForm.Click += btnGoReturnForm_Click;
            // 
            // btnGoReport
            // 
            btnGoReport.BackColor = Color.FromArgb(139, 94, 60);
            btnGoReport.FlatStyle = FlatStyle.Flat;
            btnGoReport.ForeColor = Color.White;
            btnGoReport.Location = new Point(288, 12);
            btnGoReport.Name = "btnGoReport";
            btnGoReport.Size = new Size(157, 86);
            btnGoReport.TabIndex = 7;
            btnGoReport.Text = "Rapor";
            btnGoReport.UseVisualStyleBackColor = false;
            btnGoReport.Click += btnGoReport_Click;
            // 
            // MainForm
            // 
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1064, 612);
            Controls.Add(btnGoReport);
            Controls.Add(btnGoReturnForm);
            Controls.Add(mainPanel);
            Controls.Add(btnGoLoanForm);
            Controls.Add(btnGoPublisherAddForm);
            Controls.Add(btnGoBookAddForm);
            Controls.Add(btnGoAuthorAddForm);
            Controls.Add(btnGoStudentAddForm);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            ForeColor = Color.Black;
            MaximumSize = new Size(1080, 651);
            MinimumSize = new Size(1080, 651);
            Name = "MainForm";
            ResumeLayout(false);
        }

        private Button btnGoReturnForm;
        private Button btnGoReport;
    }
}
