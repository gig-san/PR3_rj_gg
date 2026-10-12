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
            label2 = new Label();
            label3 = new Label();
            brnNoviProj = new Button();
            textBox1 = new TextBox();
            cmbSattus = new ComboBox();
            cmbStanje = new ComboBox();
            btnNovaprij = new Button();
            brnPrint = new Button();
            dataGridView1 = new DataGridView();
            student = new DataGridViewTextBoxColumn();
            Projekt = new DataGridViewTextBoxColumn();
            RokZavrsetka = new DataGridViewTextBoxColumn();
            statusPrijave = new DataGridViewTextBoxColumn();
            prijavljen = new DataGridViewTextBoxColumn();
            promjena = new DataGridViewTextBoxColumn();
            StanjePrijave = new DataGridViewTextBoxColumn();
            btnArhiviraj = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime ili naziv prjekta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 9);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 0;
            label2.Text = "Status prijave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 9);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 0;
            label3.Text = "Stanje prijave";
            // 
            // brnNoviProj
            // 
            brnNoviProj.Location = new Point(802, 30);
            brnNoviProj.Name = "brnNoviProj";
            brnNoviProj.Size = new Size(137, 29);
            brnNoviProj.TabIndex = 1;
            brnNoviProj.Text = "Novi projekat";
            brnNoviProj.UseVisualStyleBackColor = true;
            brnNoviProj.Click += brnNoviProj_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(263, 27);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cmbSattus
            // 
            cmbSattus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSattus.FormattingEnabled = true;
            cmbSattus.Items.AddRange(new object[] { "Sve", "PODNESENA", "PRIHVACENA", "ODBIJENA", "ZAVRSENA" });
            cmbSattus.Location = new Point(290, 31);
            cmbSattus.Name = "cmbSattus";
            cmbSattus.Size = new Size(258, 28);
            cmbSattus.TabIndex = 3;
            cmbSattus.SelectionChangeCommitted += cmbSattus_SelectionChangeCommitted;
            // 
            // cmbStanje
            // 
            cmbStanje.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStanje.FormattingEnabled = true;
            cmbStanje.Items.AddRange(new object[] { "Sve", "Arhivirana", "Aktivna" });
            cmbStanje.Location = new Point(554, 31);
            cmbStanje.Name = "cmbStanje";
            cmbStanje.Size = new Size(199, 28);
            cmbStanje.TabIndex = 3;
            cmbStanje.SelectionChangeCommitted += cmbStanje_SelectionChangeCommitted;
            // 
            // btnNovaprij
            // 
            btnNovaprij.Location = new Point(945, 30);
            btnNovaprij.Name = "btnNovaprij";
            btnNovaprij.Size = new Size(123, 29);
            btnNovaprij.TabIndex = 1;
            btnNovaprij.Text = "Nova prijava";
            btnNovaprij.UseVisualStyleBackColor = true;
            btnNovaprij.Click += btnNovaprij_Click;
            // 
            // brnPrint
            // 
            brnPrint.Location = new Point(974, 413);
            brnPrint.Name = "brnPrint";
            brnPrint.Size = new Size(94, 29);
            brnPrint.TabIndex = 1;
            brnPrint.Text = "Print";
            brnPrint.UseVisualStyleBackColor = true;
            brnPrint.Click += brnPrint_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { student, Projekt, RokZavrsetka, statusPrijave, prijavljen, promjena, StanjePrijave, btnArhiviraj });
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1056, 342);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // student
            // 
            student.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            student.DataPropertyName = "Student";
            student.HeaderText = "Student";
            student.MinimumWidth = 6;
            student.Name = "student";
            student.ReadOnly = true;
            // 
            // Projekt
            // 
            Projekt.DataPropertyName = "Projekt";
            Projekt.HeaderText = "Projekt";
            Projekt.MinimumWidth = 6;
            Projekt.Name = "Projekt";
            Projekt.ReadOnly = true;
            Projekt.Width = 125;
            // 
            // RokZavrsetka
            // 
            RokZavrsetka.DataPropertyName = "RokZavrsetka";
            RokZavrsetka.HeaderText = "Rok zavrsetka";
            RokZavrsetka.MinimumWidth = 6;
            RokZavrsetka.Name = "RokZavrsetka";
            RokZavrsetka.ReadOnly = true;
            RokZavrsetka.Width = 125;
            // 
            // statusPrijave
            // 
            statusPrijave.DataPropertyName = "StatusPrijave";
            statusPrijave.HeaderText = "StatusPrijave";
            statusPrijave.MinimumWidth = 6;
            statusPrijave.Name = "statusPrijave";
            statusPrijave.ReadOnly = true;
            statusPrijave.Width = 125;
            // 
            // prijavljen
            // 
            prijavljen.DataPropertyName = "DatumPrijave";
            prijavljen.HeaderText = "Prijavljen";
            prijavljen.MinimumWidth = 6;
            prijavljen.Name = "prijavljen";
            prijavljen.ReadOnly = true;
            prijavljen.Width = 125;
            // 
            // promjena
            // 
            promjena.DataPropertyName = "DatumPromjene";
            promjena.HeaderText = "Promjena";
            promjena.MinimumWidth = 6;
            promjena.Name = "promjena";
            promjena.ReadOnly = true;
            promjena.Width = 125;
            // 
            // StanjePrijave
            // 
            StanjePrijave.DataPropertyName = "StanjePrijave";
            StanjePrijave.HeaderText = "Stanje prijave";
            StanjePrijave.MinimumWidth = 6;
            StanjePrijave.Name = "StanjePrijave";
            StanjePrijave.ReadOnly = true;
            StanjePrijave.Width = 125;
            // 
            // btnArhiviraj
            // 
            btnArhiviraj.HeaderText = "";
            btnArhiviraj.MinimumWidth = 6;
            btnArhiviraj.Name = "btnArhiviraj";
            btnArhiviraj.ReadOnly = true;
            btnArhiviraj.Text = "Arhiviraj";
            btnArhiviraj.UseColumnTextForButtonValue = true;
            btnArhiviraj.Width = 125;
            // 
            // frmPretragaIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1080, 454);
            Controls.Add(dataGridView1);
            Controls.Add(cmbStanje);
            Controls.Add(cmbSattus);
            Controls.Add(textBox1);
            Controls.Add(brnPrint);
            Controls.Add(btnNovaprij);
            Controls.Add(brnNoviProj);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB240311";
            Text = "pretraga prijava na projekte";
            Load += frmPretragaIB240311_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button brnNoviProj;
        private TextBox textBox1;
        private ComboBox cmbSattus;
        private ComboBox cmbStanje;
        private Button btnNovaprij;
        private Button brnPrint;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn student;
        private DataGridViewTextBoxColumn Projekt;
        private DataGridViewTextBoxColumn RokZavrsetka;
        private DataGridViewTextBoxColumn statusPrijave;
        private DataGridViewTextBoxColumn prijavljen;
        private DataGridViewTextBoxColumn promjena;
        private DataGridViewTextBoxColumn StanjePrijave;
        private DataGridViewButtonColumn btnArhiviraj;
    }
}