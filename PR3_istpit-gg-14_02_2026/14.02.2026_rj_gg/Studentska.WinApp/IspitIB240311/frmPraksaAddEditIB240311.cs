using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
    public partial class frmPraksaAddEditIB240311 : Form
    {
        private StudentiPraksaIB240311? podaci;

        public frmPraksaAddEditIB240311()
        {
            InitializeComponent();
        }

        public frmPraksaAddEditIB240311(StudentiPraksaIB240311? podaci)
        {
            InitializeComponent();

            this.podaci = podaci;
        }

        private void frmPraksaAddEditIB240311_Load(object sender, EventArgs e)
        {
            if (podaci != null)
            {
                //U slučaju editovanja, koji se pokreće dvostrukim klikom na neki od zahtjeva za praksu na
                //formi frmPretragaBrojIndeksa, omogućiti promjenu svih podataka.Ukoliko je došlo do
                //    promjene statusa, promijeniti i vrijednost datum promjene statusa.

                StudentServis servisS = new();
                var sviStduenti = servisS.GetAll();
                cmbStudent.UcitajPodatke(sviStduenti, "Id", "IndexImeprezime");
                cmbStudent.SelectedValue = podaci.Student.Id;

                KompanijeIB240311Servis servisK = new();
                var sveKomapniejAktivne = servisK.GetAll().Where(x => x.Aktivna).ToList();
                cmbKompanije.UcitajPodatke(sveKomapniejAktivne, "Id", "Naziv");
                cmbKompanije.SelectedValue = podaci.Kompanija.Id;

                cmbStatus.DataSource = new List<string>
                {
                    "PODNESENA",
                    "PRIHVACENA",
                    "ODBIJENA",
                    "REALIZOVANA"
                };

                cmbStatus.SelectedItem = podaci.Status;

            }
            else
            {
                //Prilikom dodavanja omogućiti odabir studenta, kompanije(samo aktivne kompanije) i
                //datuma prijave, a status podrazumijevano postaviti na PODNESENA(bez mogućnosti
                //odabira). 

                StudentServis servisS = new();
                var sviStduenti = servisS.GetAll();
                cmbStudent.UcitajPodatke(sviStduenti, "Id", "IndexImeprezime");
                cmbStudent.SelectedIndex = 0;

                KompanijeIB240311Servis servisK = new();
                var sveKomapniejAktivne = servisK.GetAll().Where(x => x.Aktivna).ToList();
                cmbKompanije.UcitajPodatke(sveKomapniejAktivne, "Id", "Naziv");
                cmbKompanije.SelectedIndex = 0;

                cmbStatus.DataSource = new List<string>
                {
                    "PODNESENA"
                };
                cmbStatus.SelectedIndex = 0;
                cmbStatus.Enabled = false;


            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                StudentiPraksaIB240311Servis servis = new();


                var studnet = cmbStudent.SelectedItem as Student;
                var komp = cmbKompanije.SelectedItem as KompanijeIB240311;
                var stus = cmbStatus.SelectedItem.ToString();

                if (podaci != null)
                {
                    if (stus != podaci.Status)
                    {
                        podaci.DatumPromjene = DateTime.Now;
                    }
                    podaci.StudentId = studnet.Id;
                    podaci.KompanijaId = komp.Id;
                    podaci.DatumPrijave = dateTimePicker1.Value;
                    podaci.Status = stus;
                    servis.Update(podaci);
                    MessageBox.Show("uspjesno ste edit");

                }
                else
                {
                    var nova = new StudentiPraksaIB240311()
                    {
                        StudentId = studnet.Id,
                        KompanijaId = komp.Id,
                        DatumPrijave = dateTimePicker1.Value,
                        Status = stus,
                        DatumPromjene = null
                    };
                    servis.Add(nova);
                    MessageBox.Show("uspjesno ste dodali prijavu");
                }
            }
        }

        private bool validacija()
        {
            StudentiPraksaIB240311Servis servis = new();
            var sve = servis.GetAll();

            var studnet = cmbStudent.SelectedItem as Student;
            var komp = cmbKompanije.SelectedItem as KompanijeIB240311;
            var stus = cmbStatus.SelectedItem.ToString();

            if (stus == "PRIHVACENA")
            {
                if (sve.Count(x => x.KompanijaId == komp.Id && x.Status == "PRIHVACENA" && (podaci == null || podaci.Id != x.Id)) >= komp.MaxBrojStudenata)
                {
                    MessageBox.Show("broj prihvacenih studenata je popunjen");
                    return false;
                }
                if (sve.Any(x => x.StudentId == studnet.Id && x.Status == "PRIHVACENA" && (podaci == null | podaci.Id != x.Id)))
                {
                    MessageBox.Show("ne mozete biti prihvaceni na vise mjesta");
                    return false;
                }
            }
            if (sve.Any(x => x.KompanijaId == komp.Id && x.StudentId == studnet.Id && (podaci == null || podaci.Id != x.Id)))
            {
                MessageBox.Show("ne mozete poslati vise zahtjeva u istoj kompaniji");
                return false;
            }

            return true;
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            var studnet = cmbStudent.SelectedItem as Student;

            Thread t = new Thread(() => FunkcijaThread(studnet));
            t.Start();
        }

        private void FunkcijaThread(Student? studnet)
        {
            StudentiPraksaIB240311Servis servis = new();
            var sve = servis.GetAll();
            KompanijeIB240311Servis servisK = new();
            var kompanijeSve= servisK.GetAll();

            var prijavljene = sve.Where(x => x.StudentId == studnet.Id).Select(x => x.KompanijaId).ToList();
            var neprijavljen = kompanijeSve.Where(x => !prijavljene.Contains(x.Id) && x.Aktivna).ToList();

            if(neprijavljen.Count==0)
            {
                MessageBox.Show("nemate neprijavljenih praksi");
                return;
            }
            for (int i = 0; i < neprijavljen.Count; i++)
            {
                var n = neprijavljen[i];
                var nova = new StudentiPraksaIB240311()
                {
                    StudentId = studnet.Id,
                    KompanijaId = n.Id,
                    DatumPrijave = DateTime.Now,
                    Status = "PODNESENA",
                    DatumPromjene = null
                };

                servis.Add(nova);

                Action ac = () =>
                {
                    richTextBox1.Text += $"{1 + i}->{DateTime.Now.ToShortDateString()} kreiran zahtjev za praksu {studnet} u kompaniji {n}" + Environment.NewLine;
                };
                BeginInvoke(ac);
                Thread.Sleep(300);

            }
        }
    }
}
