using fasilkom_prestasi.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;

namespace fasilkom_prestasi
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
            sidePanel.Height = btnRecord.Height;

            dgvPrestasi.DataSource = PrestasiContext.showAll(1);


            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "editButton";
            editButton.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.Name = "deleteButton";
            deleteButton.UseColumnTextForButtonValue = true;

            dgvPrestasi.Columns.Insert(0, editButton);
            dgvPrestasi.Columns.Insert(1, deleteButton);



        }

        private void archiveControl1_Load(object sender, EventArgs e)
        {


        }

        private void Record_Load(object sender, EventArgs e)
        {
            dgvPrestasi.DataSource = null;
            dgvPrestasi.DataSource = PrestasiContext.showAll(1);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRecord.Height;
            sidePanel.Top = btnRecord.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        private void btnAddAchievement_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AddAchievement addAchievement = new AddAchievement())
            {
                AddAchievement addAchievementPage = new AddAchievement();
                addAchievementPage.ShowDialog();
            }
            dgvPrestasi.DataSource = null;
            dgvPrestasi.DataSource = PrestasiContext.showAll(1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPrestasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvPrestasi.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {

                int idPrestasiHapus = Convert.ToInt32(dgvPrestasi.Rows[e.RowIndex].Cells["id_prestasi"].Value);

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    PrestasiContext.destroy(idPrestasiHapus);
                    DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                }

                dgvPrestasi.DataSource = null;
                dgvPrestasi.DataSource = PrestasiContext.showAll(1);
            }

            if (e.ColumnIndex == dgvPrestasi.Columns["editButton"].Index && e.RowIndex >= 0)
            {

                int idPrestasiUbah = Convert.ToInt32(dgvPrestasi.Rows[e.RowIndex].Cells["id_prestasi"].Value);

                using (EditAchievement editPrestasi = new EditAchievement(idPrestasiUbah))
                {
                    this.Hide();
                    EditAchievement halamanEditPrestasi = new EditAchievement(idPrestasiUbah);
                    halamanEditPrestasi.ShowDialog();
                }
                dgvPrestasi.DataSource = null;
                dgvPrestasi.DataSource = PrestasiContext.showAll(1);
            }
        }
    }
}
