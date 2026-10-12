namespace Studentska.WinApp.IspitIB240311
{
    partial class frmKnjigaAddEditIB240311
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
            txtNaziv = new TextBox();
            label1 = new Label();
            txtAutor = new TextBox();
            label2 = new Label();
            txtBr = new TextBox();
            label3 = new Label();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(23, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 207);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(232, 62);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(294, 27);
            txtNaziv.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(232, 27);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 2;
            label1.Text = "Naziv knjige:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(232, 127);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(294, 27);
            txtAutor.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 92);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 2;
            label2.Text = "Autori:";
            // 
            // txtBr
            // 
            txtBr.Location = new Point(232, 204);
            txtBr.Name = "txtBr";
            txtBr.Size = new Size(294, 27);
            txtBr.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(232, 169);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 2;
            label3.Text = "Broj primjeraka:";
            // 
            // button1
            // 
            button1.Location = new Point(432, 251);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Scuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmKnjigaAddEditIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 303);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtBr);
            Controls.Add(label2);
            Controls.Add(txtAutor);
            Controls.Add(label1);
            Controls.Add(txtNaziv);
            Controls.Add(pictureBox1);
            Name = "frmKnjigaAddEditIB240311";
            Text = "Podaci o knjizi";
            Load += frmKnjigaAddEditIB240311_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txtNaziv;
        private Label label1;
        private TextBox txtAutor;
        private Label label2;
        private TextBox txtBr;
        private Label label3;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}