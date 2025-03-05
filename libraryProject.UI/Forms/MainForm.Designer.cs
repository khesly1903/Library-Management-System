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
            btnGoStudentAddForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoStudentAddForm.FlatStyle = FlatStyle.Flat;
            btnGoStudentAddForm.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnGoStudentAddForm.ForeColor = Color.White;
            btnGoStudentAddForm.Location = new Point(699, 12);
            btnGoStudentAddForm.Name = "btnGoStudentAddForm";
            btnGoStudentAddForm.Size = new Size(250, 40);
            btnGoStudentAddForm.TabIndex = 0;
            btnGoStudentAddForm.Text = "Öğrenci Ekleme Formunu Aç";
            btnGoStudentAddForm.UseVisualStyleBackColor = false;
            btnGoStudentAddForm.Click += btnGoStudentAddForm_Click;
            // 
            // btnGoAuthorAddForm
            // 
            btnGoAuthorAddForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoAuthorAddForm.FlatStyle = FlatStyle.Flat;
            btnGoAuthorAddForm.ForeColor = Color.White;
            btnGoAuthorAddForm.Location = new Point(955, 12);
            btnGoAuthorAddForm.Name = "btnGoAuthorAddForm";
            btnGoAuthorAddForm.Size = new Size(250, 40);
            btnGoAuthorAddForm.TabIndex = 1;
            btnGoAuthorAddForm.Text = "Yazar Ekleme Formunu Aç";
            btnGoAuthorAddForm.UseVisualStyleBackColor = false;
            btnGoAuthorAddForm.Click += btnGoAuthorAddForm_Click;
            // 
            // btnGoBookAddForm
            // 
            btnGoBookAddForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoBookAddForm.FlatStyle = FlatStyle.Flat;
            btnGoBookAddForm.ForeColor = Color.White;
            btnGoBookAddForm.Location = new Point(699, 58);
            btnGoBookAddForm.Name = "btnGoBookAddForm";
            btnGoBookAddForm.Size = new Size(250, 40);
            btnGoBookAddForm.TabIndex = 2;
            btnGoBookAddForm.Text = "Kitap Ekleme Formunu Aç";
            btnGoBookAddForm.UseVisualStyleBackColor = false;
            btnGoBookAddForm.Click += btnGoBookAddForm_Click;
            // 
            // btnGoPublisherAddForm
            // 
            btnGoPublisherAddForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoPublisherAddForm.FlatStyle = FlatStyle.Flat;
            btnGoPublisherAddForm.ForeColor = Color.White;
            btnGoPublisherAddForm.Location = new Point(955, 58);
            btnGoPublisherAddForm.Name = "btnGoPublisherAddForm";
            btnGoPublisherAddForm.Size = new Size(250, 40);
            btnGoPublisherAddForm.TabIndex = 3;
            btnGoPublisherAddForm.Text = "Yayınevi Ekleme Formunu Aç";
            btnGoPublisherAddForm.UseVisualStyleBackColor = false;
            btnGoPublisherAddForm.Click += btnGoPublisherAddForm_Click;
            // 
            // btnGoLoanForm
            // 
            btnGoLoanForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoLoanForm.FlatStyle = FlatStyle.Flat;
            btnGoLoanForm.ForeColor = Color.White;
            btnGoLoanForm.Location = new Point(62, 12);
            btnGoLoanForm.Name = "btnGoLoanForm";
            btnGoLoanForm.Size = new Size(250, 40);
            btnGoLoanForm.TabIndex = 4;
            btnGoLoanForm.Text = "Kitap Ver";
            btnGoLoanForm.UseVisualStyleBackColor = false;
            btnGoLoanForm.Click += btnGoLoanForm_Click;
            // 
            // mainPanel
            // 
            mainPanel.Location = new Point(12, 133);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1250, 650);
            mainPanel.TabIndex = 5;
            // 
            // btnGoReturnForm
            // 
            btnGoReturnForm.BackColor = Color.FromArgb(139, 94, 60);
            btnGoReturnForm.FlatStyle = FlatStyle.Flat;
            btnGoReturnForm.ForeColor = Color.White;
            btnGoReturnForm.Location = new Point(62, 58);
            btnGoReturnForm.Name = "btnGoReturnForm";
            btnGoReturnForm.Size = new Size(250, 40);
            btnGoReturnForm.TabIndex = 6;
            btnGoReturnForm.Text = "Kitap Al";
            btnGoReturnForm.UseVisualStyleBackColor = false;
            btnGoReturnForm.Click += btnGoReturnForm_Click;
            // 
            // MainForm
            // 
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1279, 803);
            Controls.Add(btnGoReturnForm);
            Controls.Add(mainPanel);
            Controls.Add(btnGoLoanForm);
            Controls.Add(btnGoPublisherAddForm);
            Controls.Add(btnGoBookAddForm);
            Controls.Add(btnGoAuthorAddForm);
            Controls.Add(btnGoStudentAddForm);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            ForeColor = Color.Black;
            Name = "MainForm";
            ResumeLayout(false);
        }

        private Button btnGoReturnForm;
    }
}
