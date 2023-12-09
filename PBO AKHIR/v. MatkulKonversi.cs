using fasilkom_prestasi.App.Context;
using fasilkom_prestasi.App.Models;
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
    public partial class MatkulKonversi : Form
    {
        long id_admin;
        public MatkulKonversi(long idAdmin)
        {
            this.id_admin = idAdmin;
            InitializeComponent();
            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.all();

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

            dgvFormMatkulKonversi.Columns.Insert(0, editButton);
            dgvFormMatkulKonversi.Columns.Insert(1, deleteButton);
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;

            dgvFormMatkulKonversi.Columns["id"].Visible = false;
            this.id_admin = id_admin;
        }



        private void dgvFormMatkulKonversi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFormMatkulKonversi.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                int idMatkulKonversiUbah = int.Parse(dgvFormMatkulKonversi.Rows[e.RowIndex].Cells["id"].Value.ToString());

                using (addMatkulKonversi matkulKonversi = new addMatkulKonversi(idMatkulKonversiUbah))
                {
                    addMatkulKonversi tambahMatkulKonversi = new addMatkulKonversi(idMatkulKonversiUbah);
                    tambahMatkulKonversi.ShowDialog();
                }

                dgvFormMatkulKonversi.DataSource = null;
                dgvFormMatkulKonversi.DataSource = prodiMatkulContext.all();
                dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
                dgvFormMatkulKonversi.Columns[0].Width = 100;
                dgvFormMatkulKonversi.Columns[1].Width = 100;

                dgvFormMatkulKonversi.Columns["id"].Visible = false;

            }
            if (e.ColumnIndex == dgvFormMatkulKonversi.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {
                int idMatkulKonversiHapus = int.Parse(dgvFormMatkulKonversi.Rows[e.RowIndex].Cells["id"].Value.ToString());

                try
                {
                    DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        prodiMatkulContext.destroy(idMatkulKonversiHapus);
                        DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                    }

                }
                catch
                {
                    MessageBox.Show("Nilai sedang dipakai di tabel lain!", "Hapus Data Gagal!");
                }


                dgvFormMatkulKonversi.DataSource = null;
                dgvFormMatkulKonversi.DataSource = prodiMatkulContext.all();
                dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
                dgvFormMatkulKonversi.Columns[0].Width = 100;
                dgvFormMatkulKonversi.Columns[1].Width = 100;

                dgvFormMatkulKonversi.Columns["id"].Visible = false;

            }
        }

        private void btnAddMatkulKonversi_Click(object sender, EventArgs e)
        {
            using (addMatkulKonversi MatkulKonversiBaru = new addMatkulKonversi())
            {
                addMatkulKonversi addMatkulKonversi = new addMatkulKonversi();
                addMatkulKonversi.ShowDialog();
            }
            dgvFormMatkulKonversi.DataSource = null;
            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.all();
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;

            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnSistemInformasi_Click(object sender, EventArgs e)
        {
            dgvFormMatkulKonversi.DataSource = null;

            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.showsorted("Sistem Informasi");
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnTeknologiInformasi_Click(object sender, EventArgs e)
        {
            dgvFormMatkulKonversi.DataSource = null;

            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.showsorted("Teknologi Informasi");
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnInformatika_Click(object sender, EventArgs e)
        {
            dgvFormMatkulKonversi.DataSource = null;

            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.showsorted("Informatika");
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvFormMatkulKonversi.DataSource = null;

            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.all();
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnConvertion_Click(object sender, EventArgs e)
        {
            this.Hide();
            KonversiAdmin konversi = new KonversiAdmin(id_admin);
            konversi.Show();
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Hide();
            Validation validation = new Validation(id_admin);
            validation.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            otherMenu otherMenu = new otherMenu(id_admin);
            otherMenu.Show();
        }
    }
}
