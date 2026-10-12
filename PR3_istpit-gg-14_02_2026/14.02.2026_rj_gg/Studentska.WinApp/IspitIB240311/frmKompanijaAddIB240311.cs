using Studentska.Data.Entiteti;
using Studentska.Data.Modeli.IspitIB240311;
using Studentska.Servis.Servisi;
using Studentska.Servis.Servisi.IspitIB240311;
using Studentska.WinApp.Helpers;
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
    public partial class frmKompanijaAddIB240311 : Form
    {
        public frmKompanijaAddIB240311()
        {
            InitializeComponent();
        }

        //Prilikom spašavanja podataka osigurati validaciju(sva polja su obavezna),
        //te onemogućiti da se dodaju kompanije sa istim imenom i gradom(npr.onemogućiti višestruko dodavanje FITDev
        //kompanije u Mostaru).
        //Napraviti osnovnu validaciju url-a kompanije(ignorišemo oznaku
        //protokola) na način da mora početi sa www,
        //posjedovati dvije tačke, a da naziv i domena(npr.
        //com, ba, i dr.) moraju imati najmanje 2 slova(npr.validan url bi bio www.xx.xx).
        //Maksimalan broj
        //studenata ne može biti negativan.U slučaju bilo kakvih odstupanja korisnika obavijestiti
        //adekvatnom porukom.
        private void frmKompanijaAddIB240311_Load(object sender, EventArgs e)
        {
            GradServis servisG = new();
            var svigradovi = servisG.GetAll();
            cmbGrad.UcitajPodatke(svigradovi, "Id", "Naziv");
            cmbGrad.SelectedIndex = 0;

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
            if(validacija1() && validacija2())
            {
                KompanijeIB240311Servis servis = new();
                var grad = cmbGrad.SelectedItem as Grad;

                var nova = new KompanijeIB240311()
                {
                    Naziv = txtNaziv.Text,
                    GradId = grad.Id,
                    Adresa = txtAdresa.Text,
                    Url = txtUrl.Text,
                    Slika = Helpers.ImageHelper.ImageToByte(pictureBox1.Image),
                    MaxBrojStudenata=int.Parse(txtbr.Text),
                    Aktivna=checkBox1.Checked

                };
                servis.Add(nova);
                MessageBox.Show("uspjesnos te dodali novu kompaniju");
                Close();
            }
        }
        //te onemogućiti da se dodaju kompanije sa istim imenom i gradom(npr.onemogućiti višestruko dodavanje FITDev
        //kompanije u Mostaru).
        //Napraviti osnovnu validaciju url-a kompanije(ignorišemo oznaku
        //protokola) na način da mora početi sa www,
        //posjedovati dvije tačke, a da naziv i domena(npr.
        //com, ba, i dr.) moraju imati najmanje 2 slova(npr.validan url bi bio www.xx.xx).
        //Maksimalan broj
        //studenata ne može biti negativan.U slučaju bilo kakvih odstupanja korisnika obavijestiti
        //adekvatnom porukom.
        private bool validacija2()
        {
            KompanijeIB240311Servis servis = new();
            var sve = servis.GetAll();

            var naziv = txtNaziv.Text.ToLower();
            var grad = cmbGrad.SelectedItem as Grad;

            if(sve.Any(x=> x.Naziv==naziv && x.GradId==grad.Id))
            {
                MessageBox.Show("ne mogu da se dodaju kompanije sa istim imenom i gradom");
                return false;
            }
            if(!int.TryParse(txtbr.Text,out int n))
            {
                MessageBox.Show("obavezno unijeti broj");
                return false;
            }
            if(int.Parse(txtbr.Text)<=0)
            {
                MessageBox.Show("ne moze biti negativan broj");
                return false;
            }
            var url = txtUrl.Text.Split('.');
            if(url.Length>3 || url[0]!="www" || url[1].Length<2 || url[2].Length<2)
            {
                MessageBox.Show("nije validna url adresa");
                return false;
            }

            return true;
            
        }

        private bool validacija1()
        {

            return Helpers.Validator.ValidanUnos(txtNaziv, errorProvider1, "obavezan unos") &&
                Helpers.Validator.ValidanUnos(txtAdresa, errorProvider1, "obavezan unos") &&
                Helpers.Validator.ValidanUnos(txtUrl, errorProvider1, "obavezan unos") &&
                Helpers.Validator.ValidanUnos(txtbr, errorProvider1, "obavezan unos") &&
                Helpers.Validator.ValidanUnos(pictureBox1, errorProvider1, "obavezan unos");
        }
    }
}
