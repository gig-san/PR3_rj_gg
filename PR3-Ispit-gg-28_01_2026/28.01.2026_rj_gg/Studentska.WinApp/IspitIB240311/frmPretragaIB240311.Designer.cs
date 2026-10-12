namespace Studentska.WinApp.IspitIB240311
{
    partial class frmPretragaIB240311
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
            textBox1 = new TextBox();
            checkBox1 = new CheckBox();
            btnDodajknjigu = new Button();
            btnIznajmljivanje = new Button();
            dataGridView1 = new DataGridView();
            StudentDgv = new DataGridViewTextBoxColumn();
            knjigadgv = new DataGridViewTextBoxColumn();
            DatumiznajmljivanjaDgv = new DataGridViewTextBoxColumn();
            DatumVracanjaDgv = new DataGridViewTextBoxColumn();
            VracenaDgv = new DataGridViewCheckBoxColumn();
            btnPovrat = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime ili naziv knjige";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(16, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(397, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(83, 24);
            checkBox1.TabIndex = 2;
            checkBox1.Text = "Vracena";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnDodajknjigu
            // 
            btnDodajknjigu.Location = new Point(643, 32);
            btnDodajknjigu.Name = "btnDodajknjigu";
            btnDodajknjigu.Size = new Size(126, 29);
            btnDodajknjigu.TabIndex = 3;
            btnDodajknjigu.Text = "Dodaj knjigu";
            btnDodajknjigu.UseVisualStyleBackColor = true;
            btnDodajknjigu.Click += btnDodajknjigu_Click;
            // 
            // btnIznajmljivanje
            // 
            btnIznajmljivanje.Location = new Point(775, 33);
            btnIznajmljivanje.Name = "btnIznajmljivanje";
            btnIznajmljivanje.Size = new Size(133, 29);
            btnIznajmljivanje.TabIndex = 3;
            btnIznajmljivanje.Text = "Iznajmljivanje";
            btnIznajmljivanje.UseVisualStyleBackColor = true;
            btnIznajmljivanje.Click += btnIznajmljivanje_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { StudentDgv, knjigadgv, DatumiznajmljivanjaDgv, DatumVracanjaDgv, VracenaDgv, btnPovrat });
            dataGridView1.Location = new Point(16, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(892, 424);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // StudentDgv
            // 
            StudentDgv.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            StudentDgv.DataPropertyName = "Student";
            StudentDgv.HeaderText = "(Indeks) Ime i prezime";
            StudentDgv.MinimumWidth = 6;
            StudentDgv.Name = "StudentDgv";
            StudentDgv.ReadOnly = true;
            // 
            // knjigadgv
            // 
            knjigadgv.DataPropertyName = "Knjiga";
            knjigadgv.HeaderText = "Knjiga";
            knjigadgv.MinimumWidth = 6;
            knjigadgv.Name = "knjigadgv";
            knjigadgv.ReadOnly = true;
            knjigadgv.Width = 125;
            // 
            // DatumiznajmljivanjaDgv
            // 
            DatumiznajmljivanjaDgv.DataPropertyName = "DatumIznajmljivanja";
            DatumiznajmljivanjaDgv.HeaderText = "Datum iznajmljivanja";
            DatumiznajmljivanjaDgv.MinimumWidth = 6;
            DatumiznajmljivanjaDgv.Name = "DatumiznajmljivanjaDgv";
            DatumiznajmljivanjaDgv.ReadOnly = true;
            DatumiznajmljivanjaDgv.Width = 125;
            // 
            // DatumVracanjaDgv
            // 
            DatumVracanjaDgv.DataPropertyName = "DatumVracanja";
            DatumVracanjaDgv.HeaderText = "Datum vracanja";
            DatumVracanjaDgv.MinimumWidth = 6;
            DatumVracanjaDgv.Name = "DatumVracanjaDgv";
            DatumVracanjaDgv.ReadOnly = true;
            DatumVracanjaDgv.Width = 125;
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
            // btnPovrat
            // 
            btnPovrat.HeaderText = "";
            btnPovrat.MinimumWidth = 6;
            btnPovrat.Name = "btnPovrat";
            btnPovrat.ReadOnly = true;
            btnPovrat.Text = "Vrati";
            btnPovrat.UseColumnTextForButtonValue = true;
            btnPovrat.Width = 125;
            // 
            // frmPretragaIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 504);
            Controls.Add(dataGridView1);
            Controls.Add(btnIznajmljivanje);
            Controls.Add(btnDodajknjigu);
            Controls.Add(checkBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frmPretragaIB240311";
            Text = "frmPretragaIB240311";
            Load += frmPretragaIB240311_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private CheckBox checkBox1;
        private Button btnDodajknjigu;
        private Button btnIznajmljivanje;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn StudentDgv;
        private DataGridViewTextBoxColumn knjigadgv;
        private DataGridViewTextBoxColumn DatumiznajmljivanjaDgv;
        private DataGridViewTextBoxColumn DatumVracanjaDgv;
        private DataGridViewCheckBoxColumn VracenaDgv;
        private DataGridViewButtonColumn btnPovrat;
    }
}