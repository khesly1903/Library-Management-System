namespace libraryProject.UI.Forms
{
    partial class PublisherAddForm
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
            txtPublisherName = new TextBox();
            txtPublisherAddress = new TextBox();
            txtContactNumber = new TextBox();
            lstPublisherList = new ListBox();
            btnPublisherDelete = new Button();
            btnPublisherSave = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.ForeColor = Color.FromArgb(75, 54, 33);
            label1.Location = new Point(165, 94);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 37);
            label1.TabIndex = 0;
            label1.Text = "YAYINEVİ ADI";
            // 
            // label2
            // 
            label2.ForeColor = Color.FromArgb(75, 54, 33);
            label2.Location = new Point(165, 144);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 37);
            label2.TabIndex = 0;
            label2.Text = "YAYINEVİ ADRESİ";
            // 
            // label3
            // 
            label3.ForeColor = Color.FromArgb(75, 54, 33);
            label3.Location = new Point(165, 193);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(301, 47);
            label3.TabIndex = 0;
            label3.Text = "İLETİŞİM NO";
            // 
            // txtPublisherName
            // 
            txtPublisherName.BackColor = Color.FromArgb(234, 216, 192);
            txtPublisherName.Location = new Point(320, 89);
            txtPublisherName.Margin = new Padding(4);
            txtPublisherName.Multiline = true;
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(320, 41);
            txtPublisherName.TabIndex = 1;
            txtPublisherName.TextChanged += txtPublisherName_TextChanged;
            // 
            // txtPublisherAddress
            // 
            txtPublisherAddress.BackColor = Color.FromArgb(234, 216, 192);
            txtPublisherAddress.Location = new Point(320, 138);
            txtPublisherAddress.Margin = new Padding(4);
            txtPublisherAddress.Multiline = true;
            txtPublisherAddress.Name = "txtPublisherAddress";
            txtPublisherAddress.Size = new Size(320, 41);
            txtPublisherAddress.TabIndex = 1;
            // 
            // txtContactNumber
            // 
            txtContactNumber.BackColor = Color.FromArgb(234, 216, 192);
            txtContactNumber.Location = new Point(320, 188);
            txtContactNumber.Margin = new Padding(4);
            txtContactNumber.Multiline = true;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(320, 41);
            txtContactNumber.TabIndex = 1;
            // 
            // lstPublisherList
            // 
            lstPublisherList.BackColor = Color.FromArgb(234, 216, 192);
            lstPublisherList.FormattingEnabled = true;
            lstPublisherList.ItemHeight = 28;
            lstPublisherList.Location = new Point(680, 89);
            lstPublisherList.Margin = new Padding(4);
            lstPublisherList.Name = "lstPublisherList";
            lstPublisherList.Size = new Size(320, 368);
            lstPublisherList.TabIndex = 2;
            lstPublisherList.SelectedIndexChanged += lstPublisherList_SelectedIndexChanged;
            // 
            // btnPublisherDelete
            // 
            btnPublisherDelete.BackColor = Color.FromArgb(139, 94, 60);
            btnPublisherDelete.FlatStyle = FlatStyle.Flat;
            btnPublisherDelete.ForeColor = Color.FromArgb(75, 54, 33);
            btnPublisherDelete.Location = new Point(680, 510);
            btnPublisherDelete.Margin = new Padding(4);
            btnPublisherDelete.Name = "btnPublisherDelete";
            btnPublisherDelete.Size = new Size(515, 60);
            btnPublisherDelete.TabIndex = 3;
            btnPublisherDelete.Text = "SİL";
            btnPublisherDelete.UseVisualStyleBackColor = false;
            btnPublisherDelete.Click += btnPublisherDelete_Click;
            // 
            // btnPublisherSave
            // 
            btnPublisherSave.BackColor = Color.FromArgb(139, 94, 60);
            btnPublisherSave.FlatStyle = FlatStyle.Flat;
            btnPublisherSave.ForeColor = Color.FromArgb(75, 54, 33);
            btnPublisherSave.Location = new Point(28, 510);
            btnPublisherSave.Margin = new Padding(4);
            btnPublisherSave.Name = "btnPublisherSave";
            btnPublisherSave.Size = new Size(515, 60);
            btnPublisherSave.TabIndex = 3;
            btnPublisherSave.Text = "KAYDET";
            btnPublisherSave.UseVisualStyleBackColor = false;
            btnPublisherSave.Click += btnPublisherSave_Click;
            // 
            // label4
            // 
            label4.ForeColor = Color.FromArgb(75, 54, 33);
            label4.Location = new Point(773, 38);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(144, 47);
            label4.TabIndex = 0;
            label4.Text = "YAYINEVİ LİSTESİ";
            // 
            // PublisherAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 225, 200);
            ClientSize = new Size(1234, 611);
            Controls.Add(btnPublisherSave);
            Controls.Add(btnPublisherDelete);
            Controls.Add(lstPublisherList);
            Controls.Add(txtContactNumber);
            Controls.Add(txtPublisherAddress);
            Controls.Add(txtPublisherName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "PublisherAddForm";
            Text = "PublisherForm";
            Load += PublisherForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPublisherName;
        private TextBox txtPublisherAddress;
        private TextBox txtContactNumber;
        private ListBox lstPublisherList;
        private Button btnPublisherDelete;
        private Button btnPublisherSave;
        private Label label4;
    }
}