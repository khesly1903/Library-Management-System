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
            label1.Location = new Point(53, 107);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 0;
            label1.Text = "YAZAR SOYADI";
            // 
            // txtAuthorSurname
            // 
            txtAuthorSurname.Location = new Point(208, 103);
            txtAuthorSurname.Margin = new Padding(4, 3, 4, 3);
            txtAuthorSurname.Multiline = true;
            txtAuthorSurname.Name = "txtAuthorSurname";
            txtAuthorSurname.Size = new Size(320, 32);
            txtAuthorSurname.TabIndex = 1;
            // 
            // lstAuthorList
            // 
            lstAuthorList.FormattingEnabled = true;
            lstAuthorList.ItemHeight = 21;
            lstAuthorList.Location = new Point(568, 66);
            lstAuthorList.Margin = new Padding(4, 3, 4, 3);
            lstAuthorList.Name = "lstAuthorList";
            lstAuthorList.Size = new Size(320, 277);
            lstAuthorList.TabIndex = 2;
            lstAuthorList.SelectedIndexChanged += lstAuthorList_SelectedIndexChanged_1;
            // 
            // btnAuthorDelete
            // 
            btnAuthorDelete.ForeColor = Color.Red;
            btnAuthorDelete.Location = new Point(471, 447);
            btnAuthorDelete.Margin = new Padding(4, 3, 4, 3);
            btnAuthorDelete.Name = "btnAuthorDelete";
            btnAuthorDelete.Size = new Size(450, 46);
            btnAuthorDelete.TabIndex = 3;
            btnAuthorDelete.Text = "SİL";
            btnAuthorDelete.UseVisualStyleBackColor = true;
            btnAuthorDelete.Click += btnAuthorDelete_Click;
            // 
            // btnAuthorSave
            // 
            btnAuthorSave.ForeColor = Color.Green;
            btnAuthorSave.Location = new Point(13, 447);
            btnAuthorSave.Margin = new Padding(4, 3, 4, 3);
            btnAuthorSave.Name = "btnAuthorSave";
            btnAuthorSave.Size = new Size(450, 46);
            btnAuthorSave.TabIndex = 3;
            btnAuthorSave.Text = "KAYDET";
            btnAuthorSave.UseVisualStyleBackColor = true;
            btnAuthorSave.Click += btnAuthorSave_Click;
            // 
            // label2
            // 
            label2.Location = new Point(568, 27);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(286, 36);
            label2.TabIndex = 0;
            label2.Text = "YAZAR LİSTESİ";
            // 
            // label4
            // 
            label4.Location = new Point(53, 70);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(147, 25);
            label4.TabIndex = 0;
            label4.Text = "YAZAR ADI";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(208, 66);
            txtAuthorName.Margin = new Padding(4);
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(320, 29);
            txtAuthorName.TabIndex = 4;
            txtAuthorName.TextChanged += txtAuthorName_TextChanged;
            // 
            // AuthorAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(934, 661);
            Controls.Add(txtAuthorName);
            Controls.Add(btnAuthorSave);
            Controls.Add(btnAuthorDelete);
            Controls.Add(lstAuthorList);
            Controls.Add(txtAuthorSurname);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
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