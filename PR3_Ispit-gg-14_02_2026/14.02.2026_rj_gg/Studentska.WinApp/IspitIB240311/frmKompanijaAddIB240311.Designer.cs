namespace Studentska.WinApp.IspitIB240311
{
    partial class frmKompanijaAddIB240311
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
            lable = new Label();
            label5 = new Label();
            txtNaziv = new TextBox();
            txtAdresa = new TextBox();
            txtbr = new TextBox();
            txtUrl = new TextBox();
            cmbGrad = new ComboBox();
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
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 211);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 12);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 1;
            label1.Text = "Naziv:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 81);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Adresa:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(220, 154);
            label3.Name = "label3";
            label3.Size = new Size(182, 20);
            label3.TabIndex = 1;
            label3.Text = "Maximalan broj studenata";
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(470, 12);
            lable.Name = "lable";
            lable.Size = new Size(44, 20);
            lable.TabIndex = 1;
            lable.Text = "Grad:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(470, 81);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 1;
            label5.Text = "URL";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(220, 35);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(238, 27);
            txtNaziv.TabIndex = 2;
            // 
            // txtAdresa
            // 
            txtAdresa.Location = new Point(220, 104);
            txtAdresa.Name = "txtAdresa";
            txtAdresa.Size = new Size(238, 27);
            txtAdresa.TabIndex = 2;
            // 
            // txtbr
            // 
            txtbr.Location = new Point(220, 177);
            txtbr.Name = "txtbr";
            txtbr.Size = new Size(238, 27);
            txtbr.TabIndex = 2;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(470, 104);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(238, 27);
            txtUrl.TabIndex = 2;
            // 
            // cmbGrad
            // 
            cmbGrad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGrad.FormattingEnabled = true;
            cmbGrad.Location = new Point(470, 34);
            cmbGrad.Name = "cmbGrad";
            cmbGrad.Size = new Size(238, 28);
            cmbGrad.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(483, 177);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Aktivna";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(592, 233);
            button1.Name = "button1";
            button1.Size = new Size(116, 29);
            button1.TabIndex = 5;
            button1.Text = "Sacuvaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmKompanijaAddIB240311
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(737, 274);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(cmbGrad);
            Controls.Add(txtbr);
            Controls.Add(txtUrl);
            Controls.Add(txtAdresa);
            Controls.Add(txtNaziv);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(lable);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmKompanijaAddIB240311";
            Text = "Kompanija";
            Load += frmKompanijaAddIB240311_Load;
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
        private Label lable;
        private Label label5;
        private TextBox txtNaziv;
        private TextBox txtAdresa;
        private TextBox txtbr;
        private TextBox txtUrl;
        private ComboBox cmbGrad;
        private CheckBox checkBox1;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}