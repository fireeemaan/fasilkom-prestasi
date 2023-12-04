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

namespace fasilkom_prestasi
{
    public partial class Tahapan : Form
    {
        public Tahapan()
        {
            InitializeComponent();

            dgvFormTahapan.DataSource = TahapanContext.all();


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

            dgvFormTahapan.Columns.Insert(0, editButton);
            dgvFormTahapan.Columns.Insert(1, deleteButton);

        }

        private void btnAddTahapan_Click(object sender, EventArgs e)
        {
            this.Hide();


            addTahapan tahapan = new addTahapan();
            tahapan.Show();

        }

        private void dgvFormTahapan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFormTahapan.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {

                int idBidangHapus = int.Parse(dgvFormTahapan.Rows[e.RowIndex].Cells["id"].Value.ToString());

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    try
                    {
                        TahapanContext.destroy(idBidangHapus);
                        DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data tidak bisa dihapus karena terpakai pada tabel lain !");
                    }

                    dgvFormTahapan.DataSource = null;
                    dgvFormTahapan.DataSource = TahapanContext.all();
                }



            }
            if (e.ColumnIndex == dgvFormTahapan.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                int idTahapanUbah = int.Parse(dgvFormTahapan.Rows[e.RowIndex].Cells["id"].Value.ToString());


                using (addTahapan editTahapan = new addTahapan(idTahapanUbah))
                {
                    this.Hide();
                    addTahapan formEditTahapan = new addTahapan(idTahapanUbah);
                    formEditTahapan.Show();
                }
                dgvFormTahapan.DataSource = null;
                dgvFormTahapan.DataSource = TahapanContext.all();

            }
        }
    }
}
