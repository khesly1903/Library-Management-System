namespace libraryProject.UI.Forms
{
    partial class AuthorAddForm
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
            label1 = new Label();
            txtAuthorSurname = new TextBox();
            lstAuthorList = new ListBox();
            btnAuthorDelete = new Button();
            btnAuthorSave = new Button();
            label2 = new Label();
            label4 = new Label();
            txtAuthorName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(75, 54, 33);
            label1.Location = new Point(27, 172);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 25);
            label1.TabIndex = 0;
            label1.Text = "YAZAR SOYADI";
            // 
            // txtAuthorSurname
            // 
            txtAuthorSurname.BackColor = Color.FromArgb(234, 216, 192);
            txtAuthorSurname.Location = new Point(217, 172);
            txtAuthorSurname.Margin = new Padding(4, 3, 4, 3);
            txtAuthorSurname.Multiline = true;
            txtAuthorSurname.Name = "txtAuthorSurname";
            txtAuthorSurname.Size = new Size(288, 29);
            txtAuthorSurname.TabIndex = 1;
            // 
            // lstAuthorList
            // 
            lstAuthorList.BackColor = Color.FromArgb(234, 216, 192);
            lstAuthorList.FormattingEnabled = true;
            lstAuthorList.ItemHeight = 19;
            lstAuthorList.Location = new Point(602, 65);
            lstAuthorList.Margin = new Padding(4, 3, 4, 3);
            lstAuthorList.Name = "lstAuthorList";
            lstAuthorList.Size = new Size(288, 251);
            lstAuthorList.TabIndex = 2;
            lstAuthorList.SelectedIndexChanged += lstAuthorList_SelectedIndexChanged_1;
            // 
            // btnAuthorDelete
            // 
            btnAuthorDelete.BackColor = Color.FromArgb(139, 94, 60);
            btnAuthorDelete.FlatStyle = FlatStyle.Flat;
            btnAuthorDelete.ForeColor = Color.FromArgb(75, 54, 33);
            btnAuthorDelete.Location = new Point(513, 346);
            btnAuthorDelete.Margin = new Padding(4, 3, 4, 3);
            btnAuthorDelete.Name = "btnAuthorDelete";
            btnAuthorDelete.Size = new Size(480, 41);
            btnAuthorDelete.TabIndex = 3;
            btnAuthorDelete.Text = "SİL";
            btnAuthorDelete.UseVisualStyleBackColor = false;
            btnAuthorDelete.Click += btnAuthorDelete_Click;
            // 
            // btnAuthorSave
            // 
            btnAuthorSave.BackColor = Color.FromArgb(139, 94, 60);
            btnAuthorSave.FlatStyle = FlatStyle.Flat;
            btnAuthorSave.ForeColor = Color.FromArgb(75, 54, 33);
            btnAuthorSave.Location = new Point(25, 346);
            btnAuthorSave.Margin = new Padding(4, 3, 4, 3);
            btnAuthorSave.Name = "btnAuthorSave";
            btnAuthorSave.Size = new Size(480, 41);
            btnAuthorSave.TabIndex = 3;
            btnAuthorSave.Text = "KAYDET";
            btnAuthorSave.UseVisualStyleBackColor = false;
            btnAuthorSave.Click += btnAuthorSave_Click;
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(75, 54, 33);
            label2.Location = new Point(680, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(132, 33);
            label2.TabIndex = 0;
            label2.Text = "YAZAR LİSTESİ";
            // 
            // label4
            // 
            label4.ForeColor = Color.FromArgb(75, 54, 33);
            label4.Location = new Point(27, 138);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(132, 22);
            label4.TabIndex = 0;
            label4.Text = "YAZAR ADI";
            // 
            // txtAuthorName
            // 
            txtAuthorName.BackColor = Color.FromArgb(234, 216, 192);
            txtAuthorName.Location = new Point(217, 139);
            txtAuthorName.Margin = new Padding(4, 3, 4, 3);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(288, 26);
            txtAuthorName.TabIndex = 4;
            txtAuthorName.TextChanged += txtAuthorName_TextChanged;
            // 
            // AuthorAddForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1019, 433);
            Controls.Add(txtAuthorName);
            Controls.Add(btnAuthorSave);
            Controls.Add(btnAuthorDelete);
            Controls.Add(lstAuthorList);
            Controls.Add(txtAuthorSurname);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "AuthorAddForm";
            Text = "AuthorForm";
            Load += AuthorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAuthorSurname;
        private ListBox lstAuthorList;
        private Button btnAuthorDelete;
        private Button btnAuthorSave;
        private Label label2;
        private Label label4;
        private TextBox txtAuthorName;
    }
}