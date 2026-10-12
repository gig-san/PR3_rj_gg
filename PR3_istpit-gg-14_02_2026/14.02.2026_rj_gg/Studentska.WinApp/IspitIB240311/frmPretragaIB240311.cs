using Studentska.Data.Modeli.IspitIB240311;
using Studentska.Servis.Servisi.IspitIB240311;
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
    public partial class frmPretragaIB240311 : Form
    {
        public frmPretragaIB240311()
        {
            InitializeComponent();
        }

        private void frmPretragaIB240311_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            comboBox1.SelectedIndex = 0;
            ucitajDgv();
        }

        private void ucitajDgv()
        {
            var pretraga = textBox1.Text.ToLower();
            var cmb = comboBox1.SelectedItem.ToString();
            StudentiPraksaIB240311Servis servis = new();
            var sve = servis.GetAll();
            var filtrirano = sve.Where(x => (x.Student.Ime.ToLower().Contains(pretraga) ||
            x.Student.Prezime.ToLower().Contains(pretraga) || x.Kompanija.Naziv.ToLower().Contains(pretraga)
            ) && (cmb == x.Status)).ToList();

            dataGridView1.DataSource = filtrirano;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ucitajDgv();

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajDgv();

        }

        private void btnNovakomp_Click(object sender, EventArgs e)
        {
            using var dialog = new frmKompanijaAddIB240311();
            dialog.ShowDialog();
            ucitajDgv();
        }

        private void btnNovapraks_Click(object sender, EventArgs e)
        {
            using var dialog = new frmPraksaAddEditIB240311();
            dialog.ShowDialog();
            ucitajDgv();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var podaci = dataGridView1.DataSource as List<StudentiPraksaIB240311>;
            using var dialog = new frmIzvjestaji(podaci);
            dialog.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != btnObrisi.Index)
            {
                return;
            }
            var podaci = dataGridView1.Rows[e.RowIndex].DataBoundItem as StudentiPraksaIB240311;
            StudentiPraksaIB240311Servis servis = new();
            var dialog = MessageBox.Show("da li zelite izbrisati ovaj red?", "brisanje podataka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                servis.Remove(podaci);
                ucitajDgv();
            }
            else
            {
                return;
            }



        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            var podaci = dataGridView1.Rows[e.RowIndex].DataBoundItem as StudentiPraksaIB240311;
            using var dialog = new frmPraksaAddEditIB240311(podaci);
            dialog.ShowDialog();
            ucitajDgv();
        }
    }
}
