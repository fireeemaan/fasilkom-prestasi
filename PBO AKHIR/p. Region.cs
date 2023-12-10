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
    public partial class Region : Form
    {
        long id_admin;
        public Region(long idAdmin)
        {
            this.id_admin = idAdmin;
            InitializeComponent();

            // Set Data Admin
            DataTable datauser = AdminContext.show(id_admin);
            lblNamaAdmin.Text = datauser.Rows[0]["nama"].ToString();
            lblNIP.Text = id_admin.ToString();

            dgvFormRegion.DataSource = RegionContext.all();


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

            dgvFormRegion.Columns.Insert(0, editButton);
            dgvFormRegion.Columns.Insert(1, deleteButton);
            dgvFormRegion.Columns[0].Width = 100;
            dgvFormRegion.Columns[1].Width = 100;

            dgvFormRegion.Columns["region"].Width = 300;

            dgvFormRegion.Columns["id"].Visible = false;

        }



        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            using (addRegion addRegion = new addRegion(id_admin))
            {
                addRegion region = new addRegion(id_admin);
                region.ShowDialog();
            }
            dgvFormRegion.DataSource = null;
            dgvFormRegion.DataSource = RegionContext.all();
            dgvFormRegion.Columns[0].Width = 100;
            dgvFormRegion.Columns[1].Width = 100;

            dgvFormRegion.Columns["region"].Width = 300;

            dgvFormRegion.Columns["id"].Visible = false;

        }

        private void dgvFormRegion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFormRegion.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {

                int idRegionHapus = int.Parse(dgvFormRegion.Rows[e.RowIndex].Cells["id"].Value.ToString());

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    try
                    {
                        RegionContext.destroy(idRegionHapus);
                        DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }

                    dgvFormRegion.DataSource = null;
                    dgvFormRegion.DataSource = RegionContext.all();
                    dgvFormRegion.Columns[0].Width = 100;
                    dgvFormRegion.Columns[1].Width = 100;

                    dgvFormRegion.Columns["region"].Width = 300;

                    dgvFormRegion.Columns["id"].Visible = false;
                }
                if (e.ColumnIndex == dgvFormRegion.Columns["editButton"].Index && e.RowIndex >= 0)
                {
                    int idRegionUbah = int.Parse(dgvFormRegion.Rows[e.RowIndex].Cells["id"].Value.ToString());

                    using (addRegion editRegion = new addRegion(id_admin, idRegionUbah))
                    {
                        addRegion formEditRegion = new addRegion(id_admin, idRegionUbah);
                        formEditRegion.ShowDialog();
                    }


                    dgvFormRegion.DataSource = null;
                    dgvFormRegion.DataSource = RegionContext.all();
                    dgvFormRegion.Columns[0].Width = 100;
                    dgvFormRegion.Columns[1].Width = 100;

                    dgvFormRegion.Columns["region"].Width = 300;

                    dgvFormRegion.Columns["id"].Visible = false;

                }



            }
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
