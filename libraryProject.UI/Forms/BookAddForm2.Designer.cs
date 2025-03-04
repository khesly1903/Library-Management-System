namespace libraryProject.UI.Forms
{
    partial class BookAddForm2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtBookName = new TextBox();
            txtBookISBN = new TextBox();
            cmbBookAuthor = new ComboBox();
            cmbBookPublisher = new ComboBox();
            numBookStock = new NumericUpDown();
            btnAdd = new Button();
            btnDelete = new Button();
            lstList = new ListBox();
            cmbBookShelf = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)numBookStock).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.FromArgb(75, 54, 33);
            label1.Location = new Point(165, 147);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "KİTAP ADI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(75, 54, 33);
            label2.Location = new Point(165, 221);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(57, 28);
            label2.TabIndex = 1;
            label2.Text = "Yazar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(75, 54, 33);
            label3.Location = new Point(165, 184);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 28);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(75, 54, 33);
            label4.Location = new Point(165, 258);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 28);
            label4.TabIndex = 3;
            label4.Text = "Yayın Evi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(75, 54, 33);
            label5.Location = new Point(165, 295);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 28);
            label5.TabIndex = 4;
            label5.Text = "Raf";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(75, 54, 33);
            label6.Location = new Point(165, 332);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(47, 28);
            label6.TabIndex = 5;
            label6.Text = "Stok";
            // 
            // txtBookName
            // 
            txtBookName.BackColor = Color.FromArgb(234, 216, 192);
            txtBookName.Location = new Point(320, 143);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(320, 36);
            txtBookName.TabIndex = 6;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // txtBookISBN
            // 
            txtBookISBN.BackColor = Color.FromArgb(234, 216, 192);
            txtBookISBN.Location = new Point(320, 180);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(320, 36);
            txtBookISBN.TabIndex = 7;
            // 
            // cmbBookAuthor
            // 
            cmbBookAuthor.BackColor = Color.FromArgb(234, 216, 192);
            cmbBookAuthor.DropDownHeight = 200;
            cmbBookAuthor.FormattingEnabled = true;
            cmbBookAuthor.IntegralHeight = false;
            cmbBookAuthor.Location = new Point(320, 217);
            cmbBookAuthor.Name = "cmbBookAuthor";
            cmbBookAuthor.Size = new Size(320, 36);
            cmbBookAuthor.TabIndex = 8;
            cmbBookAuthor.SelectedIndexChanged += cmbBookAuthor_SelectedIndexChanged;
            // 
            // cmbBookPublisher
            // 
            cmbBookPublisher.BackColor = Color.FromArgb(234, 216, 192);
            cmbBookPublisher.DropDownHeight = 200;
            cmbBookPublisher.FormattingEnabled = true;
            cmbBookPublisher.IntegralHeight = false;
            cmbBookPublisher.Location = new Point(320, 254);
            cmbBookPublisher.Name = "cmbBookPublisher";
            cmbBookPublisher.Size = new Size(320, 36);
            cmbBookPublisher.TabIndex = 9;
            cmbBookPublisher.SelectedIndexChanged += cmbBookPublisher_SelectedIndexChanged;
            // 
            // numBookStock
            // 
            numBookStock.BackColor = Color.FromArgb(234, 216, 192);
            numBookStock.Location = new Point(320, 328);
            numBookStock.Name = "numBookStock";
            numBookStock.Size = new Size(320, 36);
            numBookStock.TabIndex = 10;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(139, 94, 60);
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAdd.ForeColor = Color.FromArgb(75, 54, 33);
            btnAdd.Location = new Point(28, 510);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(515, 60);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(139, 94, 60);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnDelete.ForeColor = Color.FromArgb(75, 54, 33);
            btnDelete.Location = new Point(680, 510);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(515, 60);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "SİL";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstList
            // 
            lstList.BackColor = Color.FromArgb(234, 216, 192);
            lstList.FormattingEnabled = true;
            lstList.ItemHeight = 28;
            lstList.Location = new Point(680, 143);
            lstList.Name = "lstList";
            lstList.Size = new Size(320, 256);
            lstList.TabIndex = 14;
            lstList.SelectedIndexChanged += lstList_SelectedIndexChanged;
            // 
            // cmbBookShelf
            // 
            cmbBookShelf.BackColor = Color.FromArgb(234, 216, 192);
            cmbBookShelf.DropDownHeight = 200;
            cmbBookShelf.FormattingEnabled = true;
            cmbBookShelf.IntegralHeight = false;
            cmbBookShelf.Location = new Point(320, 291);
            cmbBookShelf.Name = "cmbBookShelf";
            cmbBookShelf.Size = new Size(320, 36);
            cmbBookShelf.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(75, 54, 33);
            label7.Location = new Point(778, 112);
            label7.Name = "label7";
            label7.Size = new Size(131, 28);
            label7.TabIndex = 16;
            label7.Text = "KİTAP LİSTESİ";
            // 
            // BookAddForm2
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1234, 611);
            Controls.Add(label7);
            Controls.Add(cmbBookShelf);
            Controls.Add(lstList);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(numBookStock);
            Controls.Add(cmbBookPublisher);
            Controls.Add(cmbBookAuthor);
            Controls.Add(txtBookISBN);
            Controls.Add(txtBookName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 5, 4, 5);
            Name = "BookAddForm2";
            Text = "BookAddForm2";
            Load += BookAddForm2_Load;
            ((System.ComponentModel.ISupportInitialize)numBookStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtBookName;
        private TextBox txtBookISBN;
        private ComboBox cmbBookAuthor;
        private ComboBox cmbBookPublisher;
        private NumericUpDown numBookStock;
        private Button btnAdd;
        private Button btnDelete;
        private ListBox lstList;
        private ComboBox cmbBookShelf;
        private Label label7;
    }
}