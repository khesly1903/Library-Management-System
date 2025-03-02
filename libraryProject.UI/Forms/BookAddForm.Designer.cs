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
            btnAdd = new Button();
            btnDelete = new Button();
            txtBookTitle = new TextBox();
            txtBookAuthorName = new TextBox();
            txtBookISBN = new TextBox();
            txtBookType = new TextBox();
            txtBookLocation = new TextBox();
            lstList = new ListBox();
            txtBookPublisher = new TextBox();
            txtBookAuthorSurname = new TextBox();
            numUdStock = new NumericUpDown();
            lstHelp = new ListBox();
            lblBookTitle = new Label();
            lblBookAuthorName = new Label();
            lblBookType = new Label();
            lblBookLocation = new Label();
            lblBookISBN = new Label();
            lblBookTotalCopies = new Label();
            lblBookPublisher = new Label();
            lblBookAuthorSurname = new Label();
            ((System.ComponentModel.ISupportInitialize)numUdStock).BeginInit();
            SuspendLayout();
            // 
            // lblBookTitle
            // 
            lblBookTitle.AutoSize = true;
            lblBookTitle.BackColor = Color.Transparent;
            lblBookTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookTitle.Location = new Point(53, 70);
            lblBookTitle.Margin = new Padding(4, 0, 4, 0);
            lblBookTitle.Name = "lblBookTitle";
            lblBookTitle.Size = new Size(95, 20);
            lblBookTitle.TabIndex = 1;
            lblBookTitle.Text = "KİTAP ADI";
            lblBookTitle.Click += lblBookTitle_Click;
            // 
            // lblBookAuthorName
            // 
            lblBookAuthorName.AutoSize = true;
            lblBookAuthorName.BackColor = Color.Transparent;
            lblBookAuthorName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookAuthorName.Location = new Point(53, 107);
            lblBookAuthorName.Margin = new Padding(4, 0, 4, 0);
            lblBookAuthorName.Name = "lblBookAuthorName";
            lblBookAuthorName.Size = new Size(105, 20);
            lblBookAuthorName.TabIndex = 2;
            lblBookAuthorName.Text = "YAZAR ADI";
            lblBookAuthorName.Click += lblBookAuthor_Click;
            // 
            // lblBookType
            // 
            lblBookType.AutoSize = true;
            lblBookType.BackColor = Color.Transparent;
            lblBookType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookType.Location = new Point(53, 218);
            lblBookType.Margin = new Padding(4, 0, 4, 0);
            lblBookType.Name = "lblBookType";
            lblBookType.Size = new Size(113, 20);
            lblBookType.TabIndex = 3;
            lblBookType.Text = "KİTAP TÜRÜ";
            lblBookType.Click += lblBookType_Click;
            // 
            // lblBookLocation
            // 
            lblBookLocation.AutoSize = true;
            lblBookLocation.BackColor = Color.Transparent;
            lblBookLocation.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookLocation.Location = new Point(53, 292);
            lblBookLocation.Margin = new Padding(4, 0, 4, 0);
            lblBookLocation.Name = "lblBookLocation";
            lblBookLocation.Size = new Size(106, 20);
            lblBookLocation.TabIndex = 4;
            lblBookLocation.Text = "KİTAP RAFI";
            lblBookLocation.Click += lblBookLocation_Click;
            // 
            // lblBookISBN
            // 
            lblBookISBN.AutoSize = true;
            lblBookISBN.BackColor = Color.Transparent;
            lblBookISBN.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookISBN.Location = new Point(53, 181);
            lblBookISBN.Margin = new Padding(4, 0, 4, 0);
            lblBookISBN.Name = "lblBookISBN";
            lblBookISBN.Size = new Size(106, 20);
            lblBookISBN.TabIndex = 5;
            lblBookISBN.Text = "KİTAP ISBN";
            lblBookISBN.Click += lblBookISBN_Click;
            // 
            // lblBookTotalCopies
            // 
            lblBookTotalCopies.AutoSize = true;
            lblBookTotalCopies.BackColor = Color.Transparent;
            lblBookTotalCopies.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookTotalCopies.Location = new Point(53, 329);
            lblBookTotalCopies.Margin = new Padding(4, 0, 4, 0);
            lblBookTotalCopies.Name = "lblBookTotalCopies";
            lblBookTotalCopies.Size = new Size(110, 20);
            lblBookTotalCopies.TabIndex = 6;
            lblBookTotalCopies.Text = "KİTAP STOK";
            lblBookTotalCopies.Click += lblBookTotalCopies_Click;
            // 
            // lblBookPublisher
            // 
            lblBookPublisher.AutoSize = true;
            lblBookPublisher.BackColor = Color.Transparent;
            lblBookPublisher.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookPublisher.Location = new Point(53, 255);
            lblBookPublisher.Margin = new Padding(4, 0, 4, 0);
            lblBookPublisher.Name = "lblBookPublisher";
            lblBookPublisher.Size = new Size(148, 20);
            lblBookPublisher.TabIndex = 6;
            lblBookPublisher.Text = "KİTAP YAYINEVİ";
            lblBookPublisher.Click += lblBookTotalCopies_Click;
            // 
            // lblBookAuthorSurname
            // 
            lblBookAuthorSurname.AutoSize = true;
            lblBookAuthorSurname.BackColor = Color.Transparent;
            lblBookAuthorSurname.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lblBookAuthorSurname.Location = new Point(53, 144);
            lblBookAuthorSurname.Margin = new Padding(4, 0, 4, 0);
            lblBookAuthorSurname.Name = "lblBookAuthorSurname";
            lblBookAuthorSurname.Size = new Size(142, 20);
            lblBookAuthorSurname.TabIndex = 11;
            lblBookAuthorSurname.Text = "YAZAR SOYADI";
            lblBookAuthorSurname.Click += label1_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Green;
            btnAdd.Location = new Point(13, 447);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(450, 46);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(471, 447);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(450, 46);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BackColor = SystemColors.Window;
            txtBookTitle.Location = new Point(208, 66);
            txtBookTitle.Margin = new Padding(4);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(320, 29);
            txtBookTitle.TabIndex = 9;
            txtBookTitle.TextChanged += txtBookTitle_TextChanged;
            // 
            // txtBookAuthorName
            // 
            txtBookAuthorName.BackColor = SystemColors.Window;
            txtBookAuthorName.Location = new Point(208, 103);
            txtBookAuthorName.Margin = new Padding(4);
            txtBookAuthorName.Name = "txtBookAuthorName";
            txtBookAuthorName.Size = new Size(320, 29);
            txtBookAuthorName.TabIndex = 9;
            txtBookAuthorName.TextChanged += txtBookAuthor_TextChanged;
            // 
            // txtBookISBN
            // 
            txtBookISBN.BackColor = SystemColors.Window;
            txtBookISBN.Location = new Point(208, 177);
            txtBookISBN.Margin = new Padding(4);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(320, 29);
            txtBookISBN.TabIndex = 9;
            txtBookISBN.TextChanged += txtBookISBN_TextChanged;
            // 
            // txtBookType
            // 
            txtBookType.BackColor = SystemColors.Window;
            txtBookType.Location = new Point(208, 214);
            txtBookType.Margin = new Padding(4);
            txtBookType.Name = "txtBookType";
            txtBookType.Size = new Size(320, 29);
            txtBookType.TabIndex = 9;
            txtBookType.TextChanged += txtBookType_TextChanged;
            // 
            // txtBookLocation
            // 
            txtBookLocation.BackColor = SystemColors.Window;
            txtBookLocation.Location = new Point(208, 288);
            txtBookLocation.Margin = new Padding(4);
            txtBookLocation.Name = "txtBookLocation";
            txtBookLocation.Size = new Size(320, 29);
            txtBookLocation.TabIndex = 9;
            txtBookLocation.TextChanged += txtBookLocation_TextChanged;
            // 
            // lstList
            // 
            lstList.BackColor = Color.White;
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 21;
            lstList.Location = new Point(568, 66);
            lstList.Margin = new Padding(4);
            lstList.Name = "lstList";
            lstList.Size = new Size(320, 277);
            lstList.TabIndex = 10;
            lstList.SelectedIndexChanged += listBooks_SelectedIndexChanged;
            // 
            // txtBookPublisher
            // 
            txtBookPublisher.BackColor = SystemColors.Window;
            txtBookPublisher.Location = new Point(208, 251);
            txtBookPublisher.Margin = new Padding(4);
            txtBookPublisher.Name = "txtBookPublisher";
            txtBookPublisher.Size = new Size(320, 29);
            txtBookPublisher.TabIndex = 9;
            txtBookPublisher.TextChanged += txtBookPublisher_TextChanged;
            // 
            // txtBookAuthorSurname
            // 
            txtBookAuthorSurname.BackColor = SystemColors.Window;
            txtBookAuthorSurname.Location = new Point(208, 140);
            txtBookAuthorSurname.Margin = new Padding(4);
            txtBookAuthorSurname.Name = "txtBookAuthorSurname";
            txtBookAuthorSurname.Size = new Size(320, 29);
            txtBookAuthorSurname.TabIndex = 12;
            // 
            // numUdStock
            // 
            numUdStock.Location = new Point(208, 324);
            numUdStock.Name = "numUdStock";
            numUdStock.Size = new Size(120, 29);
            numUdStock.TabIndex = 13;
            numUdStock.ValueChanged += numUdStock_ValueChanged;
            // 
            // lstHelp
            // 
            lstHelp.FormattingEnabled = true;
            lstHelp.ItemHeight = 21;
            lstHelp.Location = new Point(568, 352);
            lstHelp.Name = "lstHelp";
            lstHelp.Size = new Size(320, 88);
            lstHelp.TabIndex = 14;
            lstHelp.SelectedIndexChanged += lstHelp_SelectedIndexChanged;
            // 
            // BookAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(950, 700);
            Controls.Add(lstHelp);
            Controls.Add(numUdStock);
            Controls.Add(txtBookAuthorSurname);
            Controls.Add(lblBookAuthorSurname);
            Controls.Add(lstList);
            Controls.Add(txtBookPublisher);
            Controls.Add(txtBookLocation);
            Controls.Add(txtBookType);
            Controls.Add(txtBookISBN);
            Controls.Add(txtBookAuthorName);
            Controls.Add(txtBookTitle);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblBookPublisher);
            Controls.Add(lblBookTotalCopies);
            Controls.Add(lblBookISBN);
            Controls.Add(lblBookLocation);
            Controls.Add(lblBookType);
            Controls.Add(lblBookAuthorName);
            Controls.Add(lblBookTitle);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "BookAddForm";
            Text = "BookAddForm";
            Load += BookAddForm_Load;
            ((System.ComponentModel.ISupportInitialize)numUdStock).EndInit();
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
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtBookTitle;
        private TextBox txtBookAuthorName;
        private TextBox txtBookISBN;
        private TextBox txtBookType;
        private TextBox txtBookLocation;
        private ListBox lstList;
        private TextBox txtBookPublisher;
        private TextBox txtBookAuthorSurname;
        private NumericUpDown numUdStock;
        private ListBox lstHelp;
    }
}