using Microsoft.Reporting.WinForms;
using Studentska.Data.Entiteti;
using Studentska.Servis.Servisi.IspitIB240311;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private Student? student;

        public frmIzvjestaji()
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
        }

        public frmIzvjestaji(Student? student)
        {
            InitializeComponent();

            this.student = student;
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource =
              "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";

            ReportParameterCollection rpc = new();
            var tblPodaci = new dsIzvjestaji.tblPodaciDataTable();
            rpc.Add(new ReportParameter("studentReport", student.IndexImePrezime));

            StudentiKnjigeIB240311Servis servis = new();
            var sve = servis.GetAll().Where(x => x.StudentId == student.Id).ToList();


            int ukupno = 0;
            for (int i = 0; i < sve.Count; i++)
            {
                var s = sve[i];
                var red = tblPodaci.NewtblPodaciRow();
                red.Rb = $"{i + 1}";
                red.NazivKnjige = s.Knjiga.ToString();
                red.KnjigaVracena = s.Vracena ? "Da" : "Ne";
                if(s.DatumVracanja==null)
                {
                    red.BrojDana = (DateTime.Now - s.DatumIznajmljivanja).Days.ToString();
                    ukupno += (DateTime.Now - s.DatumIznajmljivanja).Days;
                }
                else
                {
                    red.BrojDana = (s.DatumVracanja.Value - s.DatumIznajmljivanja).Days.ToString();
                    ukupno += (s.DatumVracanja.Value - s.DatumIznajmljivanja).Days;
                }
                tblPodaci.Rows.Add(red);
            }
            rpc.Add(new ReportParameter("ukupnoDana", ukupno.ToString()));
            reportViewer1.LocalReport.SetParameters(rpc);

            ReportDataSource rds = new();
            rds.Value = tblPodaci;
            rds.Name = "DataSet1";

            reportViewer1.LocalReport.DataSources.Add(rds); 
            reportViewer1.RefreshReport();
        }
    }
}
