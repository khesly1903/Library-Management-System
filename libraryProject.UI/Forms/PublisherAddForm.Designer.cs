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
            label1.Location = new Point(53, 70);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 28);
            label1.TabIndex = 0;
            label1.Text = "YAYINEVİ ADI";
            // 
            // label2
            // 
            label2.Location = new Point(53, 107);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 28);
            label2.TabIndex = 0;
            label2.Text = "YAYINEVİ ADRESİ";
            // 
            // label3
            // 
            label3.Location = new Point(53, 144);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(301, 35);
            label3.TabIndex = 0;
            label3.Text = "İLETİŞİM NO";
            // 
            // txtPublisherName
            // 
            txtPublisherName.Location = new Point(208, 66);
            txtPublisherName.Margin = new Padding(4, 3, 4, 3);
            txtPublisherName.Multiline = true;
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(320, 32);
            txtPublisherName.TabIndex = 1;
            txtPublisherName.TextChanged += txtPublisherName_TextChanged;
            // 
            // txtPublisherAddress
            // 
            txtPublisherAddress.Location = new Point(208, 103);
            txtPublisherAddress.Margin = new Padding(4, 3, 4, 3);
            txtPublisherAddress.Multiline = true;
            txtPublisherAddress.Name = "txtPublisherAddress";
            txtPublisherAddress.Size = new Size(320, 32);
            txtPublisherAddress.TabIndex = 1;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(208, 140);
            txtContactNumber.Margin = new Padding(4, 3, 4, 3);
            txtContactNumber.Multiline = true;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(320, 32);
            txtContactNumber.TabIndex = 1;
            // 
            // lstPublisherList
            // 
            lstPublisherList.FormattingEnabled = true;
            lstPublisherList.ItemHeight = 21;
            lstPublisherList.Location = new Point(568, 66);
            lstPublisherList.Margin = new Padding(4, 3, 4, 3);
            lstPublisherList.Name = "lstPublisherList";
            lstPublisherList.Size = new Size(320, 277);
            lstPublisherList.TabIndex = 2;
            lstPublisherList.SelectedIndexChanged += lstPublisherList_SelectedIndexChanged;
            // 
            // btnPublisherDelete
            // 
            btnPublisherDelete.ForeColor = Color.Red;
            btnPublisherDelete.Location = new Point(471, 447);
            btnPublisherDelete.Margin = new Padding(4, 3, 4, 3);
            btnPublisherDelete.Name = "btnPublisherDelete";
            btnPublisherDelete.Size = new Size(450, 46);
            btnPublisherDelete.TabIndex = 3;
            btnPublisherDelete.Text = "SİL";
            btnPublisherDelete.UseVisualStyleBackColor = true;
            btnPublisherDelete.Click += btnPublisherDelete_Click;
            // 
            // btnPublisherSave
            // 
            btnPublisherSave.ForeColor = Color.Green;
            btnPublisherSave.Location = new Point(13, 447);
            btnPublisherSave.Margin = new Padding(4, 3, 4, 3);
            btnPublisherSave.Name = "btnPublisherSave";
            btnPublisherSave.Size = new Size(450, 46);
            btnPublisherSave.TabIndex = 3;
            btnPublisherSave.Text = "KAYDET";
            btnPublisherSave.UseVisualStyleBackColor = true;
            btnPublisherSave.Click += btnPublisherSave_Click;
            // 
            // label4
            // 
            label4.Location = new Point(568, 28);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(301, 35);
            label4.TabIndex = 0;
            label4.Text = "YAYINEVİ LİSTESİ";
            // 
            // PublisherAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(934, 661);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
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