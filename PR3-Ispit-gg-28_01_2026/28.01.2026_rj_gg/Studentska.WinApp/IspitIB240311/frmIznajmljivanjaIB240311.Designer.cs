namespace Studentska.WinApp.IspitIB240311
{
    partial class frmIznajmljivanjaIB240311
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
            Knjiga = new Label();
            cmbStudent = new ComboBox();
            cmbKnjiga = new ComboBox();
            btnIznajmi = new Button();
            dataGridView1 = new DataGridView();
            studentDgv = new DataGridViewTextBoxColumn();
            Knjigadgv = new DataGridViewTextBoxColumn();
            DatumIznajmljivanjadgv = new DataGridViewTextBoxColumn();
            VracenaDgv = new DataGridViewCheckBoxColumn();
            btnGen = new Button();
            btnPotvrda = new Button();
            groupBox1 = new GroupBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            // Knjiga
            // 
            Knjiga.AutoSize = true;
            Knjiga.Location = new Point(345, 9);
            Knjiga.Name = "Knjiga";
            Knjiga.Size = new Size(50, 20);
            Knjiga.TabIndex = 0;
            Knjiga.Text = "label1";
            // 
            // cmbStudent
            // 
            cmbStudent.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStudent.FormattingEnabled = true;
            cmbStudent.Location = new Point(11, 35);
            cmbStudent.Name = "cmbStudent";
            cmbStudent.Size = new Size(299, 28);
            cmbStudent.TabIndex = 1;
            cmbStudent.SelectionChangeCommitted += cmbStudent_SelectionChangeCommitted;
            // 
            // cmbKnjiga
            // 
            cmbKnjiga.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKnjiga.FormattingEnabled = true;
            cmbKnjiga.Location = new Point(345, 35);
            cmbKnjiga.Name = "cmbKnjiga";
            cmbKnjiga.Size = new Size(283, 28);
            cmbKnjiga.TabIndex = 1;
            cmbKnjiga.SelectionChangeCommitted += cmbKnjiga_SelectionChangeCommitted;
            // 
            // btnIznajmi
            // 
            btnIznajmi.Location = new Point(643, 34);
            btnIznajmi.Name = "btnIznajmi";
            btnIznajmi.Size = new Size(133, 29);
            btnIznajmi.TabIndex = 2;
            btnIznajmi.Text = "Iznajmi";
            btnIznajmi.UseVisualStyleBackColor = true;
            btnIznajmi.Click += btnIznajmi_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { studentDgv, Knjigadgv, DatumIznajmljivanjadgv, VracenaDgv });
            dataGridView1.Location = new Point(10, 78);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(766, 236);
            dataGridView1.TabIndex = 3;
            // 
            // studentDgv
            // 
            studentDgv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentDgv.DataPropertyName = "Student";
            studentDgv.HeaderText = "(Index) Ime i prezime";
            studentDgv.MinimumWidth = 6;
            studentDgv.Name = "studentDgv";
            studentDgv.ReadOnly = true;
            // 
            // Knjigadgv
            // 
            Knjigadgv.DataPropertyName = "Knjiga";
            Knjigadgv.HeaderText = "Knjiga";
            Knjigadgv.MinimumWidth = 6;
            Knjigadgv.Name = "Knjigadgv";
            Knjigadgv.ReadOnly = true;
            Knjigadgv.Width = 125;
            // 
            // DatumIznajmljivanjadgv
            // 
            DatumIznajmljivanjadgv.DataPropertyName = "DatumIznajmljivanja";
            DatumIznajmljivanjadgv.HeaderText = "Datum iznajmljivanja";
            DatumIznajmljivanjadgv.MinimumWidth = 6;
            DatumIznajmljivanjadgv.Name = "DatumIznajmljivanjadgv";
            DatumIznajmljivanjadgv.ReadOnly = true;
            DatumIznajmljivanjadgv.Width = 125;
            // 
            // VracenaDgv
            // 
            VracenaDgv.DataPropertyName = "Vracena";
            VracenaDgv.HeaderText = "Vracena";
            VracenaDgv.MinimumWidth = 6;
            VracenaDgv.Name = "VracenaDgv";
            VracenaDgv.ReadOnly = true;
            VracenaDgv.Width = 125;
            // 
            // btnGen
            // 
            btnGen.Location = new Point(10, 320);
            btnGen.Name = "btnGen";
            btnGen.Size = new Size(196, 29);
            btnGen.TabIndex = 4;
            btnGen.Text = "Generisi iznajmljivanja";
            btnGen.UseVisualStyleBackColor = true;
            btnGen.Click += btnGen_Click;
            // 
            // btnPotvrda
            // 
            btnPotvrda.Location = new Point(643, 320);
            btnPotvrda.Name = "btnPotvrda";
            btnPotvrda.Size = new Size(133, 29);
            btnPotvrda.TabIndex = 4;
            btnPotvrda.Text = "Potvrda";
            btnPotvrda.UseVisualStyleBackColor = true;
            btnPotvrda.Click += btnPotvrda_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Location = new Point(10, 364);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(766, 293);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator info";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(16, 26);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(732, 261);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // frmIznajmljivanjaIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(791, 669);
            Controls.Add(groupBox1);
            Controls.Add(btnPotvrda);
            Controls.Add(btnGen);
            Controls.Add(dataGridView1);
            Controls.Add(btnIznajmi);
            Controls.Add(cmbKnjiga);
            Controls.Add(cmbStudent);
            Controls.Add(Knjiga);
            Controls.Add(label1);
            Name = "frmIznajmljivanjaIB240311";
            Text = "Iznajmljivanje knjga";
            Load += frmIznajmljivanjaIB240311_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Knjiga;
        private ComboBox cmbStudent;
        private ComboBox cmbKnjiga;
        private Button btnIznajmi;
        private DataGridView dataGridView1;
        private Button btnGen;
        private Button btnPotvrda;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private DataGridViewTextBoxColumn studentDgv;
        private DataGridViewTextBoxColumn Knjigadgv;
        private DataGridViewTextBoxColumn DatumIznajmljivanjadgv;
        private DataGridViewCheckBoxColumn VracenaDgv;
    }
}