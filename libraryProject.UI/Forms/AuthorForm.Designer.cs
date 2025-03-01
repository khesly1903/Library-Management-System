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
            label1.Location = new Point(39, 156);
            label1.Name = "label1";
            label1.Size = new Size(229, 34);
            label1.TabIndex = 0;
            label1.Text = "YAZAR SOYADI";
            // 
            // txtAuthorName
            // 
            txtAuthorName.Location = new Point(39, 90);
            txtAuthorName.Multiline = true;
            txtAuthorName.Name = "txtAuthorName";
            txtAuthorName.Size = new Size(229, 51);
            txtAuthorName.TabIndex = 1;
            // 
            // txtAuthorSurname
            // 
            txtAuthorSurname.Location = new Point(39, 193);
            txtAuthorSurname.Multiline = true;
            txtAuthorSurname.Name = "txtAuthorSurname";
            txtAuthorSurname.Size = new Size(229, 51);
            txtAuthorSurname.TabIndex = 1;
            // 
            // lstAuthorList
            // 
            lstAuthorList.FormattingEnabled = true;
            lstAuthorList.Location = new Point(359, 90);
            lstAuthorList.Name = "lstAuthorList";
            lstAuthorList.Size = new Size(554, 344);
            lstAuthorList.TabIndex = 2;
            // 
            // btnAuthorDelete
            // 
            btnAuthorDelete.Location = new Point(39, 305);
            btnAuthorDelete.Name = "btnAuthorDelete";
            btnAuthorDelete.Size = new Size(125, 54);
            btnAuthorDelete.TabIndex = 3;
            btnAuthorDelete.Text = "SİL";
            btnAuthorDelete.UseVisualStyleBackColor = true;
            btnAuthorDelete.Click += btnAuthorDelete_Click;
            // 
            // btnAuthorSave
            // 
            btnAuthorSave.Location = new Point(170, 305);
            btnAuthorSave.Name = "btnAuthorSave";
            btnAuthorSave.Size = new Size(125, 54);
            btnAuthorSave.TabIndex = 3;
            btnAuthorSave.Text = "KAYDET";
            btnAuthorSave.UseVisualStyleBackColor = true;
            btnAuthorSave.Click += btnAuthorSave_Click;
            // 
            // label2
            // 
            label2.Location = new Point(359, 42);
            label2.Name = "label2";
            label2.Size = new Size(229, 34);
            label2.TabIndex = 0;
            label2.Text = "YAZAR LİSTESİ";
            // 
            // label4
            // 
            label4.Location = new Point(39, 42);
            label4.Name = "label4";
            label4.Size = new Size(229, 34);
            label4.TabIndex = 0;
            label4.Text = "YAZAR ADI";
            // 
            // AuthorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 568);
            Controls.Add(btnAuthorSave);
            Controls.Add(btnAuthorDelete);
            Controls.Add(lstAuthorList);
            Controls.Add(txtAuthorSurname);
            Controls.Add(txtAuthorName);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
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