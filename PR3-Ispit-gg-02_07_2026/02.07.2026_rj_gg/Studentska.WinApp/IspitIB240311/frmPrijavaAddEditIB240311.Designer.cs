namespace Studentska.WinApp.IspitIB240311
{
    partial class frmPrijavaAddEditIB240311
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
            cmbProjekat = new ComboBox();
            cmbStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            btnGen = new Button();
            btnSacuvaj = new Button();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Student:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(106, 20);
            label2.TabIndex = 0;
            label2.Text = "Datum prijave:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(403, 9);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 0;
            label3.Text = "Projekat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(403, 80);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 0;
            label4.Text = "Status prijave:";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(12, 32);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(353, 28);
            cmbStudent.TabIndex = 1;
            // 
            // cmbProjekat
            // 
            cmbProjekat.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbProjekat.FormattingEnabled = true;
            cmbProjekat.Location = new Point(403, 32);
            cmbProjekat.Name = "cmbProjekat";
            cmbProjekat.Size = new Size(353, 28);
            cmbProjekat.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(403, 103);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(353, 28);
            cmbStatus.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 101);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(353, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // btnGen
            // 
            btnGen.Location = new Point(12, 134);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(136, 29);
            btnGen.TabIndex = 3;
            btnGen.Text = "Generisi prijave";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // btnSacuvaj
            // 
            btnSacuvaj.Location = new Point(620, 137);
            btnSacuvaj.Name = "btnSacuvaj";
            btnSacuvaj.Size = new Size(136, 29);
            btnSacuvaj.TabIndex = 3;
            btnSacuvaj.Text = "Sacuvaj";
            btnSacuvaj.UseVisualStyleBackColor = true;
            btnSacuvaj.Click += btnSacuvaj_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(12, 189);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(751, 337);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(11, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(733, 305);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // frmPrijavaAddEditIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 538);
            Controls.Add(groupBox1);
            Controls.Add(btnSacuvaj);
            Controls.Add(btnGen);
            Controls.Add(dateTimePicker1);
            Controls.Add(cmbStatus);
            Controls.Add(cmbProjekat);
            Controls.Add(cmbStudent);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "frmPrijavaAddEditIB240311";
            Text = "frmPrijavaAddEditIB240311";
            Load += frmPrijavaAddEditIB240311_Load;
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
        private ComboBox cmbProjekat;
        private ComboBox cmbStatus;
        private DateTimePicker dateTimePicker1;
        private Button btnGen;
        private Button btnSacuvaj;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
    }
}