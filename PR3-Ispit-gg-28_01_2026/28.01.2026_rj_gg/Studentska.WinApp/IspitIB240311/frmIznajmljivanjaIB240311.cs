using Studentska.Data.Entiteti;
using Studentska.Data.Modeli.IspitIB240311;
using Studentska.Servis.Servisi;
using Studentska.Servis.Servisi.IspitIB240311;
using Studentska.WinApp.Helpers;
using Studentska.WinApp.Izvjestaji;
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
    public partial class frmIznajmljivanjaIB240311 : Form
    {
        public frmIznajmljivanjaIB240311()
        {
            InitializeComponent();
        }

        private void frmIznajmljivanjaIB240311_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd-MMM-yy hh:mm";

            StudentServis serVisS = new();
            var sviStud = serVisS.GetAll();
            cmbStudent.UcitajPodatke(sviStud, "Id", "IndexImePrezime");
            KnjigeIB240311Servis servisK = new();
            var sveKnjige = servisK.GetAll();
            cmbKnjiga.UcitajPodatke(sveKnjige, "Id", "Naziv");

            ucitajDgv();
        }

        private void ucitajDgv()
        {
            StudentiKnjigeIB240311Servis servis = new();
            var sve = servis.GetAll();
            var student = cmbStudent.SelectedItem as Student;
            var knjiga = cmbKnjiga.SelectedItem as KnjigeIB240311;

            var filtrirano = sve.Where(x => x.KnjigaId == knjiga.Id && x.StudentId == student.Id).ToList();
            dataGridView1.DataSource = filtrirano;
        }

        private void cmbStudent_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajDgv();
        }

        private void cmbKnjiga_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajDgv();
        }

        public bool validacija()
        {
            StudentiKnjigeIB240311Servis servis = new();
            var sve = servis.GetAll();
            var student = cmbStudent.SelectedItem as Student;
            var knjiga = cmbKnjiga.SelectedItem as KnjigeIB240311;

            if (sve.Any(x => x.StudentId == student.Id && x.KnjigaId == knjiga.Id && !x.Vracena))
            {
                MessageBox.Show("niste vratili knjigu");
                return false;
            }
            if (sve.Count(x => x.KnjigaId == knjiga.Id && !x.Vracena) >= knjiga.BrojPrimjeraka)
            {
                MessageBox.Show("nema slobdnih primjeraka");
                return false;
            }
            return true;

        }

        private void btnIznajmi_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                StudentiKnjigeIB240311Servis servis = new();

                var student = cmbStudent.SelectedItem as Student;
                var knjiga = cmbKnjiga.SelectedItem as KnjigeIB240311;

                var nova = new StudentiKnjigeIB240311()
                {
                    StudentId = student.Id,
                    KnjigaId = knjiga.Id,
                    DatumIznajmljivanja = DateTime.Now,
                    DatumVracanja = null
                };
                servis.Add(nova);
                ucitajDgv();
                MessageBox.Show("iznajmili ste nocu knjigu");
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;
            Thread t = new Thread(() => funkcijaTred(student));
            t.Start();

        }

        private void funkcijaTred(Student? student)
        {
            StudentiKnjigeIB240311Servis servis = new();
            var sve = servis.GetAll();

            KnjigeIB240311Servis servisK = new();
            var sveKnjige = servisK.GetAll();

            var izanjljene = sve.Where(x => x.StudentId == student.Id && !x.Vracena).Select(x => x.KnjigaId).ToList();
            var neiznajmljene = sveKnjige.Where(x => !izanjljene.Contains(x.Id)).ToList();

            if (neiznajmljene.Count == 0)
            {
                MessageBox.Show("nema");
                return;
            }

            for (int i = 0; i < neiznajmljene.Count; i++)
            {
                var n = neiznajmljene[i];
                var nova = new StudentiKnjigeIB240311()
                {
                    StudentId = student.Id,
                    KnjigaId = n.Id,
                    DatumIznajmljivanja = DateTime.Now,
                    DatumVracanja = null
                };
                servis.Add(nova);

                Action action = () =>
                {

                    richTextBox1.Text += $"{i + 1}.{student} dodato zaduzenje {n}" + Environment.NewLine;
                };
                BeginInvoke(action);
                Thread.Sleep(300);
            }
            BeginInvoke(ucitajDgv);
            MessageBox.Show("dodali smo vas heheheh");
        }

        private void btnPotvrda_Click(object sender, EventArgs e)
        {

            var student = cmbStudent.SelectedItem as Student;
            using var dialog = new frmIzvjestaji(student);
            dialog.ShowDialog();
        }
    }
}
