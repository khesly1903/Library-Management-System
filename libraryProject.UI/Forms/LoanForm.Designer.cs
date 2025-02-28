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
            dateTimeLoanDate = new DateTimePicker();
            dateTimeReturnDate = new DateTimePicker();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.BackColor = Color.Bisque;
            lblStudentList.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentList.Location = new Point(27, 39);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(112, 16);
            lblStudentList.TabIndex = 0;
            lblStudentList.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.BackColor = Color.Bisque;
            lblBookList.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookList.Location = new Point(411, 39);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(92, 16);
            lblBookList.TabIndex = 1;
            lblBookList.Text = "KİTAP LİSTESİ";
            // 
            // lblLoanDate
            // 
            lblLoanDate.AutoSize = true;
            lblLoanDate.BackColor = SystemColors.ButtonFace;
            lblLoanDate.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblLoanDate.ForeColor = Color.MediumSeaGreen;
            lblLoanDate.Location = new Point(43, 503);
            lblLoanDate.Name = "lblLoanDate";
            lblLoanDate.Size = new Size(125, 19);
            lblLoanDate.TabIndex = 2;
            lblLoanDate.Text = "ALINAN TARİHİ";
            // 
            // lblReturnDate
            // 
            lblReturnDate.AutoSize = true;
            lblReturnDate.BackColor = SystemColors.ButtonFace;
            lblReturnDate.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblReturnDate.ForeColor = Color.DeepSkyBlue;
            lblReturnDate.Location = new Point(43, 560);
            lblReturnDate.Name = "lblReturnDate";
            lblReturnDate.Size = new Size(147, 19);
            lblReturnDate.TabIndex = 2;
            lblReturnDate.Text = "GETİRİLEN TARİH";
            // 
            // lstStudents
            // 
            lstStudents.BackColor = Color.PeachPuff;
            lstStudents.FormattingEnabled = true;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(27, 117);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(266, 214);
            lstStudents.TabIndex = 3;
            // 
            // lstBooks
            // 
            lstBooks.BackColor = Color.PeachPuff;
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new Point(411, 117);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(266, 214);
            lstBooks.TabIndex = 3;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.BackColor = SystemColors.AppWorkspace;
            txtStudentSearch.Location = new Point(27, 74);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(266, 23);
            txtStudentSearch.TabIndex = 4;
            // 
            // txtBookSearch
            // 
            txtBookSearch.BackColor = SystemColors.AppWorkspace;
            txtBookSearch.Location = new Point(411, 74);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(266, 23);
            txtBookSearch.TabIndex = 4;
            // 
            // dateTimeLoanDate
            // 
            dateTimeLoanDate.CalendarMonthBackground = Color.FromArgb(0, 192, 0);
            dateTimeLoanDate.CalendarTitleBackColor = Color.Aqua;
            dateTimeLoanDate.Location = new Point(227, 499);
            dateTimeLoanDate.Name = "dateTimeLoanDate";
            dateTimeLoanDate.Size = new Size(200, 23);
            dateTimeLoanDate.TabIndex = 5;
            // 
            // dateTimeReturnDate
            // 
            dateTimeReturnDate.CalendarMonthBackground = Color.DeepSkyBlue;
            dateTimeReturnDate.Location = new Point(227, 557);
            dateTimeReturnDate.Name = "dateTimeReturnDate";
            dateTimeReturnDate.Size = new Size(200, 23);
            dateTimeReturnDate.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Location = new Point(0, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(725, 3);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(347, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(3, 386);
            panel2.TabIndex = 7;
            // 
            // LoanForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(724, 630);
            Controls.Add(lblLoanDate);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dateTimeReturnDate);
            Controls.Add(dateTimeLoanDate);
            Controls.Add(txtBookSearch);
            Controls.Add(txtStudentSearch);
            Controls.Add(lstBooks);
            Controls.Add(lstStudents);
            Controls.Add(lblReturnDate);
            Controls.Add(lblBookList);
            Controls.Add(lblStudentList);
            FormBorderStyle = FormBorderStyle.None;
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
        private DateTimePicker dateTimeLoanDate;
        private DateTimePicker dateTimeReturnDate;
        private Panel panel1;
        private Panel panel2;
    }
}