namespace libraryProject.UI.Forms
{
    partial class AuthorForm
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
            txtAuthorName = new TextBox();
            txtAuthorSurname = new TextBox();
            lstAuthorList = new ListBox();
            btnAuthorDelete = new Button();
            btnAuthorSave = new Button();
            label2 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(34, 117);
            label1.Name = "label1";
            label1.Size = new Size(200, 26);
            label1.TabIndex = 0;
            label1.Text = "YAZAR SOYADI";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(34, 68);
            txtAuthorName.Margin = new Padding(3, 2, 3, 2);
            txtAuthorName.Multiline = true;
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(201, 39);
            txtAuthorName.TabIndex = 1;
            txtAuthorName.TextChanged += txtAuthorName_TextChanged;
            // 
            // txtAuthorSurname
            // 
            txtAuthorSurname.Location = new Point(34, 145);
            txtAuthorSurname.Margin = new Padding(3, 2, 3, 2);
            txtAuthorSurname.Multiline = true;
            txtAuthorSurname.Name = "txtAuthorSurname";
            txtAuthorSurname.Size = new Size(201, 39);
            txtAuthorSurname.TabIndex = 1;
            // 
            // lstAuthorList
            // 
            lstAuthorList.FormattingEnabled = true;
            lstAuthorList.ItemHeight = 15;
            lstAuthorList.Location = new Point(314, 68);
            lstAuthorList.Margin = new Padding(3, 2, 3, 2);
            lstAuthorList.Name = "lstAuthorList";
            lstAuthorList.Size = new Size(485, 259);
            lstAuthorList.TabIndex = 2;
            // 
            // btnAuthorDelete
            // 
            btnAuthorDelete.Location = new Point(34, 229);
            btnAuthorDelete.Margin = new Padding(3, 2, 3, 2);
            btnAuthorDelete.Name = "btnAuthorDelete";
            btnAuthorDelete.Size = new Size(109, 40);
            btnAuthorDelete.TabIndex = 3;
            btnAuthorDelete.Text = "SİL";
            btnAuthorDelete.UseVisualStyleBackColor = true;
            btnAuthorDelete.Click += btnAuthorDelete_Click;
            // 
            // btnAuthorSave
            // 
            btnAuthorSave.Location = new Point(149, 229);
            btnAuthorSave.Margin = new Padding(3, 2, 3, 2);
            btnAuthorSave.Name = "btnAuthorSave";
            btnAuthorSave.Size = new Size(109, 40);
            btnAuthorSave.TabIndex = 3;
            btnAuthorSave.Text = "KAYDET";
            btnAuthorSave.UseVisualStyleBackColor = true;
            btnAuthorSave.Click += btnAuthorSave_Click;
            // 
            // label2
            // 
            label2.Location = new Point(314, 32);
            label2.Name = "label2";
            label2.Size = new Size(200, 26);
            label2.TabIndex = 0;
            label2.Text = "YAZAR LİSTESİ";
            // 
            // label4
            // 
            label4.Location = new Point(34, 32);
            label4.Name = "label4";
            label4.Size = new Size(200, 26);
            label4.TabIndex = 0;
            label4.Text = "YAZAR ADI";
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(847, 426);
            Controls.Add(btnAuthorSave);
            Controls.Add(btnAuthorDelete);
            Controls.Add(lstAuthorList);
            Controls.Add(txtAuthorSurname);
            Controls.Add(txtAuthorName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AuthorForm";
            Text = "AuthorForm";
            Load += AuthorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAuthorName;
        private TextBox txtAuthorSurname;
        private ListBox lstAuthorList;
        private Button btnAuthorDelete;
        private Button btnAuthorSave;
        private Label label2;
        private Label label4;
    }
}