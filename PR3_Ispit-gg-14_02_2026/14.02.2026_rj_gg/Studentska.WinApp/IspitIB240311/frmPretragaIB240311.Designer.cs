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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            btnNovakomp = new Button();
            btnNovapraks = new Button();
            btnPrint = new Button();
            dataGridView1 = new DataGridView();
            student = new DataGridViewTextBoxColumn();
            kompanija = new DataGridViewTextBoxColumn();
            Grad = new DataGridViewTextBoxColumn();
            StatusZahjetva = new DataGridViewTextBoxColumn();
            DatumPromjene = new DataGridViewTextBoxColumn();
            btnObrisi = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 0;
            label1.Text = "Ime i prezime ili naziv Kompanije";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(281, 9);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 0;
            label2.Text = "Status zahtjeva";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 32);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "softw";
            textBox1.Size = new Size(261, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PODNESENA", "PRIHVACENA", "ODBIJENA", "REALIZOVANA" });
            comboBox1.Location = new Point(281, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 28);
            comboBox1.TabIndex = 2;
            comboBox1.SelectionChangeCommitted += comboBox1_SelectionChangeCommitted;
            // 
            // btnNovakomp
            // 
            btnNovakomp.Location = new Point(636, 30);
            btnNovakomp.Name = "btnNovakomp";
            btnNovakomp.Size = new Size(147, 29);
            btnNovakomp.TabIndex = 3;
            btnNovakomp.Text = "Nova kompanija";
            btnNovakomp.UseVisualStyleBackColor = true;
            btnNovakomp.Click += btnNovakomp_Click;
            // 
            // btnNovapraks
            // 
            btnNovapraks.Location = new Point(789, 30);
            btnNovapraks.Name = "btnNovapraks";
            btnNovapraks.Size = new Size(148, 29);
            btnNovapraks.TabIndex = 3;
            btnNovapraks.Text = "Nova praksa";
            btnNovapraks.UseVisualStyleBackColor = true;
            btnNovapraks.Click += btnNovapraks_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(812, 377);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(125, 29);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { student, kompanija, Grad, StatusZahjetva, DatumPromjene, btnObrisi });
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(925, 306);
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
            // kompanija
            // 
            kompanija.DataPropertyName = "Kompanija";
            kompanija.HeaderText = "Kompanija";
            kompanija.MinimumWidth = 6;
            kompanija.Name = "kompanija";
            kompanija.ReadOnly = true;
            kompanija.Width = 125;
            // 
            // Grad
            // 
            Grad.DataPropertyName = "Grad";
            Grad.HeaderText = "Grad";
            Grad.MinimumWidth = 6;
            Grad.Name = "Grad";
            Grad.ReadOnly = true;
            Grad.Width = 125;
            // 
            // StatusZahjetva
            // 
            StatusZahjetva.DataPropertyName = "Status";
            StatusZahjetva.HeaderText = "Status zahtjeva";
            StatusZahjetva.MinimumWidth = 6;
            StatusZahjetva.Name = "StatusZahjetva";
            StatusZahjetva.ReadOnly = true;
            StatusZahjetva.Width = 125;
            // 
            // DatumPromjene
            // 
            DatumPromjene.DataPropertyName = "DatumPromjene";
            DatumPromjene.HeaderText = "Datum promjene";
            DatumPromjene.MinimumWidth = 6;
            DatumPromjene.Name = "DatumPromjene";
            DatumPromjene.ReadOnly = true;
            DatumPromjene.Width = 125;
            // 
            // btnObrisi
            // 
            btnObrisi.HeaderText = "";
            btnObrisi.MinimumWidth = 6;
            btnObrisi.Name = "btnObrisi";
            btnObrisi.ReadOnly = true;
            btnObrisi.Text = "Obrisi";
            btnObrisi.UseColumnTextForButtonValue = true;
            btnObrisi.Width = 125;
            // 
            // frmPretragaIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 418);
            Controls.Add(dataGridView1);
            Controls.Add(btnPrint);
            Controls.Add(btnNovapraks);
            Controls.Add(btnNovakomp);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmPretragaIB240311";
            Text = "Pretraga";
            Load += frmPretragaIB240311_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Button btnNovakomp;
        private Button btnNovapraks;
        private Button btnPrint;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn student;
        private DataGridViewTextBoxColumn kompanija;
        private DataGridViewTextBoxColumn Grad;
        private DataGridViewTextBoxColumn StatusZahjetva;
        private DataGridViewTextBoxColumn DatumPromjene;
        private DataGridViewButtonColumn btnObrisi;
    }
}