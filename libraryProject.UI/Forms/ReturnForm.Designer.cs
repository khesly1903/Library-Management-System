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
            SuspendLayout();
            // 
            // btnRetrun
            // 
            btnRetrun.BackColor = Color.FromArgb(139, 94, 60);
            btnRetrun.FlatStyle = FlatStyle.Flat;
            btnRetrun.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnRetrun.ForeColor = Color.FromArgb(75, 54, 33);
            btnRetrun.Location = new Point(13, 516);
            btnRetrun.Margin = new Padding(4);
            btnRetrun.Name = "btnRetrun";
            btnRetrun.Size = new Size(1200, 45);
            btnRetrun.TabIndex = 13;
            btnRetrun.Text = "Kitabı Al";
            btnRetrun.UseVisualStyleBackColor = false;
            btnRetrun.Click += btnRetrun_Click;
            // 
            // txtStudentSearch
            // 
            txtStudentSearch.BackColor = Color.FromArgb(234, 216, 192);
            txtStudentSearch.Location = new Point(13, 55);
            txtStudentSearch.Name = "txtStudentSearch";
            txtStudentSearch.Size = new Size(320, 36);
            txtStudentSearch.TabIndex = 14;
            txtStudentSearch.TextChanged += txtStudentSearch_TextChanged;
            // 
            // txtBookSearch
            // 
            txtBookSearch.BackColor = Color.FromArgb(234, 216, 192);
            txtBookSearch.Location = new Point(795, 55);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.Size = new Size(418, 36);
            txtBookSearch.TabIndex = 15;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // lstList
            // 
            lstList.BackColor = Color.FromArgb(234, 216, 192);
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 28;
            lstList.Location = new Point(13, 112);
            lstList.Name = "lstList";
            lstList.Size = new Size(1200, 340);
            lstList.TabIndex = 16;
            lstList.SelectedIndexChanged += lstList_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(75, 54, 33);
            label1.Location = new Point(132, 24);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 17;
            label1.Text = "ÖĞRENCİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(75, 54, 33);
            label2.Location = new Point(988, 24);
            label2.Name = "label2";
            label2.Size = new Size(63, 28);
            label2.TabIndex = 17;
            label2.Text = "KİTAP";
            // 
            // ReturnForm
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1234, 611);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstList);
            Controls.Add(txtBookSearch);
            Controls.Add(txtStudentSearch);
            Controls.Add(btnRetrun);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 6, 4, 6);
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
    }
}