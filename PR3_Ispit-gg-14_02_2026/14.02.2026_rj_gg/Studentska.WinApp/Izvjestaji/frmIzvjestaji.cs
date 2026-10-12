using Microsoft.Reporting.WinForms;
using Studentska.Data.Modeli.IspitIB240311;

namespace Studentska.WinApp.Izvjestaji
{
    public partial class frmIzvjestaji : Form
    {
        private List<StudentiPraksaIB240311>? podaci;

        public frmIzvjestaji()
        {
            InitializeComponent();
            reportViewer1.LocalReport.ReportEmbeddedResource =
                "Studentska.WinApp.Izvjestaji.rptStudentiUplate.rdlc";
        }

        public frmIzvjestaji(List<StudentiPraksaIB240311>? podaci)
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
            if(podaci.Count==0)
            {
                MessageBox.Show("nema podataka");
                return;
            }
            rpc.Add(new ReportParameter("brojZahtjeva", podaci.Count.ToString()));
            for (int i = 0; i < podaci.Count; i++)
            {
                var p = podaci[i];
                var red = tblPodaci.NewtblPodaciRow();
                red.Rb = $"{i + 1}";
                red.Student = p.Student.IndexImeprezime;
                red.Kompanija = p.Kompanija.Naziv;
                red.Status=p.Status;
                if(p.DatumPromjene==null)
                {
                    red.DatumPromjene = "";
                }
                else
                {
                    red.DatumPromjene = p.DatumPromjene.ToString();
                }
                tblPodaci.Rows.Add(red);
            }

            reportViewer1.LocalReport.SetParameters(rpc);

            ReportDataSource rds = new();
            rds.Value = tblPodaci;
            rds.Name = "DataSet1";
             reportViewer1.LocalReport.DataSources.Add(rds);    

            reportViewer1.RefreshReport();
        }
    }
}
