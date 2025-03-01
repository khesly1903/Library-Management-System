namespace libraryProject.UI.Forms
{
    partial class BookAddForm
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
            Label lblBookTitle;
            Label lblBookAuthorName;
            Label lblBookType;
            Label lblBookLocation;
            Label lblBookISBN;
            Label lblBookTotalCopies;
            Label lblBookPublisher;
            Label lblBookAuthorSurname;
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            btnAdd = new Button();
            btnUpdata = new Button();
            btnList = new Button();
            btnDelete = new Button();
            txtBookTitle = new TextBox();
            txtBookAuthorName = new TextBox();
            txtBookISBN = new TextBox();
            txtBookType = new TextBox();
            txtBookLocation = new TextBox();
            txtBookTotalCopies = new TextBox();
            lstBooks = new ListBox();
            txtBookPublisher = new TextBox();
            txtBookAuthorSurname = new TextBox();
            lblBookTitle = new Label();
            lblBookAuthorName = new Label();
            lblBookType = new Label();
            lblBookLocation = new Label();
            lblBookISBN = new Label();
            lblBookTotalCopies = new Label();
            lblBookPublisher = new Label();
            lblBookAuthorSurname = new Label();
            SuspendLayout();
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.BackColor = Color.Bisque;
            lblBookTitle.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookTitle.Location = new Point(29, 32);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(89, 20);
            lblBookTitle.TabIndex = 1;
            lblBookTitle.Text = "KİTAP ADI";
            lblBookTitle.Click += lblBookTitle_Click;
            // 
            // lblBookAuthorName
            // 
            lblBookAuthorName.AutoSize = true;
            lblBookAuthorName.BackColor = Color.Bisque;
            lblBookAuthorName.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookAuthorName.Location = new Point(29, 83);
            lblBookAuthorName.Name = "lblBookAuthorName";
            lblBookAuthorName.Size = new Size(95, 20);
            lblBookAuthorName.TabIndex = 2;
            lblBookAuthorName.Text = "YAZAR ADI";
            lblBookAuthorName.Click += lblBookAuthor_Click;
            // 
            // lblBookType
            // 
            lblBookType.AutoSize = true;
            lblBookType.BackColor = Color.Bisque;
            lblBookType.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookType.Location = new Point(29, 237);
            lblBookType.Name = "lblBookType";
            lblBookType.Size = new Size(107, 20);
            lblBookType.TabIndex = 3;
            lblBookType.Text = "KİTAP TÜRÜ";
            lblBookType.Click += lblBookType_Click;
            // 
            // lblBookLocation
            // 
            lblBookLocation.AutoSize = true;
            lblBookLocation.BackColor = Color.Bisque;
            lblBookLocation.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookLocation.Location = new Point(30, 337);
            lblBookLocation.Name = "lblBookLocation";
            lblBookLocation.Size = new Size(98, 20);
            lblBookLocation.TabIndex = 4;
            lblBookLocation.Text = "KİTAP RAFI";
            lblBookLocation.Click += lblBookLocation_Click;
            // 
            // lblBookISBN
            // 
            lblBookISBN.AutoSize = true;
            lblBookISBN.BackColor = Color.Bisque;
            lblBookISBN.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookISBN.Location = new Point(30, 187);
            lblBookISBN.Name = "lblBookISBN";
            lblBookISBN.Size = new Size(100, 20);
            lblBookISBN.TabIndex = 5;
            lblBookISBN.Text = "KİTAP ISBN";
            lblBookISBN.Click += lblBookISBN_Click;
            // 
            // lblBookTotalCopies
            // 
            lblBookTotalCopies.AutoSize = true;
            lblBookTotalCopies.BackColor = Color.Bisque;
            lblBookTotalCopies.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookTotalCopies.Location = new Point(29, 387);
            lblBookTotalCopies.Name = "lblBookTotalCopies";
            lblBookTotalCopies.Size = new Size(106, 20);
            lblBookTotalCopies.TabIndex = 6;
            lblBookTotalCopies.Text = "KİTAP STOK";
            lblBookTotalCopies.Click += lblBookTotalCopies_Click;
            // 
            // lblBookPublisher
            // 
            lblBookPublisher.AutoSize = true;
            lblBookPublisher.BackColor = Color.Bisque;
            lblBookPublisher.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookPublisher.Location = new Point(29, 287);
            lblBookPublisher.Name = "lblBookPublisher";
            lblBookPublisher.Size = new Size(134, 20);
            lblBookPublisher.TabIndex = 6;
            lblBookPublisher.Text = "KİTAP YAYINEVİ";
            lblBookPublisher.Click += lblBookTotalCopies_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Location = new Point(12, 439);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 5);
            panel1.TabIndex = 7;
            panel1.Paint += panel1_Paint;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(29, 467);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(138, 87);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdata
            // 
            btnUpdata.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnUpdata.ForeColor = Color.SteelBlue;
            btnUpdata.Location = new Point(190, 467);
            btnUpdata.Margin = new Padding(3, 4, 3, 4);
            btnUpdata.Name = "btnUpdata";
            btnUpdata.Size = new Size(138, 87);
            btnUpdata.TabIndex = 8;
            btnUpdata.Text = "GÜNCELLE";
            btnUpdata.UseVisualStyleBackColor = true;
            btnUpdata.Click += btnUpdata_Click;
            // 
            // btnList
            // 
            btnList.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnList.ForeColor = Color.Gray;
            btnList.Location = new Point(351, 467);
            btnList.Margin = new Padding(3, 4, 3, 4);
            btnList.Name = "btnList";
            btnList.Size = new Size(138, 87);
            btnList.TabIndex = 8;
            btnList.Text = "LİSTELE";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(516, 467);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(138, 87);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BackColor = SystemColors.AppWorkspace;
            txtBookTitle.Location = new Point(209, 30);
            txtBookTitle.Margin = new Padding(3, 4, 3, 4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(231, 27);
            txtBookTitle.TabIndex = 9;
            txtBookTitle.TextChanged += txtBookTitle_TextChanged;
            // 
            // txtBookAuthorName
            // 
            txtBookAuthorName.BackColor = SystemColors.AppWorkspace;
            txtBookAuthorName.Location = new Point(209, 80);
            txtBookAuthorName.Margin = new Padding(3, 4, 3, 4);
            txtBookAuthorName.Name = "txtBookAuthorName";
            txtBookAuthorName.Size = new Size(231, 27);
            txtBookAuthorName.TabIndex = 9;
            txtBookAuthorName.TextChanged += txtBookAuthor_TextChanged;
            // 
            // txtBookISBN
            // 
            txtBookISBN.BackColor = SystemColors.AppWorkspace;
            txtBookISBN.Location = new Point(209, 180);
            txtBookISBN.Margin = new Padding(3, 4, 3, 4);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(231, 27);
            txtBookISBN.TabIndex = 9;
            txtBookISBN.TextChanged += txtBookISBN_TextChanged;
            // 
            // txtBookType
            // 
            txtBookType.BackColor = SystemColors.AppWorkspace;
            txtBookType.Location = new Point(209, 230);
            txtBookType.Margin = new Padding(3, 4, 3, 4);
            txtBookType.Name = "txtBookType";
            txtBookType.Size = new Size(231, 27);
            txtBookType.TabIndex = 9;
            txtBookType.TextChanged += txtBookType_TextChanged;
            // 
            // txtBookLocation
            // 
            txtBookLocation.BackColor = SystemColors.AppWorkspace;
            txtBookLocation.Location = new Point(209, 330);
            txtBookLocation.Margin = new Padding(3, 4, 3, 4);
            txtBookLocation.Name = "txtBookLocation";
            txtBookLocation.Size = new Size(231, 27);
            txtBookLocation.TabIndex = 9;
            txtBookLocation.TextChanged += txtBookLocation_TextChanged;
            // 
            // txtBookTotalCopies
            // 
            txtBookTotalCopies.BackColor = SystemColors.AppWorkspace;
            txtBookTotalCopies.Location = new Point(209, 380);
            txtBookTotalCopies.Margin = new Padding(3, 4, 3, 4);
            txtBookTotalCopies.Name = "txtBookTotalCopies";
            txtBookTotalCopies.Size = new Size(231, 27);
            txtBookTotalCopies.TabIndex = 9;
            txtBookTotalCopies.TextChanged += txtBookTotalCopies_TextChanged;
            // 
            // lstBooks
            // 
            lstBooks.BackColor = Color.PeachPuff;
            lstBooks.FormattingEnabled = true;
            lstBooks.Location = new Point(467, 30);
            lstBooks.Margin = new Padding(3, 4, 3, 4);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(265, 304);
            lstBooks.TabIndex = 10;
            lstBooks.SelectedIndexChanged += listBooks_SelectedIndexChanged;
            // 
            // txtBookPublisher
            // 
            txtBookPublisher.BackColor = SystemColors.AppWorkspace;
            txtBookPublisher.Location = new Point(209, 280);
            txtBookPublisher.Margin = new Padding(3, 4, 3, 4);
            txtBookPublisher.Name = "txtBookPublisher";
            txtBookPublisher.Size = new Size(231, 27);
            txtBookPublisher.TabIndex = 9;
            txtBookPublisher.TextChanged += txtBookTotalCopies_TextChanged;
            // 
            // lblBookAuthorSurname
            // 
            lblBookAuthorSurname.AutoSize = true;
            lblBookAuthorSurname.BackColor = Color.Bisque;
            lblBookAuthorSurname.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookAuthorSurname.Location = new Point(30, 137);
            lblBookAuthorSurname.Name = "lblBookAuthorSurname";
            lblBookAuthorSurname.Size = new Size(129, 20);
            lblBookAuthorSurname.TabIndex = 11;
            lblBookAuthorSurname.Text = "YAZAR SOYADI";
            lblBookAuthorSurname.Click += label1_Click;
            // 
            // txtBookAuthorSurname
            // 
            txtBookAuthorSurname.BackColor = SystemColors.AppWorkspace;
            txtBookAuthorSurname.Location = new Point(209, 130);
            txtBookAuthorSurname.Margin = new Padding(3, 4, 3, 4);
            txtBookAuthorSurname.Name = "txtBookAuthorSurname";
            txtBookAuthorSurname.Size = new Size(231, 27);
            txtBookAuthorSurname.TabIndex = 12;
            // 
            // BookAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(777, 658);
            Controls.Add(txtBookAuthorSurname);
            Controls.Add(lblBookAuthorSurname);
            Controls.Add(lstBooks);
            Controls.Add(txtBookPublisher);
            Controls.Add(txtBookTotalCopies);
            Controls.Add(txtBookLocation);
            Controls.Add(txtBookType);
            Controls.Add(txtBookISBN);
            Controls.Add(txtBookAuthorName);
            Controls.Add(txtBookTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnList);
            Controls.Add(btnUpdata);
            Controls.Add(btnAdd);
            Controls.Add(lblBookPublisher);
            Controls.Add(panel1);
            Controls.Add(lblBookTotalCopies);
            Controls.Add(lblBookISBN);
            Controls.Add(lblBookLocation);
            Controls.Add(lblBookType);
            Controls.Add(lblBookAuthorName);
            Controls.Add(lblBookTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "BookAddForm";
            Text = "BookAddForm";
            Load += BookAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBookTitle;
        private Label lblBookAuthorName;
        private Label lblBookType;
        private Label lblBookLocation;
        private Label lblBookISBN;
        private Label lblBookTotalCopies;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Button btnAdd;
        private Button btnUpdata;
        private Button btnList;
        private Button btnDelete;
        private TextBox txtBookTitle;
        private TextBox txtBookAuthorName;
        private TextBox txtBookISBN;
        private TextBox txtBookType;
        private TextBox txtBookLocation;
        private TextBox txtBookTotalCopies;
        private ListBox lstBooks;
        private TextBox txtBookPublisher;
        private TextBox txtBookAuthorSurname;
    }
}