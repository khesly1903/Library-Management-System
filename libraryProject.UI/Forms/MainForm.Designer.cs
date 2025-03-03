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
            SuspendLayout();
            // 
            // btnGoStudentAddForm
            // 
            btnGoStudentAddForm.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGoStudentAddForm.Location = new Point(402, 12);
            btnGoStudentAddForm.Name = "btnGoStudentAddForm";
            btnGoStudentAddForm.Size = new Size(250, 40);
            btnGoStudentAddForm.TabIndex = 0;
            btnGoStudentAddForm.Text = "Öğrenci Ekleme Formunu Aç";
            btnGoStudentAddForm.UseVisualStyleBackColor = true;
            btnGoStudentAddForm.Click += btnGoStudentAddForm_Click;
            // 
            // btnGoAuthorAddForm
            // 
            btnGoAuthorAddForm.Location = new Point(658, 12);
            btnGoAuthorAddForm.Name = "btnGoAuthorAddForm";
            btnGoAuthorAddForm.Size = new Size(250, 40);
            btnGoAuthorAddForm.TabIndex = 1;
            btnGoAuthorAddForm.Text = "Yazar Ekleme Formunu Aç";
            btnGoAuthorAddForm.UseVisualStyleBackColor = true;
            btnGoAuthorAddForm.Click += btnGoAuthorAddForm_Click;
            // 
            // btnGoBookAddForm
            // 
            btnGoBookAddForm.Location = new Point(402, 58);
            btnGoBookAddForm.Name = "btnGoBookAddForm";
            btnGoBookAddForm.Size = new Size(250, 40);
            btnGoBookAddForm.TabIndex = 2;
            btnGoBookAddForm.Text = "Kitap Ekleme Formunu Aç";
            btnGoBookAddForm.UseVisualStyleBackColor = true;
            btnGoBookAddForm.Click += btnGoBookAddForm_Click;
            // 
            // btnGoPublisherAddForm
            // 
            btnGoPublisherAddForm.Location = new Point(658, 58);
            btnGoPublisherAddForm.Name = "btnGoPublisherAddForm";
            btnGoPublisherAddForm.Size = new Size(250, 40);
            btnGoPublisherAddForm.TabIndex = 3;
            btnGoPublisherAddForm.Text = "Yayınevi Ekleme Formunu Aç";
            btnGoPublisherAddForm.UseVisualStyleBackColor = true;
            btnGoPublisherAddForm.Click += btnGoPublisherAddForm_Click;
            // 
            // btnGoLoanForm
            // 
            btnGoLoanForm.Location = new Point(62, 12);
            btnGoLoanForm.Name = "btnGoLoanForm";
            btnGoLoanForm.Size = new Size(250, 40);
            btnGoLoanForm.TabIndex = 4;
            btnGoLoanForm.Text = "Kitap Ver";
            btnGoLoanForm.UseVisualStyleBackColor = true;
            btnGoLoanForm.Click += btnGoLoanForm_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(12, 133);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(950, 520);
            mainPanel.TabIndex = 5;
            // 
            // btnGoReturnForm
            // 
            btnGoReturnForm.Location = new Point(62, 58);
            btnGoReturnForm.Name = "btnGoReturnForm";
            btnGoReturnForm.Size = new Size(250, 40);
            btnGoReturnForm.TabIndex = 6;
            btnGoReturnForm.Text = "Kitap Al";
            btnGoReturnForm.UseVisualStyleBackColor = true;
            btnGoReturnForm.Click += btnGoReturnForm_Click;
            // 
            // MainForm
            // 
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(984, 661);
            Controls.Add(btnGoReturnForm);
            Controls.Add(mainPanel);
            Controls.Add(btnGoLoanForm);
            Controls.Add(btnGoPublisherAddForm);
            Controls.Add(btnGoBookAddForm);
            Controls.Add(btnGoAuthorAddForm);
            Controls.Add(btnGoStudentAddForm);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            MaximumSize = new Size(1000, 700);
            MinimumSize = new Size(1000, 700);
            Name = "MainForm";
            ResumeLayout(false);
        }

        private Button btnGoReturnForm;
    }
}
