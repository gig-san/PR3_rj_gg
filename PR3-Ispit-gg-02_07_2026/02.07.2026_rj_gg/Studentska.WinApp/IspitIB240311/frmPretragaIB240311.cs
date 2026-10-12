using Microsoft.CodeAnalysis.VisualBasic.Syntax;
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
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd-MMM-yy hh:mm";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "dd-MMM-yy hh:mm";

            dataGridView1.Columns[5].DefaultCellStyle.Format = "dd-MMM-yy hh:mm";

            cmbSattus.SelectedIndex = 0;
            cmbStanje.SelectedIndex = 0;

            ucitajDgv();

        }

        private void ucitajDgv()
        {
            StudentiProjektiIB240311Servis servis = new();
            var sve = servis.GetAll();

            var pretraga = textBox1.Text.ToLower();
            var stus = cmbSattus.SelectedItem.ToString();
            var stnje = cmbStanje.SelectedItem.ToString();

            var filtrirano = sve.Where(x => (x.Student.Ime.ToLower().Contains(pretraga) ||
            x.Student.Prezime.ToLower().Contains(pretraga) ||
            x.Projekt.Naziv.ToLower().Contains(pretraga)

            ) && (stnje == "Sve" || stnje == x.StanjePrijave) && (stus == "Sve" || stus == x.StatusPrijave)).ToList();

            dataGridView1.DataSource=filtrirano;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ucitajDgv();

        }

        private void cmbSattus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajDgv();

        }

        private void cmbStanje_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ucitajDgv();

        }

        private void brnNoviProj_Click(object sender, EventArgs e)
        {
            using var dialog = new frmProjekatAddIB240311();
            dialog.ShowDialog();
            ucitajDgv();
        }

        private void btnNovaprij_Click(object sender, EventArgs e)
        {
          
            using var dialog = new frmPrijavaAddEditIB240311();
            dialog.ShowDialog();
            ucitajDgv();
        }

        private void brnPrint_Click(object sender, EventArgs e)
        {
            var podaci = dataGridView1.DataSource as List<StudentiProjektiIB240311>;

            using var dialog = new frmIzvjestaji(podaci);
            dialog.ShowDialog();


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex<0 || e.ColumnIndex!=btnArhiviraj.Index) return;

            var podaci = dataGridView1.Rows[e.RowIndex].DataBoundItem as StudentiProjektiIB240311;
            if(podaci.Arhivirana)
            {
                MessageBox.Show("vec je arhivirana");
                return;
            }
            StudentiProjektiIB240311Servis servis = new();
            podaci.Arhivirana = true;

            servis.Update(podaci);
            ucitajDgv();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ) return;

            var podaci = dataGridView1.Rows[e.RowIndex].DataBoundItem as StudentiProjektiIB240311;
            using var dialog = new frmPrijavaAddEditIB240311(podaci);
            dialog.ShowDialog();
            ucitajDgv();

        }
    }
}
