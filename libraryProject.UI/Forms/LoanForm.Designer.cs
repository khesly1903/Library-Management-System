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
            btnDelete = new Button();
            lstLoans = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.BackColor = Color.Transparent;
            lblStudentList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblStudentList.Location = new Point(13, 32);
            lblStudentList.Margin = new Padding(4, 0, 4, 0);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(96, 20);
            lblStudentList.TabIndex = 0;
            lblStudentList.Text = "ÖĞRENCİ ";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.Transparent;
            lblBookList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookList.Location = new Point(353, 27);
            lblBookList.Margin = new Padding(4, 0, 4, 0);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(64, 20);
            lblBookList.TabIndex = 1;
            lblBookList.Text = "KİTAP ";
            // 
            // lblLoanDate
            // 
            lblLoanDate.AutoSize = true;
            lblLoanDate.BackColor = Color.Transparent;
            lblLoanDate.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblLoanDate.ForeColor = Color.Black;
            lblLoanDate.Location = new Point(751, 33);
            lblLoanDate.Margin = new Padding(4, 0, 4, 0);
            lblLoanDate.Name = "lblLoanDate";
            lblLoanDate.Size = new Size(125, 19);
            lblLoanDate.TabIndex = 2;
            lblLoanDate.Text = "ALINAN TARİHİ";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.BackColor = Color.Transparent;
            lblReturnDate.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblReturnDate.ForeColor = Color.Black;
            lblReturnDate.Location = new Point(738, 232);
            lblReturnDate.Margin = new Padding(4, 0, 4, 0);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(147, 19);
            lblReturnDate.TabIndex = 2;
            lblReturnDate.Text = "GETİRİLEN TARİH";
            // 
            // lstStudents
            // 
            lstStudents.BackColor = SystemColors.Window;
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 21;
            lstStudents.Location = new Point(13, 98);
            lstStudents.Margin = new Padding(4);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(320, 151);
            lstStudents.TabIndex = 3;
            lstStudents.SelectedIndexChanged += lstStudents_SelectedIndexChanged;
            // 
            // lstBooks
            // 
            lstBooks.BackColor = SystemColors.Window;
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 21;
            lstBooks.Location = new Point(353, 98);
            lstBooks.Margin = new Padding(4);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(320, 151);
            lstBooks.TabIndex = 3;
            lstBooks.SelectedIndexChanged += lstBooks_SelectedIndexChanged;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.BackColor = SystemColors.Window;
            txtStudentSearch.Location = new Point(13, 61);
            txtStudentSearch.Margin = new Padding(4);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(320, 29);
            txtStudentSearch.TabIndex = 4;
            txtStudentSearch.TextChanged += txtStudentSearch_TextChanged;
            // 
            // txtBookSearch
            // 
            txtBookSearch.BackColor = SystemColors.Window;
            txtBookSearch.Location = new Point(353, 61);
            txtBookSearch.Margin = new Padding(4);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(320, 29);
            txtBookSearch.TabIndex = 4;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // clndrEndDate
            // 
            clndrEndDate.Location = new Point(698, 260);
            clndrEndDate.Name = "clndrEndDate";
            clndrEndDate.TabIndex = 5;
            // 
            // clndrStartDate
            // 
            clndrStartDate.Location = new Point(698, 61);
            clndrStartDate.Name = "clndrStartDate";
            clndrStartDate.TabIndex = 6;
            // 
            // btnLoan
            // 
            btnLoan.Location = new Point(13, 447);
            btnLoan.Name = "btnLoan";
            btnLoan.Size = new Size(450, 46);
            btnLoan.TabIndex = 7;
            btnLoan.Text = "Kitabı Ver";
            btnLoan.UseVisualStyleBackColor = true;
            btnLoan.Click += btnLoan_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(471, 447);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(450, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Teslim Al";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstLoans
            // 
            lstLoans.FormattingEnabled = true;
            lstLoans.ItemHeight = 21;
            lstLoans.Location = new Point(353, 260);
            lstLoans.Name = "lstLoans";
            lstLoans.Size = new Size(320, 172);
            lstLoans.TabIndex = 15;
            lstLoans.SelectedIndexChanged += lstLoans_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 303);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(320, 29);
            textBox1.TabIndex = 16;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 269);
            label1.Name = "label1";
            label1.Size = new Size(200, 21);
            label1.TabIndex = 17;
            label1.Text = "ÖĞRENCİ (TESLİM ALMA)";
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(950, 700);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(lstLoans);
            Controls.Add(btnDelete);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
        private Button btnDelete;
        private ListBox lstLoans;
        private TextBox textBox1;
        private Label label1;
    }
}