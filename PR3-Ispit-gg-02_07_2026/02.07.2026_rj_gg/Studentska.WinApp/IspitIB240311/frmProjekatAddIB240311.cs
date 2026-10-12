using DocumentFormat.OpenXml.Spreadsheet;
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
    public partial class frmProjekatAddIB240311 : Form
    {
        public frmProjekatAddIB240311()
        {
            InitializeComponent();
        }

        private void frmProjekatAddIB240311_Load(object sender, EventArgs e)
        {
            this.Text = "Projekat";
        }

        //        Prilikom spašavanja podataka osigurati validaciju na način da su sva polja obavezna, osim polja
        //Napomena.
        //Onemogućiti dodavanje projekata sa istim nazivom,
        //rok završetka projekta ne može biti manji od trenutnog datuma,
        //a maksimalan broj studenata mora biti veći od 0.

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using var file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(file.FileName);
            }
        }

        private bool validacija()
        {
            return Helpers.Validator.ValidanUnos(txtNaziv, errorProvider1, "obavezan unos") &&
             Helpers.Validator.ValidanUnos(txtBr, errorProvider1, "obavezan unos") &&
            Helpers.Validator.ValidanUnos(pictureBox1, errorProvider1, "obavezan unos");


        }

        private bool validaciajh1()
        {
            var naziv = txtNaziv.Text.ToLower();
            var br = txtBr.Text;

            ProjektiIB240311Servis servis = new();
            var sve = servis.GetAll();
            if(sve.Any(x=> x.Naziv.ToLower()==naziv))
            {
                MessageBox.Show("vec postoji projekat sa tim nazivom");
                return false;
            }
            if(dateTimePicker1.Value<=DateTime.Now)
            {
                MessageBox.Show("rok završetka projekta ne može biti manji od trenutnog datuma");
                return false;
            }
            if (!int.TryParse(br, out int n))
            {
                MessageBox.Show("striktno unijeti broj za 'max br studenata'");
                return false;
            }
            if(int.Parse(br)<=0)
            {
                MessageBox.Show("maksimalan broj studenata mora biti veći od 0.");
                return false;
            }
            return true;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(validacija() && validaciajh1())
            {
                ProjektiIB240311Servis servis = new();
                var nova = new ProjektiIB240311()
                {
                    Naziv = txtNaziv.Text,
                    Logo = Helpers.ImageHelper.ImageToByte(pictureBox1.Image),
                    RokZavrsetka = dateTimePicker1.Value,
                    MaxBrStudenata = int.Parse(txtBr.Text),
                    Aktivan=checkBox1.Checked,
                    Napomena=txtNapomena.Text

                };
                servis.Add(nova);
                MessageBox.Show("uspjesno ste dodali novi projekat!");
                Close();
            }
        }
    }
}
