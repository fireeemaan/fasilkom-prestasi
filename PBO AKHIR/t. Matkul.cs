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
    public partial class Matkul : Form
    {
        long id_admin;
        public Matkul(long idAdmin)
        {
            this.id_admin = idAdmin;
            InitializeComponent();

            // Set Data Admin
            DataTable datauser = AdminContext.show(id_admin);
            lblNamaAdmin.Text = datauser.Rows[0]["nama"].ToString();
            lblNIP.Text = id_admin.ToString();

            dgvMatkul.DataSource = MatkulContext.all();

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

            dgvMatkul.Columns.Insert(0, editButton);
            dgvMatkul.Columns.Insert(1, deleteButton);
            dgvMatkul.Columns[0].Width = 180;
            dgvMatkul.Columns[1].Width = 180;
        }

        private void btnAddMatkul_Click(object sender, EventArgs e)
        {
            using (addMatkul matkul = new addMatkul())
            {
                addMatkul tambahMatkul = new addMatkul();
                tambahMatkul.ShowDialog();
            }

            dgvMatkul.DataSource = null;
            dgvMatkul.DataSource = MatkulContext.all();
            dgvMatkul.Columns[0].Width = 180;
            dgvMatkul.Columns[1].Width = 180;
        }

        private void dgvMatkul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMatkul.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                string kdMatkulUbah = dgvMatkul.Rows[e.RowIndex].Cells["kode"].Value.ToString();

                using (addMatkul matkul = new addMatkul(kdMatkulUbah))
                {
                    addMatkul tambahMatkul = new addMatkul(kdMatkulUbah);
                    tambahMatkul.ShowDialog();
                }

                dgvMatkul.DataSource = null;
                dgvMatkul.DataSource = MatkulContext.all();
                dgvMatkul.Columns[0].Width = 180;
                dgvMatkul.Columns[1].Width = 180;

            }
            if (e.ColumnIndex == dgvMatkul.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {
                string kdMatkulHapus = dgvMatkul.Rows[e.RowIndex].Cells["kode"].Value.ToString();

                try
                {
                    DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        MatkulContext.destroy(kdMatkulHapus);
                        DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                    }

                }
                catch
                {
                    MessageBox.Show("Nilai sedang dipakai di tabel lain!", "Hapus Data Gagal!");
                }


                dgvMatkul.DataSource = null;
                dgvMatkul.DataSource = MatkulContext.all();
                dgvMatkul.Columns[0].Width = 180;
                dgvMatkul.Columns[1].Width = 180;

            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            otherMenu otherMenu = new otherMenu(id_admin);
            otherMenu.Show();
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah anda yakin ingin logout?", "Konfirmasi logout", MessageBoxButtons.YesNo);

            if (message == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
