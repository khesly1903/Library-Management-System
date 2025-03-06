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
            btnDueDateCheck.Location = new Point(507, 95);
            btnDueDateCheck.Name = "btnDueDateCheck";
            btnDueDateCheck.Size = new Size(199, 92);
            btnDueDateCheck.TabIndex = 2;
            btnDueDateCheck.Text = "Tarihi yaklaşanlar";
            btnDueDateCheck.UseVisualStyleBackColor = false;
            btnDueDateCheck.Click += btnDueDateCheck_Click;
            // 
            // btnStudentHighestCheck
            // 
            btnStudentHighestCheck.BackColor = Color.FromArgb(139, 94, 60);
            btnStudentHighestCheck.FlatStyle = FlatStyle.Flat;
            btnStudentHighestCheck.Location = new Point(282, 95);
            btnStudentHighestCheck.Name = "btnStudentHighestCheck";
            btnStudentHighestCheck.Size = new Size(199, 92);
            btnStudentHighestCheck.TabIndex = 3;
            btnStudentHighestCheck.Text = "En çok okuyana göre sıralama";
            btnStudentHighestCheck.UseVisualStyleBackColor = false;
            btnStudentHighestCheck.Click += btnStudentHighestCheck_Click;
            // 
            // btnGetAllLoans
            // 
            btnGetAllLoans.BackColor = Color.FromArgb(139, 94, 60);
            btnGetAllLoans.FlatStyle = FlatStyle.Flat;
            btnGetAllLoans.Location = new Point(730, 95);
            btnGetAllLoans.Name = "btnGetAllLoans";
            btnGetAllLoans.Size = new Size(199, 92);
            btnGetAllLoans.TabIndex = 4;
            btnGetAllLoans.Text = "Bütün işlemleri getir";
            btnGetAllLoans.UseVisualStyleBackColor = false;
            btnGetAllLoans.Click += btnGetAllLoans_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 565);
            label1.Name = "label1";
            label1.Size = new Size(115, 28);
            label1.TabIndex = 5;
            label1.Text = "Ödünç alma:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(724, 565);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 5;
            label2.Text = "Kitap:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(963, 565);
            label3.Name = "label3";
            label3.Size = new Size(79, 28);
            label3.TabIndex = 5;
            label3.Text = "Öğrenci:";
            // 
            // dGV
            // 
            dGV.BackgroundColor = Color.FromArgb(245, 225, 200);
            dGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGV.GridColor = Color.FromArgb(245, 225, 200);
            dGV.Location = new Point(173, 223);
            dGV.Name = "dGV";
            dGV.Size = new Size(926, 329);
            dGV.TabIndex = 14;
            dGV.CellContentClick += dGV_CellContentClick;
            // 
            // lblToatalLoan
            // 
            lblToatalLoan.AutoSize = true;
            lblToatalLoan.Location = new Point(289, 565);
            lblToatalLoan.Name = "lblToatalLoan";
            lblToatalLoan.Size = new Size(60, 28);
            lblToatalLoan.TabIndex = 15;
            lblToatalLoan.Text = "label4";
            // 
            // lblTotalBook
            // 
            lblTotalBook.AutoSize = true;
            lblTotalBook.Location = new Point(785, 565);
            lblTotalBook.Name = "lblTotalBook";
            lblTotalBook.Size = new Size(60, 28);
            lblTotalBook.TabIndex = 16;
            lblTotalBook.Text = "label4";
            // 
            // lblTotalStudent
            // 
            lblTotalStudent.AutoSize = true;
            lblTotalStudent.Location = new Point(1039, 565);
            lblTotalStudent.Name = "lblTotalStudent";
            lblTotalStudent.Size = new Size(60, 28);
            lblTotalStudent.TabIndex = 17;
            lblTotalStudent.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(443, 565);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 18;
            label4.Text = "Aktif Ödünç:";
            // 
            // lblTotalActiveLoan
            // 
            lblTotalActiveLoan.AutoSize = true;
            lblTotalActiveLoan.Location = new Point(564, 565);
            lblTotalActiveLoan.Name = "lblTotalActiveLoan";
            lblTotalActiveLoan.Size = new Size(60, 28);
            lblTotalActiveLoan.TabIndex = 19;
            lblTotalActiveLoan.Text = "label5";
            // 
            // LoanReport
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1234, 611);
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
            Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            Margin = new Padding(4, 6, 4, 6);
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