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
            btnDueDateCheck = new Button();
            btnStudentHighestCheck = new Button();
            btnGetAllLoans = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dGV = new DataGridView();
            lblToatalLoan = new Label();
            lblTotalBook = new Label();
            lblTotalStudent = new Label();
            label4 = new Label();
            lblTotalActiveLoan = new Label();
            ((System.ComponentModel.ISupportInitialize)dGV).BeginInit();
            SuspendLayout();
            // 
            // btnDueDateCheck
            // 
            btnDueDateCheck.BackColor = Color.FromArgb(139, 94, 60);
            btnDueDateCheck.FlatStyle = FlatStyle.Flat;
            btnDueDateCheck.Location = new Point(456, 64);
            btnDueDateCheck.Margin = new Padding(3, 2, 3, 2);
            btnDueDateCheck.Name = "btnDueDateCheck";
            btnDueDateCheck.Size = new Size(179, 62);
            btnDueDateCheck.TabIndex = 2;
            btnDueDateCheck.Text = "Tarihi yaklaşanlar";
            btnDueDateCheck.UseVisualStyleBackColor = false;
            btnDueDateCheck.Click += btnDueDateCheck_Click;
            // 
            // btnStudentHighestCheck
            // 
            btnStudentHighestCheck.BackColor = Color.FromArgb(139, 94, 60);
            btnStudentHighestCheck.FlatStyle = FlatStyle.Flat;
            btnStudentHighestCheck.Location = new Point(254, 64);
            btnStudentHighestCheck.Margin = new Padding(3, 2, 3, 2);
            btnStudentHighestCheck.Name = "btnStudentHighestCheck";
            btnStudentHighestCheck.Size = new Size(179, 62);
            btnStudentHighestCheck.TabIndex = 3;
            btnStudentHighestCheck.Text = "En çok okuyana göre sıralama";
            btnStudentHighestCheck.UseVisualStyleBackColor = false;
            btnStudentHighestCheck.Click += btnStudentHighestCheck_Click;
            // 
            // btnGetAllLoans
            // 
            btnGetAllLoans.BackColor = Color.FromArgb(139, 94, 60);
            btnGetAllLoans.FlatStyle = FlatStyle.Flat;
            btnGetAllLoans.Location = new Point(657, 64);
            btnGetAllLoans.Margin = new Padding(3, 2, 3, 2);
            btnGetAllLoans.Name = "btnGetAllLoans";
            btnGetAllLoans.Size = new Size(179, 62);
            btnGetAllLoans.TabIndex = 4;
            btnGetAllLoans.Text = "Bütün işlemleri getir";
            btnGetAllLoans.UseVisualStyleBackColor = false;
            btnGetAllLoans.Click += btnGetAllLoans_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(168, 383);
            label1.Name = "label1";
            label1.Size = new Size(93, 19);
            label1.TabIndex = 5;
            label1.Text = "Ödünç alma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(637, 383);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 5;
            label2.Text = "Kitap:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(815, 383);
            label3.Name = "label3";
            label3.Size = new Size(67, 19);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci:";
            // 
            // dGV
            // 
            dGV.BackgroundColor = Color.FromArgb(245, 225, 200);
            dGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV.GridColor = Color.FromArgb(245, 225, 200);
            dGV.Location = new Point(178, 146);
            dGV.Margin = new Padding(3, 2, 3, 2);
            dGV.Name = "dGV";
            dGV.Size = new Size(741, 223);
            dGV.TabIndex = 14;
            dGV.CellContentClick += dGV_CellContentClick;
            // 
            // lblToatalLoan
            // 
            lblToatalLoan.AutoSize = true;
            lblToatalLoan.Location = new Point(273, 383);
            lblToatalLoan.Name = "lblToatalLoan";
            lblToatalLoan.Size = new Size(49, 19);
            lblToatalLoan.TabIndex = 15;
            lblToatalLoan.Text = "label4";
            // 
            // lblTotalBook
            // 
            lblTotalBook.AutoSize = true;
            lblTotalBook.Location = new Point(692, 383);
            lblTotalBook.Name = "lblTotalBook";
            lblTotalBook.Size = new Size(49, 19);
            lblTotalBook.TabIndex = 16;
            lblTotalBook.Text = "label4";
            // 
            // lblTotalStudent
            // 
            lblTotalStudent.AutoSize = true;
            lblTotalStudent.Location = new Point(884, 383);
            lblTotalStudent.Name = "lblTotalStudent";
            lblTotalStudent.Size = new Size(49, 19);
            lblTotalStudent.TabIndex = 17;
            lblTotalStudent.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 383);
            label4.Name = "label4";
            label4.Size = new Size(95, 19);
            label4.TabIndex = 18;
            label4.Text = "Aktif Ödünç:";
            // 
            // lblTotalActiveLoan
            // 
            lblTotalActiveLoan.AutoSize = true;
            lblTotalActiveLoan.Location = new Point(490, 383);
            lblTotalActiveLoan.Name = "lblTotalActiveLoan";
            lblTotalActiveLoan.Size = new Size(49, 19);
            lblTotalActiveLoan.TabIndex = 19;
            lblTotalActiveLoan.Text = "label5";
            // 
            // LoanReport
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1019, 433);
            Controls.Add(lblTotalActiveLoan);
            Controls.Add(label4);
            Controls.Add(lblTotalStudent);
            Controls.Add(lblTotalBook);
            Controls.Add(lblToatalLoan);
            Controls.Add(dGV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGetAllLoans);
            Controls.Add(btnStudentHighestCheck);
            Controls.Add(btnDueDateCheck);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "LoanReport";
            Text = "LoanReport";
            Load += LoanReport_Load;
            ((System.ComponentModel.ISupportInitialize)dGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDueDateCheck;
        private Button btnStudentHighestCheck;
        private Button btnGetAllLoans;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dGV;
        private Label lblToatalLoan;
        private Label lblTotalBook;
        private Label lblTotalStudent;
        private Label label4;
        private Label lblTotalActiveLoan;
    }
}