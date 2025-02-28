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
            label1.Location = new Point(53, 54);
            label1.Name = "label1";
            label1.Size = new Size(183, 26);
            label1.TabIndex = 0;
            label1.Text = "ÖĞRENCİ ADI";
            // 
            // label2
            // 
            label2.Location = new Point(53, 139);
            label2.Name = "label2";
            label2.Size = new Size(183, 26);
            label2.TabIndex = 0;
            label2.Text = "ÖĞRENCİ SOYADI";
            // 
            // label3
            // 
            label3.Location = new Point(53, 221);
            label3.Name = "label3";
            label3.Size = new Size(183, 26);
            label3.TabIndex = 0;
            label3.Text = "ÖĞRENCİ NUMARASI";
            // 
            // btnStudentDelete
            // 
            btnStudentDelete.Location = new Point(53, 316);
            btnStudentDelete.Margin = new Padding(3, 2, 3, 2);
            btnStudentDelete.Name = "btnStudentDelete";
            btnStudentDelete.Size = new Size(109, 33);
            btnStudentDelete.TabIndex = 1;
            btnStudentDelete.Text = "SİL";
            btnStudentDelete.UseVisualStyleBackColor = true;
            btnStudentDelete.Click += btnStudentDelete_Click;
            // 
            // btnStudentSave
            // 
            btnStudentSave.Location = new Point(168, 316);
            btnStudentSave.Margin = new Padding(3, 2, 3, 2);
            btnStudentSave.Name = "btnStudentSave";
            btnStudentSave.Size = new Size(109, 33);
            btnStudentSave.TabIndex = 1;
            btnStudentSave.Text = "KAYDET";
            btnStudentSave.UseVisualStyleBackColor = true;
            btnStudentSave.Click += btnStudentSave_Click;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(53, 82);
            txtStudentName.Margin = new Padding(3, 2, 3, 2);
            txtStudentName.Multiline = true;
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(224, 38);
            txtStudentName.TabIndex = 2;
            txtStudentName.TextChanged += txtStudentName_TextChanged;
            // 
            // txtStudentSurname
            // 
            txtStudentSurname.Location = new Point(53, 166);
            txtStudentSurname.Margin = new Padding(3, 2, 3, 2);
            txtStudentSurname.Multiline = true;
            txtStudentSurname.Name = "txtStudentSurname";
            txtStudentSurname.Size = new Size(224, 38);
            txtStudentSurname.TabIndex = 2;
            // 
            // txtStudentNumber
            // 
            txtStudentNumber.Location = new Point(53, 249);
            txtStudentNumber.Margin = new Padding(3, 2, 3, 2);
            txtStudentNumber.Multiline = true;
            txtStudentNumber.Name = "txtStudentNumber";
            txtStudentNumber.Size = new Size(224, 38);
            txtStudentNumber.TabIndex = 2;
            // 
            // lstStudentList
            // 
            lstStudentList.FormattingEnabled = true;
            lstStudentList.ItemHeight = 15;
            lstStudentList.Location = new Point(296, 82);
            lstStudentList.Margin = new Padding(3, 2, 3, 2);
            lstStudentList.Name = "lstStudentList";
            lstStudentList.Size = new Size(421, 274);
            lstStudentList.TabIndex = 3;
            lstStudentList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Location = new Point(296, 54);
            label4.Name = "label4";
            label4.Size = new Size(183, 26);
            label4.TabIndex = 0;
            label4.Text = "ÖĞRENCİ LİSTESİ";
            // 
            // StudentAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 382);
            Controls.Add(lstStudentList);
            Controls.Add(txtStudentSurname);
            Controls.Add(txtStudentNumber);
            Controls.Add(txtStudentName);
            Controls.Add(btnStudentSave);
            Controls.Add(btnStudentDelete);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "StudentAddForm";
            Text = "StudentAddForm";
            Load += StudentAddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnStudentDelete;
        private Button btnStudentSave;
        private TextBox txtStudentName;
        private TextBox txtStudentSurname;
        private TextBox txtStudentNumber;
        private ListBox lstStudentList;
        private Label label4;
    }
}