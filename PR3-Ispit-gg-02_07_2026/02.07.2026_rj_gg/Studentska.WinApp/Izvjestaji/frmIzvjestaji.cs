using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Reporting.WinForms;
using Studentska.Data.Modeli.IspitIB240311;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiProjektiIB240311>? podaci;

        public frmIzvjestaji()
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
        }

        public frmIzvjestaji(List<StudentiProjektiIB240311>? podaci)
        {
            InitializeComponent();

            this.podaci = podaci;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource =
              "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";

            ReportParameterCollection rpc = new();
            var tblPodaci = new dsIzvjestaji.tblPodaciDataTable();
            float ukupno = 0.0f;

            if(podaci.Count==0)
            {
                MessageBox.Show("nema");
                return;
            }
            for (int i = 0; i < podaci.Count; i++)
            {
                var red = tblPodaci.NewtblPodaciRow();
                red.Rb = $"{i + 1}";
                red.Student = podaci[i].Student.IndexImePrezime;
                red.Projekat = podaci[i].Projekt.Naziv;
                red.Stanje = podaci[i].StanjePrijave;
                red.RokZavrsetka = podaci[i].RokZavrsetka.ToShortDateString();

                //Kolona Broj dana do roka se izračunava kao razlika između roka završetka projekta i trenutnog
                //datuma.Ukoliko je rok završetka projekta prošao, vrijednost kolone Broj dana do roka treba biti
                //0.
                if (podaci[i].RokZavrsetka<DateTime.Now)
                {
                    red.BrojDana = "0";
                }
                else
                {
                    red.BrojDana = (podaci[i].RokZavrsetka - DateTime.Now).Days.ToString();
                    ukupno += (podaci[i].RokZavrsetka - DateTime.Now).Days;


                }
                tblPodaci.Rows.Add(red);
            }
            rpc.Add(new ReportParameter("brojDana", (ukupno / podaci.Count).ToString("F2")));
            reportViewer1.LocalReport.SetParameters(rpc);

            ReportDataSource rds = new();
            rds.Value = tblPodaci;
            rds.Name = "DataSet1";
           reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.RefreshReport();
        }
    }
}
