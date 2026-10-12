using DocumentFormat.OpenXml.Wordprocessing;
using Studentska.Data.Modeli.IspitIB240311;
using Studentska.Servis.Servisi.IspitIB240311;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentska.WinApp.IspitIB240311
{
    public partial class frmKnjigaAddEditIB240311 : Form
    {
        private KnjigeIB240311? podaci;

        public frmKnjigaAddEditIB240311()
        {
            InitializeComponent();
        }

        public frmKnjigaAddEditIB240311(KnjigeIB240311? podaci)
        {
            InitializeComponent();

            this.podaci = podaci;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using var file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(validaciaj1() && validacija2())
            {
              

                if (podaci!=null)
                {
                    KnjigeIB240311Servis servis = new();
                    podaci.Naziv = txtNaziv.Text;
                    podaci.Autor=txtAutor.Text;
                    podaci.BrojPrimjeraka = int.Parse(txtBr.Text);
                    podaci.Slika = Helpers.ImageHelper.ImageToByte(pictureBox1.Image);
                    servis.Update(podaci);
                    MessageBox.Show("uspjenso ste editovali knjigu");
                    Close();
                }
                else
                {
                    KnjigeIB240311Servis servis = new();
                    var nova = new KnjigeIB240311()
                    {
                        Naziv = txtNaziv.Text,
                        Autor = txtAutor.Text,
                        BrojPrimjeraka = int.Parse(txtBr.Text),
                        Slika = Helpers.ImageHelper.ImageToByte(pictureBox1.Image)
                    };
                    servis.Add(nova);
                    MessageBox.Show("uspjesno ste dodali knjigu");
                    Close();

                }
            }
        }

        private void frmKnjigaAddEditIB240311_Load(object sender, EventArgs e)
        {
            if(podaci!=null)
            {
                txtNaziv.Text = podaci.Naziv;
                txtAutor.Text = podaci.Autor;
                txtBr.Text = podaci.BrojPrimjeraka.ToString();
                pictureBox1.Image = Helpers.ImageHelper.ByteToImage(podaci.Slika);
            }
        }

        public bool validaciaj1()
        {
            return Helpers.Validator.ValidanUnos(txtNaziv, errorProvider1, "obavezan unos") &&
                Helpers.Validator.ValidanUnos(txtAutor, errorProvider1, "obavezan unos") &&
                Helpers.Validator.ValidanUnos(txtBr, errorProvider1, "obavezan unos") &&
                Helpers.Validator.ValidanUnos(pictureBox1, errorProvider1, "obavezan unos");

        }

        public bool validacija2()
        {
            KnjigeIB240311Servis servis = new();
            var sveKnjige = servis.GetAll();

            if(sveKnjige.Any(x=> x.Naziv.ToLower()==txtNaziv.Text.ToLower() && x.Autor.ToLower()==txtAutor.Text.ToLower() && (podaci==null || podaci.Id!=x.Id)))
            {
                MessageBox.Show("vec ppostoji knjiga s atim nazivom");
                return false;
            }
            if (int.Parse(txtBr.Text) <= 0)
            {

                MessageBox.Show("ne moze negativan broj primjeraka");
                return false;
            }

            return true;
                    
        }
    }
}
