namespace libraryProject.UI.Forms
{
    partial class PublisherForm
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
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(241, 33);
            label1.TabIndex = 0;
            label1.Text = "YAYINEVİ ADI";
            // 
            // label2
            // 
            label2.Location = new Point(30, 159);
            label2.Name = "label2";
            label2.Size = new Size(241, 33);
            label2.TabIndex = 0;
            label2.Text = "YAYINEVİ ADRESİ";
            // 
            // label3
            // 
            label3.Location = new Point(30, 274);
            label3.Name = "label3";
            label3.Size = new Size(241, 33);
            label3.TabIndex = 0;
            label3.Text = "İLETİŞİM NUMARASI";
            // 
            // txtPublisherName
            // 
            txtPublisherName.Location = new Point(31, 88);
            txtPublisherName.Multiline = true;
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.Size = new Size(287, 51);
            txtPublisherName.TabIndex = 1;
            txtPublisherName.TextChanged += txtPublisherName_TextChanged;
            // 
            // txtPublisherAddress
            // 
            txtPublisherAddress.Location = new Point(30, 195);
            txtPublisherAddress.Multiline = true;
            txtPublisherAddress.Name = "txtPublisherAddress";
            txtPublisherAddress.Size = new Size(287, 51);
            txtPublisherAddress.TabIndex = 1;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(31, 310);
            txtContactNumber.Multiline = true;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.Size = new Size(287, 51);
            txtContactNumber.TabIndex = 1;
            // 
            // lstPublisherList
            // 
            lstPublisherList.FormattingEnabled = true;
            lstPublisherList.Location = new Point(395, 86);
            lstPublisherList.Name = "lstPublisherList";
            lstPublisherList.Size = new Size(498, 364);
            lstPublisherList.TabIndex = 2;
            lstPublisherList.SelectedIndexChanged += lstPublisherList_SelectedIndexChanged;
            // 
            // btnPublisherDelete
            // 
            btnPublisherDelete.Location = new Point(31, 390);
            btnPublisherDelete.Name = "btnPublisherDelete";
            btnPublisherDelete.Size = new Size(130, 54);
            btnPublisherDelete.TabIndex = 3;
            btnPublisherDelete.Text = "SİL";
            btnPublisherDelete.UseVisualStyleBackColor = true;
            btnPublisherDelete.Click += btnPublisherDelete_Click;
            // 
            // btnPublisherSave
            // 
            btnPublisherSave.Location = new Point(188, 390);
            btnPublisherSave.Name = "btnPublisherSave";
            btnPublisherSave.Size = new Size(130, 54);
            btnPublisherSave.TabIndex = 3;
            btnPublisherSave.Text = "KAYDET";
            btnPublisherSave.UseVisualStyleBackColor = true;
            btnPublisherSave.Click += btnPublisherSave_Click;
            // 
            // label4
            // 
            label4.Location = new Point(395, 48);
            label4.Name = "label4";
            label4.Size = new Size(241, 33);
            label4.TabIndex = 0;
            label4.Text = "YAYINEVİ LİSTESİ";
            // 
            // PublisherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 566);
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
            Name = "PublisherForm";
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