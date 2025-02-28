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
            Label lblBookAuthor;
            Label lblBookType;
            Label lblBookLocation;
            Label lblBookISBN;
            Label lblBookTotalCopies;
            Label lblBookPublisher;
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            btnAdd = new Button();
            btnUpdata = new Button();
            btnList = new Button();
            btnDelete = new Button();
            txtBookTitle = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookISBN = new TextBox();
            txtBookType = new TextBox();
            txtBookLocation = new TextBox();
            txtBookTotalCopies = new TextBox();
            lstBooks = new ListBox();
            txtBookPublisher = new TextBox();
            lblBookTitle = new Label();
            lblBookAuthor = new Label();
            lblBookType = new Label();
            lblBookLocation = new Label();
            lblBookISBN = new Label();
            lblBookTotalCopies = new Label();
            lblBookPublisher = new Label();
            SuspendLayout();
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.BackColor = Color.Bisque;
            lblBookTitle.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookTitle.Location = new Point(25, 24);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(72, 16);
            lblBookTitle.TabIndex = 1;
            lblBookTitle.Text = "KİTAP ADI";
            lblBookTitle.Click += lblBookTitle_Click;
            // 
            // lblBookAuthor
            // 
            lblBookAuthor.AutoSize = true;
            lblBookAuthor.BackColor = Color.Bisque;
            lblBookAuthor.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookAuthor.Location = new Point(25, 59);
            lblBookAuthor.Name = "lblBookAuthor";
            lblBookAuthor.Size = new Size(97, 16);
            lblBookAuthor.TabIndex = 2;
            lblBookAuthor.Text = "KİTAP YAZARI";
            lblBookAuthor.Click += lblBookAuthor_Click;
            // 
            // lblBookType
            // 
            lblBookType.AutoSize = true;
            lblBookType.BackColor = Color.Bisque;
            lblBookType.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookType.Location = new Point(25, 127);
            lblBookType.Name = "lblBookType";
            lblBookType.Size = new Size(85, 16);
            lblBookType.TabIndex = 3;
            lblBookType.Text = "KİTAP TÜRÜ";
            lblBookType.Click += lblBookType_Click;
            // 
            // lblBookLocation
            // 
            lblBookLocation.AutoSize = true;
            lblBookLocation.BackColor = Color.Bisque;
            lblBookLocation.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookLocation.Location = new Point(25, 214);
            lblBookLocation.Name = "lblBookLocation";
            lblBookLocation.Size = new Size(78, 16);
            lblBookLocation.TabIndex = 4;
            lblBookLocation.Text = "KİTAP RAFI";
            lblBookLocation.Click += lblBookLocation_Click;
            // 
            // lblBookISBN
            // 
            lblBookISBN.AutoSize = true;
            lblBookISBN.BackColor = Color.Bisque;
            lblBookISBN.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookISBN.Location = new Point(25, 93);
            lblBookISBN.Name = "lblBookISBN";
            lblBookISBN.Size = new Size(78, 16);
            lblBookISBN.TabIndex = 5;
            lblBookISBN.Text = "KİTAP ISBN";
            lblBookISBN.Click += lblBookISBN_Click;
            // 
            // lblBookTotalCopies
            // 
            lblBookTotalCopies.AutoSize = true;
            lblBookTotalCopies.BackColor = Color.Bisque;
            lblBookTotalCopies.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookTotalCopies.Location = new Point(25, 252);
            lblBookTotalCopies.Name = "lblBookTotalCopies";
            lblBookTotalCopies.Size = new Size(84, 16);
            lblBookTotalCopies.TabIndex = 6;
            lblBookTotalCopies.Text = "KİTAP STOK";
            lblBookTotalCopies.Click += lblBookTotalCopies_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Location = new Point(1, 274);
            panel1.Name = "panel1";
            panel1.Size = new Size(604, 3);
            panel1.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(19, 293);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 65);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdata
            // 
            btnUpdata.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnUpdata.ForeColor = Color.SteelBlue;
            btnUpdata.Location = new Point(169, 293);
            btnUpdata.Name = "btnUpdata";
            btnUpdata.Size = new Size(121, 65);
            btnUpdata.TabIndex = 8;
            btnUpdata.Text = "GÜNCELLE";
            btnUpdata.UseVisualStyleBackColor = true;
            btnUpdata.Click += btnUpdata_Click;
            // 
            // btnList
            // 
            btnList.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnList.ForeColor = Color.Gray;
            btnList.Location = new Point(322, 293);
            btnList.Name = "btnList";
            btnList.Size = new Size(121, 65);
            btnList.TabIndex = 8;
            btnList.Text = "LİSTELE";
            btnList.UseVisualStyleBackColor = true;
            btnList.Click += btnList_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(472, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 65);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BackColor = SystemColors.AppWorkspace;
            txtBookTitle.Location = new Point(146, 20);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(203, 23);
            txtBookTitle.TabIndex = 9;
            txtBookTitle.TextChanged += txtBookTitle_TextChanged;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.BackColor = SystemColors.AppWorkspace;
            txtBookAuthor.Location = new Point(146, 52);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(203, 23);
            txtBookAuthor.TabIndex = 9;
            txtBookAuthor.TextChanged += txtBookAuthor_TextChanged;
            // 
            // txtBookISBN
            // 
            txtBookISBN.BackColor = SystemColors.AppWorkspace;
            txtBookISBN.Location = new Point(146, 86);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(203, 23);
            txtBookISBN.TabIndex = 9;
            txtBookISBN.TextChanged += txtBookISBN_TextChanged;
            // 
            // txtBookType
            // 
            txtBookType.BackColor = SystemColors.AppWorkspace;
            txtBookType.Location = new Point(146, 120);
            txtBookType.Name = "txtBookType";
            txtBookType.Size = new Size(203, 23);
            txtBookType.TabIndex = 9;
            txtBookType.TextChanged += txtBookType_TextChanged;
            // 
            // txtBookLocation
            // 
            txtBookLocation.BackColor = SystemColors.AppWorkspace;
            txtBookLocation.Location = new Point(146, 207);
            txtBookLocation.Name = "txtBookLocation";
            txtBookLocation.Size = new Size(203, 23);
            txtBookLocation.TabIndex = 9;
            txtBookLocation.TextChanged += txtBookLocation_TextChanged;
            // 
            // txtBookTotalCopies
            // 
            txtBookTotalCopies.BackColor = SystemColors.AppWorkspace;
            txtBookTotalCopies.Location = new Point(146, 245);
            txtBookTotalCopies.Name = "txtBookTotalCopies";
            txtBookTotalCopies.Size = new Size(203, 23);
            txtBookTotalCopies.TabIndex = 9;
            txtBookTotalCopies.TextChanged += txtBookTotalCopies_TextChanged;
            // 
            // lstBooks
            // 
            lstBooks.BackColor = Color.PeachPuff;
            lstBooks.FormattingEnabled = true;
            lstBooks.ItemHeight = 15;
            lstBooks.Location = new Point(371, 21);
            lstBooks.Name = "lstBooks";
            lstBooks.Size = new Size(222, 229);
            lstBooks.TabIndex = 10;
            lstBooks.SelectedIndexChanged += listBooks_SelectedIndexChanged;
            // 
            // lblBookPublisher
            // 
            lblBookPublisher.AutoSize = true;
            lblBookPublisher.BackColor = Color.Bisque;
            lblBookPublisher.Font = new Font("Lucida Fax", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookPublisher.Location = new Point(25, 170);
            lblBookPublisher.Name = "lblBookPublisher";
            lblBookPublisher.Size = new Size(109, 16);
            lblBookPublisher.TabIndex = 6;
            lblBookPublisher.Text = "KİTAP YAYINEVİ";
            lblBookPublisher.Click += lblBookTotalCopies_Click;
            // 
            // txtBookPublisher
            // 
            txtBookPublisher.BackColor = SystemColors.AppWorkspace;
            txtBookPublisher.Location = new Point(146, 163);
            txtBookPublisher.Name = "txtBookPublisher";
            txtBookPublisher.Size = new Size(203, 23);
            txtBookPublisher.TabIndex = 9;
            txtBookPublisher.TextChanged += txtBookTotalCopies_TextChanged;
            // 
            // BookAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(608, 384);
            Controls.Add(lstBooks);
            Controls.Add(txtBookPublisher);
            Controls.Add(txtBookTotalCopies);
            Controls.Add(txtBookLocation);
            Controls.Add(txtBookType);
            Controls.Add(txtBookISBN);
            Controls.Add(txtBookAuthor);
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
            Controls.Add(lblBookAuthor);
            Controls.Add(lblBookTitle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookAddForm";
            Text = "BookAddForm";
            Load += BookAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBookTitle;
        private Label lblBookAuthor;
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
        private TextBox txtBookAuthor;
        private TextBox txtBookISBN;
        private TextBox txtBookType;
        private TextBox txtBookLocation;
        private TextBox txtBookTotalCopies;
        private ListBox lstBooks;
        private TextBox txtBookPublisher;
    }
}