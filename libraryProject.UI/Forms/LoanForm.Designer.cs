namespace libraryProject.UI.Forms
{
    partial class LoanForm
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
            lblStudentList = new Label();
            lblBookList = new Label();
            lblLoanDate = new Label();
            lblReturnDate = new Label();
            lstStudents = new ListBox();
            lstBooks = new ListBox();
            txtStudentSearch = new TextBox();
            txtBookSearch = new TextBox();
            clndrEndDate = new MonthCalendar();
            clndrStartDate = new MonthCalendar();
            btnLoan = new Button();
            btnStudentSearchClear = new Button();
            btnBookSearchClear = new Button();
            SuspendLayout();
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.BackColor = Color.Transparent;
            lblStudentList.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            lblStudentList.ForeColor = Color.FromArgb(75, 54, 33);
            lblStudentList.Location = new Point(132, 24);
            lblStudentList.Margin = new Padding(4, 0, 4, 0);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(95, 28);
            lblStudentList.TabIndex = 0;
            lblStudentList.Text = "ÖĞRENCİ ";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.Transparent;
            lblBookList.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            lblBookList.ForeColor = Color.FromArgb(75, 54, 33);
            lblBookList.Location = new Point(988, 24);
            lblBookList.Margin = new Padding(4, 0, 4, 0);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(69, 28);
            lblBookList.TabIndex = 1;
            lblBookList.Text = "KİTAP ";
            // 
            // lblLoanDate
            // 
            lblLoanDate.AutoSize = true;
            lblLoanDate.BackColor = Color.Transparent;
            lblLoanDate.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            lblLoanDate.ForeColor = Color.FromArgb(75, 54, 33);
            lblLoanDate.Location = new Point(535, 24);
            lblLoanDate.Margin = new Padding(4, 0, 4, 0);
            lblLoanDate.Name = "lblLoanDate";
            lblLoanDate.Size = new Size(141, 28);
            lblLoanDate.TabIndex = 2;
            lblLoanDate.Text = "ALINAN TARİHİ";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.BackColor = Color.Transparent;
            lblReturnDate.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            lblReturnDate.ForeColor = Color.FromArgb(75, 54, 33);
            lblReturnDate.Location = new Point(535, 238);
            lblReturnDate.Margin = new Padding(4, 0, 4, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(161, 28);
            lblReturnDate.TabIndex = 2;
            lblReturnDate.Text = "GETİRİLEN TARİH";
            // 
            // lstStudents
            // 
            lstStudents.BackColor = Color.FromArgb(234, 216, 192);
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 28;
            lstStudents.Location = new Point(13, 112);
            lstStudents.Margin = new Padding(4, 5, 4, 5);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(420, 200);
            lstStudents.TabIndex = 3;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // lstBooks
            // 
            lstBooks.BackColor = Color.FromArgb(234, 216, 192);
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 28;
            lstBooks.Location = new Point(795, 112);
            lstBooks.Margin = new Padding(4, 5, 4, 5);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(420, 200);
            lstBooks.TabIndex = 3;
            lstBooks.SelectedIndexChanged += lstBooks_SelectedIndexChanged;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.BackColor = Color.FromArgb(234, 216, 192);
            txtStudentSearch.Location = new Point(13, 55);
            txtStudentSearch.Margin = new Padding(4, 5, 4, 5);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(420, 36);
            txtStudentSearch.TabIndex = 4;
            txtStudentSearch.TextChanged += txtStudentSearch_TextChanged;
            // 
            // txtBookSearch
            // 
            txtBookSearch.BackColor = Color.FromArgb(234, 216, 192);
            txtBookSearch.Location = new Point(795, 55);
            txtBookSearch.Margin = new Padding(4, 5, 4, 5);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(420, 36);
            txtBookSearch.TabIndex = 4;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // clndrEndDate
            // 
            clndrEndDate.BackColor = Color.FromArgb(234, 216, 192);
            clndrEndDate.Location = new Point(486, 278);
            clndrEndDate.Margin = new Padding(9, 12, 9, 12);
            clndrEndDate.Name = "clndrEndDate";
            clndrEndDate.TabIndex = 5;
            // 
            // clndrStartDate
            // 
            clndrStartDate.BackColor = Color.FromArgb(234, 216, 192);
            clndrStartDate.Location = new Point(486, 64);
            clndrStartDate.Margin = new Padding(9, 12, 9, 12);
            clndrStartDate.Name = "clndrStartDate";
            clndrStartDate.TabIndex = 6;
            // 
            // btnLoan
            // 
            btnLoan.BackColor = Color.FromArgb(139, 94, 60);
            btnLoan.FlatStyle = FlatStyle.Flat;
            btnLoan.ForeColor = Color.FromArgb(75, 54, 33);
            btnLoan.Location = new Point(13, 527);
            btnLoan.Margin = new Padding(3, 4, 3, 4);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(1200, 45);
            btnLoan.TabIndex = 7;
            btnLoan.Text = "Kitabı Ver";
            btnLoan.UseVisualStyleBackColor = false;
            btnLoan.Click += btnLoan_Click;
            // 
            // btnStudentSearchClear
            // 
            btnStudentSearchClear.BackColor = Color.Red;
            btnStudentSearchClear.Location = new Point(440, 55);
            btnStudentSearchClear.Name = "btnStudentSearchClear";
            btnStudentSearchClear.Size = new Size(35, 35);
            btnStudentSearchClear.TabIndex = 8;
            btnStudentSearchClear.Text = "X";
            btnStudentSearchClear.UseVisualStyleBackColor = false;
            btnStudentSearchClear.Click += btnStudentSearchClear_Click;
            // 
            // btnBookSearchClear
            // 
            btnBookSearchClear.BackColor = Color.Red;
            btnBookSearchClear.Location = new Point(752, 55);
            btnBookSearchClear.Name = "btnBookSearchClear";
            btnBookSearchClear.Size = new Size(36, 36);
            btnBookSearchClear.TabIndex = 9;
            btnBookSearchClear.Text = "X";
            btnBookSearchClear.UseVisualStyleBackColor = false;
            btnBookSearchClear.Click += btnBookSearchClear_Click;
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1250, 650);
            Controls.Add(btnBookSearchClear);
            Controls.Add(btnStudentSearchClear);
            Controls.Add(btnLoan);
            Controls.Add(clndrStartDate);
            Controls.Add(clndrEndDate);
            Controls.Add(lblLoanDate);
            Controls.Add(txtBookSearch);
            Controls.Add(txtStudentSearch);
            Controls.Add(lstBooks);
            Controls.Add(lstStudents);
            Controls.Add(lblReturnDate);
            Controls.Add(lblBookList);
            Controls.Add(lblStudentList);
            Cursor = Cursors.IBeam;
            Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "LoanForm";
            Text = "LoanForm";
            Load += LoanForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentList;
        private Label lblBookList;
        private Label lblLoanDate;
        private Label lblReturnDate;
        private ListBox lstStudents;
        private ListBox lstBooks;
        private TextBox txtStudentSearch;
        private TextBox txtBookSearch;
        private MonthCalendar clndrEndDate;
        private MonthCalendar clndrStartDate;
        private Button btnLoan;
        private Button btnStudentSearchClear;
        private Button btnBookSearchClear;
    }
}