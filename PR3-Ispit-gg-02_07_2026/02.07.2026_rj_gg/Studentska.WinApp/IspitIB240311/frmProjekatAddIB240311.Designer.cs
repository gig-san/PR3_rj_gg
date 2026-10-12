namespace Studentska.WinApp.IspitIB240311
{
    partial class frmProjekatAddIB240311
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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtNaziv = new TextBox();
            txtNapomena = new TextBox();
            label5 = new Label();
            txtBr = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Logo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(165, 9);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Naziv:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 71);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 1;
            label3.Text = "napoemna:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(165, 178);
            label4.Name = "label4";
            label4.Size = new Size(99, 20);
            label4.TabIndex = 1;
            label4.Text = "Rok zavrsetka";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 201);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(165, 41);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(472, 27);
            txtNaziv.TabIndex = 3;
            // 
            // txtNapomena
            // 
            txtNapomena.Location = new Point(165, 94);
            txtNapomena.Multiline = true;
            txtNapomena.Name = "txtNapomena";
            txtNapomena.Size = new Size(472, 81);
            txtNapomena.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 178);
            label5.Name = "label5";
            label5.Size = new Size(124, 20);
            label5.TabIndex = 1;
            label5.Text = "Max br studenata";
            // 
            // txtBr
            // 
            txtBr.Location = new Point(384, 201);
            txtBr.Name = "txtBr";
            txtBr.Size = new Size(135, 27);
            txtBr.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(536, 201);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Aktivan";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(489, 234);
            button1.Name = "button1";
            button1.Size = new Size(148, 29);
            button1.TabIndex = 5;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmProjekatAddIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 287);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(txtNapomena);
            Controls.Add(txtBr);
            Controls.Add(txtNaziv);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmProjekatAddIB240311";
            Text = "frmProjekatAddIB240311";
            Load += frmProjekatAddIB240311_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private TextBox txtNaziv;
        private TextBox txtNapomena;
        private Label label5;
        private TextBox txtBr;
        private CheckBox checkBox1;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}