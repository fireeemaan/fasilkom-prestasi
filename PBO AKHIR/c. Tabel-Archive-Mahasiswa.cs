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
using fasilkom_prestasi.App.Core;

namespace fasilkom_prestasi
{
    public partial class Record : Form
    {
        int userRole;
        long nim;

        public Record(int userRole, long nim)
        {
            this.nim = nim;

            this.userRole = userRole;

            InitializeComponent();
            DataTable dataPrestasi = PrestasiContext.showAll(1);

            dgvPrestasi.DataSource = dataPrestasi;

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


            DataGridViewButtonColumn convertButton = new DataGridViewButtonColumn();
            convertButton.HeaderText = "";
            convertButton.Text = "Convert";
            convertButton.Name = "convertButton";
            convertButton.UseColumnTextForButtonValue = true;

            dgvPrestasi.Columns.Insert(0, editButton);
            dgvPrestasi.Columns.Insert(1, deleteButton);
            dgvPrestasi.Columns.Insert(2, convertButton);

        }

        public Record(long nim)
        {
            this.nim = nim;
            InitializeComponent();
            DataTable dataPrestasi = PrestasiContext.showAll(1);

            dgvPrestasi.DataSource = dataPrestasi;

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


            DataGridViewButtonColumn convertButton = new DataGridViewButtonColumn();
            convertButton.HeaderText = "";
            convertButton.Text = "Convert";
            convertButton.Name = "convertButton";
            convertButton.UseColumnTextForButtonValue = true;

            dgvPrestasi.Columns.Insert(0, editButton);
            dgvPrestasi.Columns.Insert(1, deleteButton);
            dgvPrestasi.Columns.Insert(2, convertButton);
        }



        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAchievement_Click(object sender, EventArgs e)
        {
            this.Hide();
            

            DataTable dataPrestasi = PrestasiContext.showAll(1);

            using (FormArchiveMahasiswa addAchievement = new FormArchiveMahasiswa(nim))
            {
                FormArchiveMahasiswa addAchievementPage = new FormArchiveMahasiswa(nim);
                addAchievementPage.ShowDialog();
            }
            dgvPrestasi.DataSource = null;
            dgvPrestasi.DataSource = PrestasiContext.showAll(1);
        }

        private void Record_Load(object sender, EventArgs e)
        {

        }

        private void dgvPrestasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == dgvPrestasi.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {

                string idPrestasiHapus = dgvPrestasi.Rows[e.RowIndex].Cells["id_prestasi"].Value.ToString();

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

                string idPrestasiUbah = dgvPrestasi.Rows[e.RowIndex].Cells["id_prestasi"].Value.ToString();


                using (FormArchiveMahasiswa editPrestasi = new FormArchiveMahasiswa(nim, idPrestasiUbah))
                {
                    this.Hide();
                    FormArchiveMahasiswa formEditPrestasi = new FormArchiveMahasiswa(nim, idPrestasiUbah);
                    formEditPrestasi.ShowDialog();
                }
                dgvPrestasi.DataSource = null;
                dgvPrestasi.DataSource = PrestasiContext.showAll(1);
            }

            if (e.ColumnIndex == dgvPrestasi.Columns["convertButton"].Index && e.RowIndex >= 0 && dgvPrestasi.Rows[e.RowIndex].Cells["validated"].Value.ToString() == "Validated")
            {

              
                string idConvertPrestasi = dgvPrestasi.Rows[e.RowIndex].Cells["id_prestasi"].Value.ToString();

                using (Form_Convertion_Mahasiswa convertPrestasi = new Form_Convertion_Mahasiswa(nim, idConvertPrestasi))
                {
                    this.Hide();
                    Form_Convertion_Mahasiswa formConvertPrestasi = new Form_Convertion_Mahasiswa(nim, idConvertPrestasi);
                    formConvertPrestasi.ShowDialog();
                }

                dgvPrestasi.DataSource = null;
                dgvPrestasi.DataSource = PrestasiContext.showAll(1);
            }
            else if (e.ColumnIndex == dgvPrestasi.Columns["convertButton"].Index && e.RowIndex >= 0 && dgvPrestasi.Rows[e.RowIndex].Cells["validated"].Value.ToString() != "Validated")
            {
                MessageBox.Show("Belum Validasi Goblok");
            }
        }
    }
}
