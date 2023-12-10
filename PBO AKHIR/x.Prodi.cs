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
    public partial class Prodi : Form
    {
        long id_admin;
        public Prodi(long idAdmin)
        {

            this.id_admin = idAdmin;
            InitializeComponent();

            dgvFormProdi.DataSource = ProdiContext.all();


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

            dgvFormProdi.Columns.Insert(0, editButton);
            dgvFormProdi.Columns.Insert(1, deleteButton);
            dgvFormProdi.Columns[0].Width = 100;
            dgvFormProdi.Columns[1].Width = 100;
            dgvFormProdi.Columns["prodi"].Width = 300;

            dgvFormProdi.Columns["id"].Visible = false;
            this.id_admin = id_admin;
        }

        private void btnAddProdi_Click(object sender, EventArgs e)
        {
            using (addProdi prodiBaru = new addProdi(id_admin))
            {
                addProdi addProdi = new addProdi(id_admin);
                addProdi.ShowDialog();
            }
            dgvFormProdi.DataSource = null;
            dgvFormProdi.DataSource = ProdiContext.all();
            dgvFormProdi.Columns[0].Width = 100;
            dgvFormProdi.Columns[1].Width = 100;
            dgvFormProdi.Columns["prodi"].Width = 300;

            dgvFormProdi.Columns["id"].Visible = false;
        }



        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Hide();
            Validation validation = new Validation(id_admin);
            validation.Show();
        }

        private void btnConvertion_Click(object sender, EventArgs e)
        {
            this.Hide();
            KonversiAdmin konversi = new KonversiAdmin(id_admin);
            konversi.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            this.Close();
            otherMenu otherMenu = new otherMenu(id_admin);
            otherMenu.Show();
        }

        private void dgvFormProdi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFormProdi.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {

                int idProdiHapus = int.Parse(dgvFormProdi.Rows[e.RowIndex].Cells["id"].Value.ToString());

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    try
                    {
                        ProdiContext.destroy(idProdiHapus);
                        DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Data tidak bisa dihapus karena terpakai pada tabel lain !");
                    }

                    dgvFormProdi.DataSource = null;
                    dgvFormProdi.DataSource = ProdiContext.all();
                    dgvFormProdi.Columns[0].Width = 100;
                    dgvFormProdi.Columns[1].Width = 100;
                    dgvFormProdi.Columns["prodi"].Width = 300;

                    dgvFormProdi.Columns["id"].Visible = false;
                }



            }
            if (e.ColumnIndex == dgvFormProdi.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                int idProdiUbah = int.Parse(dgvFormProdi.Rows[e.RowIndex].Cells["id"].Value.ToString());

                using (addProdi editProdi = new addProdi(id_admin, idProdiUbah))
                {
                    addProdi formeditProdi = new addProdi(id_admin, idProdiUbah);
                    formeditProdi.ShowDialog();
                }

                dgvFormProdi.DataSource = null;
                dgvFormProdi.DataSource = ProdiContext.all();
                dgvFormProdi.Columns[0].Width = 100;
                dgvFormProdi.Columns[1].Width = 100;
                dgvFormProdi.Columns["prodi"].Width = 300;

                dgvFormProdi.Columns["id"].Visible = false;

            }

        }
    }
}
