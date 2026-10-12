namespace Studentska.WinApp.IspitIB240311
{
    partial class frmPraksaAddEditIB240311
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
            cmbStudent = new ComboBox();
            cmbKompanije = new ComboBox();
            cmbStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnSacuvaj = new Button();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            btnGen = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 0;
            label2.Text = "Datum prijave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(389, 22);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 0;
            label3.Text = "Kompanije:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(389, 86);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 0;
            label4.Text = "Status:";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(12, 45);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(356, 28);
            cmbStudent.TabIndex = 1;
            // 
            // cmbKompanije
            // 
            cmbKompanije.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKompanije.FormattingEnabled = true;
            cmbKompanije.Location = new Point(389, 45);
            cmbKompanije.Name = "cmbKompanije";
            cmbKompanije.Size = new Size(356, 28);
            cmbKompanije.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(389, 109);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(356, 28);
            cmbStatus.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 110);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(356, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(651, 161);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(94, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(btnGen);
            groupBox1.Location = new Point(12, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(733, 355);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(15, 61);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(712, 275);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // btnGen
            // 
            btnGen.Location = new Point(15, 26);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(712, 29);
            btnGen.TabIndex = 0;
            btnGen.Text = "Generisi zahtjeve";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // frmPraksaAddEditIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 572);
            Controls.Add(groupBox1);
            Controls.Add(btnSacuvaj);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbStatus);
            Controls.Add(cmbKompanije);
            Controls.Add(cmbStudent);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmPraksaAddEditIB240311";
            Text = "Praksa";
            Load += frmPraksaAddEditIB240311_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbStudent;
        private ComboBox cmbKompanije;
        private ComboBox cmbStatus;
        private DateTimePicker dateTimePicker1;
        private Button btnSacuvaj;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private Button btnGen;
    }
}