namespace libraryProject.UI
{
    partial class StudentAddForm
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
            btnStudentDelete = new Button();
            btnStudentUpgrade = new Button();
            btnStudentSave = new Button();
            txtStudentName = new TextBox();
            txtStudentSurname = new TextBox();
            txtStudentNumber = new TextBox();
            lstStudentList = new ListBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(61, 72);
            label1.Name = "label1";
            label1.Size = new Size(209, 34);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ ADI";
            // 
            // label2
            // 
            label2.Location = new Point(61, 185);
            label2.Name = "label2";
            label2.Size = new Size(209, 34);
            label2.TabIndex = 0;
            label2.Text = "ÖĞRENCİ SOYADI";
            // 
            // label3
            // 
            label3.Location = new Point(61, 295);
            label3.Name = "label3";
            label3.Size = new Size(209, 34);
            label3.TabIndex = 0;
            label3.Text = "ÖĞRENCİ NUMARASI";
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.Location = new Point(61, 422);
            btnStudentDelete.Name = "btnStudentDelete";
            btnStudentDelete.Size = new Size(125, 44);
            btnStudentDelete.TabIndex = 1;
            btnStudentDelete.Text = "SİL";
            btnStudentDelete.UseVisualStyleBackColor = true;
            // 
            // btnStudentUpgrade
            // 
            btnStudentUpgrade.Location = new Point(192, 422);
            btnStudentUpgrade.Name = "btnStudentUpgrade";
            btnStudentUpgrade.Size = new Size(125, 44);
            btnStudentUpgrade.TabIndex = 1;
            btnStudentUpgrade.Text = "GÜNCELLE";
            btnStudentUpgrade.UseVisualStyleBackColor = true;
            // 
            // btnStudentSave
            // 
            btnStudentSave.Location = new Point(323, 422);
            btnStudentSave.Name = "btnStudentSave";
            btnStudentSave.Size = new Size(125, 44);
            btnStudentSave.TabIndex = 1;
            btnStudentSave.Text = "KAYDET";
            btnStudentSave.UseVisualStyleBackColor = true;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(61, 109);
            txtStudentName.Multiline = true;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(256, 49);
            txtStudentName.TabIndex = 2;
            // 
            // txtStudentSurname
            // 
            txtStudentSurname.Location = new Point(61, 222);
            txtStudentSurname.Multiline = true;
            txtStudentSurname.Name = "txtStudentSurname";
            txtStudentSurname.Size = new Size(256, 49);
            txtStudentSurname.TabIndex = 2;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(61, 332);
            txtStudentNumber.Multiline = true;
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(256, 49);
            txtStudentNumber.TabIndex = 2;
            // 
            // lstStudentList
            // 
            lstStudentList.FormattingEnabled = true;
            lstStudentList.Location = new Point(482, 102);
            lstStudentList.Name = "lstStudentList";
            lstStudentList.Size = new Size(481, 364);
            lstStudentList.TabIndex = 3;
            lstStudentList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Location = new Point(482, 72);
            label4.Name = "label4";
            label4.Size = new Size(209, 34);
            label4.TabIndex = 0;
            label4.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // StudentAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 602);
            Controls.Add(lstStudentList);
            Controls.Add(txtStudentSurname);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtStudentName);
            Controls.Add(btnStudentSave);
            Controls.Add(btnStudentUpgrade);
            Controls.Add(btnStudentDelete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "StudentAddForm";
            Text = "StudentAddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnStudentDelete;
        private Button btnStudentUpgrade;
        private Button btnStudentSave;
        private TextBox txtStudentName;
        private TextBox txtStudentSurname;
        private TextBox txtStudentNumber;
        private ListBox lstStudentList;
        private Label label4;
    }
}