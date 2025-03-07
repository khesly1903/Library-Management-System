namespace libraryProject.UI.Forms
{
    partial class ReturnForm
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
            btnRetrun = new Button();
            txtStudentSearch = new TextBox();
            txtBookSearch = new TextBox();
            lstList = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btnStudentSearchClear = new Button();
            btnBookSearchClear = new Button();
            SuspendLayout();
            // 
            // btnRetrun
            // 
            btnRetrun.BackColor = Color.FromArgb(139, 94, 60);
            btnRetrun.FlatStyle = FlatStyle.Flat;
            btnRetrun.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRetrun.ForeColor = Color.FromArgb(75, 54, 33);
            btnRetrun.Location = new Point(11, 373);
            btnRetrun.Margin = new Padding(4, 3, 4, 3);
            btnRetrun.Name = "btnRetrun";
            btnRetrun.Size = new Size(995, 31);
            btnRetrun.TabIndex = 13;
            btnRetrun.Text = "Kitabı Al";
            btnRetrun.UseVisualStyleBackColor = false;
            btnRetrun.Click += btnRetrun_Click;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.BackColor = Color.FromArgb(234, 216, 192);
            txtStudentSearch.Location = new Point(12, 37);
            txtStudentSearch.Margin = new Padding(3, 2, 3, 2);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(377, 26);
            txtStudentSearch.TabIndex = 14;
            txtStudentSearch.TextChanged += txtStudentSearch_TextChanged;
            // 
            // txtBookSearch
            // 
            txtBookSearch.BackColor = Color.FromArgb(234, 216, 192);
            txtBookSearch.Location = new Point(630, 37);
            txtBookSearch.Margin = new Padding(3, 2, 3, 2);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(377, 26);
            txtBookSearch.TabIndex = 15;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // lstList
            // 
            lstList.BackColor = Color.FromArgb(234, 216, 192);
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 19;
            lstList.Location = new Point(12, 104);
            lstList.Margin = new Padding(3, 2, 3, 2);
            lstList.Name = "lstList";
            lstList.Size = new Size(995, 232);
            lstList.TabIndex = 16;
            lstList.SelectedIndexChanged += lstList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(75, 54, 33);
            label1.Location = new Point(164, 16);
            label1.Name = "label1";
            label1.Size = new Size(84, 19);
            label1.TabIndex = 17;
            label1.Text = "ÖĞRENCİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(75, 54, 33);
            label2.Location = new Point(803, 14);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 17;
            label2.Text = "KİTAP";
            // 
            // btnStudentSearchClear
            // 
            btnStudentSearchClear.BackColor = Color.Red;
            btnStudentSearchClear.Location = new Point(404, 37);
            btnStudentSearchClear.Margin = new Padding(3, 2, 3, 2);
            btnStudentSearchClear.Name = "btnStudentSearchClear";
            btnStudentSearchClear.Size = new Size(32, 24);
            btnStudentSearchClear.TabIndex = 18;
            btnStudentSearchClear.Text = "X";
            btnStudentSearchClear.UseVisualStyleBackColor = false;
            btnStudentSearchClear.Click += btnStudentSearchClear_Click;
            // 
            // btnBookSearchClear
            // 
            btnBookSearchClear.BackColor = Color.Red;
            btnBookSearchClear.Location = new Point(592, 37);
            btnBookSearchClear.Margin = new Padding(3, 2, 3, 2);
            btnBookSearchClear.Name = "btnBookSearchClear";
            btnBookSearchClear.Size = new Size(32, 24);
            btnBookSearchClear.TabIndex = 19;
            btnBookSearchClear.Text = "X";
            btnBookSearchClear.UseVisualStyleBackColor = false;
            btnBookSearchClear.Click += btnBookSearchClear_Click;
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1019, 433);
            Controls.Add(btnBookSearchClear);
            Controls.Add(btnStudentSearchClear);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstList);
            Controls.Add(txtBookSearch);
            Controls.Add(txtStudentSearch);
            Controls.Add(btnRetrun);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4);
            Name = "ReturnForm";
            Text = "RetrunForm";
            Load += RetrunForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRetrun;
        private TextBox txtStudentSearch;
        private TextBox txtBookSearch;
        private ListBox lstList;
        private Label label1;
        private Label label2;
        private Button btnStudentSearchClear;
        private Button btnBookSearchClear;
    }
}