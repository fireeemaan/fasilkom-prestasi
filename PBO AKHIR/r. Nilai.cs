using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fasilkom_prestasi.App.Context;

namespace fasilkom_prestasi
{
    public partial class Nilai : Form
    {
        long id_admin;
        public Nilai(long id_admin)
        {
            this.id_admin = id_admin;
            InitializeComponent();


            // Set Data Admin
            DataTable datauser = AdminContext.show(id_admin);
            lblNamaAdmin.Text = datauser.Rows[0]["nama"].ToString();
            lblNIP.Text = id_admin.ToString();


            dgvNilai.DataSource = NilaiContext.all();

            dgvNilai.Columns["id"].Visible = false;

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

            dgvNilai.Columns.Insert(0, editButton);
            dgvNilai.Columns.Insert(1, deleteButton);
        }

        private void btnAddNilai_Click(object sender, EventArgs e)
        {
            using (addNilai nilai = new addNilai(id_admin))
            {
                addNilai tambahNilai = new addNilai(id_admin);
                tambahNilai.ShowDialog();
            }
            dgvNilai.DataSource = null;
            dgvNilai.DataSource = NilaiContext.all();
            dgvNilai.Columns["id"].Visible = false;
        }

        private void dgvNilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvNilai.Columns["editButton"].Index && e.RowIndex >= 0)
            {

                int idNilaiUbah = int.Parse(dgvNilai.Rows[e.RowIndex].Cells["id"].Value.ToString());

                using (addNilai nilai = new addNilai(id_admin, idNilaiUbah))
                {
                    addNilai editNilai = new addNilai(id_admin, idNilaiUbah);
                    editNilai.ShowDialog();
                }

                dgvNilai.DataSource = null;
                dgvNilai.DataSource = NilaiContext.all();
                dgvNilai.Columns["id"].Visible = false;
            }
            if (e.ColumnIndex == dgvNilai.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {
                int idNilaiHapus = int.Parse(dgvNilai.Rows[e.RowIndex].Cells["id"].Value.ToString());

                try
                {
                    DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                    if (message == DialogResult.Yes)
                    {
                        NilaiContext.destroy(idNilaiHapus);
                        DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                    }

                }
                catch
                {
                    MessageBox.Show("Nilai sedang dipakai di tabel lain!", "Hapus Data Gagal!");
                }

                dgvNilai.DataSource = null;
                dgvNilai.DataSource = NilaiContext.all();
                dgvNilai.Columns["id"].Visible = false;
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
