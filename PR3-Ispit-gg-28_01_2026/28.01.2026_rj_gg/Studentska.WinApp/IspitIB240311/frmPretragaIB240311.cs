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
    public partial class frmPretragaIB240311 : Form
    {
        public frmPretragaIB240311()
        {
            InitializeComponent();
        }

        private void frmPretragaIB240311_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd-MMM-yy";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "dd-MMM-yy";


            ucitajdgv();
        }

        private void ucitajdgv()
        {
            StudentiKnjigeIB240311Servis servis = new();
            var sve = servis.GetAll();
            var pretraga = textBox1.Text.ToLower();
            var filtrirano = sve.Where(x => (x.Student.Ime.ToLower().Contains(pretraga) ||
            x.Student.Prezime.ToLower().Contains(pretraga) ||
            x.Knjiga.Naziv.ToLower().Contains(pretraga)) &&
            x.Vracena == checkBox1.Checked
            ).ToList();

            dataGridView1.DataSource = filtrirano;
            this.Text = $"broj prikazanih podataka: {dataGridView1.RowCount}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ucitajdgv();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ucitajdgv();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != btnPovrat.Index)
            {
                return;
            }
            var podaci = dataGridView1.Rows[e.RowIndex].DataBoundItem as StudentiKnjigeIB240311;
            if (podaci.Vracena)
            {
                MessageBox.Show("vec je vraceno!");
                return;
            }
            StudentiKnjigeIB240311Servis servis = new();

            podaci.DatumVracanja = DateTime.Now;
            servis.Update(podaci);
            ucitajdgv();

        }

        private void btnDodajknjigu_Click(object sender, EventArgs e)
        {
            using var fialog = new frmKnjigaAddEditIB240311();
            fialog.ShowDialog();
            ucitajdgv();
        }

        private void btnIznajmljivanje_Click(object sender, EventArgs e)
        {
            using var dialog = new frmIznajmljivanjaIB240311();
            dialog.ShowDialog();
            ucitajdgv();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var podaci = dataGridView1.Rows[e.RowIndex].Cells[1].Value as KnjigeIB240311;

            using var fialog = new frmKnjigaAddEditIB240311(podaci);
            fialog.ShowDialog();
            ucitajdgv();

        }
    }
}
