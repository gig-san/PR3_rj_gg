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
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Studentska.WinApp.IspitIB240311
{
    public partial class frmPrijavaAddEditIB240311 : Form
    {
        private StudentiProjektiIB240311? podaci;

        public frmPrijavaAddEditIB240311()
        {
            InitializeComponent();
            this.Text = "nova prijava";
        }

        public frmPrijavaAddEditIB240311(StudentiProjektiIB240311? podaci)
        {
            InitializeComponent();

            this.podaci = podaci;
            this.Text = "edit prijave";
        }

        private void frmPrijavaAddEditIB240311_Load(object sender, EventArgs e)
        {
            if (podaci != null)
            {
                //U slučaju editovanja, koje se pokreće dvostrukim klikom na neki od zapisa na formi
                //frmPretragaBrojIndeksa, omogućiti promjenu podataka poštujući sljedeća pravila:
                //                
                //Student se ne može mijenjati.

                //Projekat se može mijenjati samo ako je status prijave PODNESENA. 
                //Status prijave se može mijenjati na PRIHVACENA, ODBIJENA ili ZAVRSENA.

                cmbStudent.DataSource = new List<Student> { podaci.Student };
                cmbStudent.SelectedIndex = 0;
                cmbStudent.Enabled = false;

                if (podaci.StatusPrijave == "PODNESENA")
                {
                    ProjektiIB240311Servis servisP = new();
                    var sviProjketi = servisP.GetAll().Where(x => x.Aktivan).ToList();
                    cmbProjekat.UcitajPodatke(sviProjketi, "Id", "Naziv");
                    cmbProjekat.SelectedValue = podaci.Projekt.Id;
                }
                else
                {
                    cmbProjekat.DataSource = new List<ProjektiIB240311> { podaci.Projekt };
                    cmbProjekat.SelectedIndex = 0;
                    cmbProjekat.Enabled = false;
                }

                cmbStatus.DataSource = new List<string>
                {
                   "PRIHVACENA",
                    "ODBIJENA",
                    "ZAVRSENA"
                };
                cmbStatus.SelectedItem = podaci.StatusPrijave;


            }
            else
            {

                //Prilikom dodavanja omogućiti odabir studenta, projekta i datuma prijave,
                //a status prijave
                //podrazumijevano postaviti na PODNESENA bez mogućnosti odabira.U ComboBox kontroli
                //za projekte prikazati samo aktivne projekte.

                StudentServis serviS = new();
                var sviStduenti = serviS.GetAll();
                cmbStudent.UcitajPodatke(sviStduenti, "Id", "IndexImePrezime");
                cmbStudent.SelectedIndex = 0;

                ProjektiIB240311Servis servisP = new();
                var sviProjketi = servisP.GetAll().Where(x => x.Aktivan).ToList();
                cmbProjekat.UcitajPodatke(sviProjketi, "Id", "Naziv");
                cmbProjekat.SelectedIndex = 0;

                cmbStatus.DataSource = new List<string>
                {
                    "PODNESENA"
                };
                cmbStatus.SelectedIndex = 0;
                cmbStatus.Enabled = false;


            }
        }

        private bool validacija()
        {
            //    Onemogućiti dodavanje prijave za projekat koji nije aktivan. --
            //    e.Onemogućiti da datum prijave bude veći od roka završetka odabranog projekta.
            //    
            //    Onemogućiti da jedan student ima dvije aktivne prijave na isti projekat.

            //    g.Onemogućiti da jedan student ima više od jedne prihvaćene prijave dok prethodna nije
            //    završena.

            //    h.Onemogućiti da broj prihvaćenih prijava za projekat prelazi maksimalan broj studenata
            //    definisan za odabrani projekat.Korisnika obavijestiti porukom da se nove prijave mogu
            //    prihvatiti tek nakon što se za nekog od trenutno prihvaćenih studenata status promijeni
            //    u ZAVRSENA.
            var student = cmbStudent.SelectedItem as Student;
            var projekat = cmbProjekat.SelectedItem as ProjektiIB240311;

            StudentiProjektiIB240311Servis servis = new();
            var sve = servis.GetAll();

            if (dateTimePicker1.Value > projekat.RokZavrsetka)
            {
                MessageBox.Show("datum prijave ne moze da bude veći od roka završetka odabranog projekta.");
                return false;
            }
            if (sve.Any(x => x.StudentId == student.Id && x.ProjektId == projekat.Id && !x.Arhivirana && (podaci == null || podaci.Id != x.Id)))
            {
                MessageBox.Show("jedan student ne moze da ima dvije aktivne prijave na isti projekat.");
                return false;
            }

            if (cmbStatus.SelectedItem.ToString() == "PRIHVACENA")
            {
                if (sve.Any(x => x.StudentId == student.Id && x.StatusPrijave == "PRIHVACENA" && (podaci == null || podaci.Id != x.Id)))
                {

                    MessageBox.Show("jedan student ne moze da ima više od jedne prihvaćene prijave dok prethodna nije završena.");
                    return false;
                }
                if (sve.Count(x => x.ProjektId == projekat.Id && x.StatusPrijave == "PRIHVACENA" && (podaci == null || podaci.Id != x.Id)) >= projekat.MaxBrStudenata)
                {
                    MessageBox.Show("broj prihvaćenih prijava za projekat ne moze da  prelazi maksimalan broj studenata definisan za odabrani projekat.");
                    return false;
                }
            }
            return true;

        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if (validacija())
            {
                var student = cmbStudent.SelectedItem as Student;
                var projekat = cmbProjekat.SelectedItem as ProjektiIB240311;
                StudentiProjektiIB240311Servis servis = new();


                if (podaci != null)
                {
                    podaci.ProjektId = projekat.Id;
                    if (podaci.StatusPrijave != cmbStatus.SelectedItem.ToString())
                    {
                        podaci.DatumPromjene = DateTime.Now;
                    }
                    if (cmbStatus.SelectedItem.ToString() == "ZAVRSENA")
                    {
                        podaci.Arhivirana = true;
                    }
                    podaci.StatusPrijave = cmbStatus.SelectedItem.ToString();
                    servis.Update(podaci);
                    MessageBox.Show("uspjesno steeditovali prijavu");


                }
                else
                {

                    var nova = new StudentiProjektiIB240311()
                    {
                        StudentId = student.Id,
                        ProjektId = projekat.Id,
                        DatumPrijave = dateTimePicker1.Value,
                        StatusPrijave = cmbStatus.SelectedItem.ToString(),
                        DatumPromjene = null,
                        Arhivirana = false
                    };

                    servis.Add(nova);
                    MessageBox.Show("uspjesno ste dodali prijavu");

                }
            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            var student = cmbStudent.SelectedItem as Student;
            Thread t = new Thread(() => thredFunkcija(student));
            t.Start();
        }

        private void thredFunkcija(Student? student)
        {
            StudentiProjektiIB240311Servis servis = new();
            var sve = servis.GetAll();

            ProjektiIB240311Servis servisP = new();
            var sviProjketi = servisP.GetAll();

            var prijavljeni = sve.Where(x => x.StudentId == student.Id && !x.Arhivirana).Select(x => x.ProjektId).ToList();
            var neprijavljene = sviProjketi.Where(x => !prijavljeni.Contains(x.Id) && x.Aktivan && x.RokZavrsetka > DateTime.Now).ToList();

            if(neprijavljene.Count==0)
            {
                MessageBox.Show("nemate neprijavljenih projekata");
                return;
            }
            for (int i = 0; i < neprijavljene.Count; i++)
            {
                var n = neprijavljene[i];
                var nova = new StudentiProjektiIB240311()
                {
                    StudentId = student.Id,
                    ProjektId = n.Id,
                    DatumPrijave = DateTime.Now,
                    StatusPrijave = "PODNESENA",
                    DatumPromjene=null,
                    Arhivirana=false

                };
                servis.Add(nova);
                Action action = () =>
                {
                    richTextBox1.Text += $"Dodata prijava na \"{n}\" - studentu {student}" + Environment.NewLine;
                };
                BeginInvoke(action);
                Thread.Sleep(300);

            }
        }
    }
}
