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
            lblStudentList.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblStudentList.ForeColor = Color.FromArgb(75, 54, 33);
            lblStudentList.Location = new Point(148, 9);
            lblStudentList.Margin = new Padding(4, 0, 4, 0);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(88, 19);
            lblStudentList.TabIndex = 0;
            lblStudentList.Text = "ÖĞRENCİ ";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.Transparent;
            lblBookList.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBookList.ForeColor = Color.FromArgb(75, 54, 33);
            lblBookList.Location = new Point(841, 9);
            lblBookList.Margin = new Padding(4, 0, 4, 0);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(59, 19);
            lblBookList.TabIndex = 1;
            lblBookList.Text = "KİTAP ";
            // 
            // lblLoanDate
            // 
            lblLoanDate.AutoSize = true;
            lblLoanDate.BackColor = Color.Transparent;
            lblLoanDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLoanDate.ForeColor = Color.FromArgb(75, 54, 33);
            lblLoanDate.Location = new Point(442, 16);
            lblLoanDate.Margin = new Padding(4, 0, 4, 0);
            lblLoanDate.Name = "lblLoanDate";
            lblLoanDate.Size = new Size(131, 19);
            lblLoanDate.TabIndex = 2;
            lblLoanDate.Text = "ALINAN TARİHİ";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.BackColor = Color.Transparent;
            lblReturnDate.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblReturnDate.ForeColor = Color.FromArgb(75, 54, 33);
            lblReturnDate.Location = new Point(442, 207);
            lblReturnDate.Margin = new Padding(4, 0, 4, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(151, 19);
            lblReturnDate.TabIndex = 2;
            lblReturnDate.Text = "GETİRİLEN TARİH";
            // 
            // lstStudents
            // 
            lstStudents.BackColor = Color.FromArgb(234, 216, 192);
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 19;
            lstStudents.Location = new Point(12, 76);
            lstStudents.Margin = new Padding(4, 3, 4, 3);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(327, 137);
            lstStudents.TabIndex = 3;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // lstBooks
            // 
            lstBooks.BackColor = Color.FromArgb(234, 216, 192);
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 19;
            lstBooks.Location = new Point(696, 76);
            lstBooks.Margin = new Padding(4, 3, 4, 3);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(326, 137);
            lstBooks.TabIndex = 3;
            lstBooks.SelectedIndexChanged += lstBooks_SelectedIndexChanged;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.BackColor = Color.FromArgb(234, 216, 192);
            txtStudentSearch.Location = new Point(12, 37);
            txtStudentSearch.Margin = new Padding(4, 3, 4, 3);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(327, 26);
            txtStudentSearch.TabIndex = 4;
            txtStudentSearch.TextChanged += txtStudentSearch_TextChanged;
            // 
            // txtBookSearch
            // 
            txtBookSearch.BackColor = Color.FromArgb(234, 216, 192);
            txtBookSearch.Location = new Point(696, 37);
            txtBookSearch.Margin = new Padding(4, 3, 4, 3);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(326, 26);
            txtBookSearch.TabIndex = 4;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // clndrEndDate
            // 
            clndrEndDate.BackColor = Color.FromArgb(234, 216, 192);
            clndrEndDate.Location = new Point(399, 234);
            clndrEndDate.Margin = new Padding(8);
            clndrEndDate.Name = "clndrEndDate";
            clndrEndDate.TabIndex = 5;
            // 
            // clndrStartDate
            // 
            clndrStartDate.BackColor = Color.FromArgb(234, 216, 192);
            clndrStartDate.Location = new Point(399, 37);
            clndrStartDate.Margin = new Padding(8);
            clndrStartDate.Name = "clndrStartDate";
            clndrStartDate.TabIndex = 6;
            clndrStartDate.DateChanged += clndrStartDate_DateChanged;
            // 
            // btnLoan
            // 
            btnLoan.BackColor = Color.FromArgb(139, 94, 60);
            btnLoan.FlatStyle = FlatStyle.Flat;
            btnLoan.ForeColor = Color.FromArgb(75, 54, 33);
            btnLoan.Location = new Point(12, 407);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(1012, 31);
            btnLoan.TabIndex = 7;
            btnLoan.Text = "Kitabı Ver";
            btnLoan.UseVisualStyleBackColor = false;
            btnLoan.Click += btnLoan_Click;
            // 
            // btnStudentSearchClear
            // 
            btnStudentSearchClear.BackColor = Color.Red;
            btnStudentSearchClear.Location = new Point(346, 37);
            btnStudentSearchClear.Margin = new Padding(3, 2, 3, 2);
            btnStudentSearchClear.Name = "btnStudentSearchClear";
            btnStudentSearchClear.Size = new Size(32, 24);
            btnStudentSearchClear.TabIndex = 8;
            btnStudentSearchClear.Text = "X";
            btnStudentSearchClear.UseVisualStyleBackColor = false;
            btnStudentSearchClear.Click += btnStudentSearchClear_Click;
            // 
            // btnBookSearchClear
            // 
            btnBookSearchClear.BackColor = Color.Red;
            btnBookSearchClear.Location = new Point(657, 37);
            btnBookSearchClear.Margin = new Padding(3, 2, 3, 2);
            btnBookSearchClear.Name = "btnBookSearchClear";
            btnBookSearchClear.Size = new Size(32, 24);
            btnBookSearchClear.TabIndex = 9;
            btnBookSearchClear.Text = "X";
            btnBookSearchClear.UseVisualStyleBackColor = false;
            btnBookSearchClear.Click += btnBookSearchClear_Click;
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1035, 472);
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
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 3, 4, 3);
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