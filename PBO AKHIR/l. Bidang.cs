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
    public partial class Bidang : Form
    {
        long id_admin;
        public Bidang(long idAdmin)
        {
            this.id_admin = idAdmin;
            InitializeComponent();

            dgvFormBidang.DataSource = BidangContext.all();

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

            dgvFormBidang.Columns.Insert(0, editButton);
            dgvFormBidang.Columns.Insert(1, deleteButton);
            dgvFormBidang.Columns[0].Width = 200;
            dgvFormBidang.Columns[1].Width = 200;


        }

        private void btnAddAchievement_Click(object sender, EventArgs e)
        {


            using (addBidang tambahBidang = new addBidang(this.id_admin))
            {
                addBidang bidang = new addBidang(this.id_admin);
                bidang.ShowDialog();
            }
            dgvFormBidang.DataSource = null;
            dgvFormBidang.DataSource = BidangContext.all();



        }

        private void dgvFormBidang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvFormBidang.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {

                int idBidangHapus = int.Parse(dgvFormBidang.Rows[e.RowIndex].Cells["id"].Value.ToString());

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    try
                    {
                        BidangContext.destroy(idBidangHapus);
                        DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString()); ;
                    }

                    dgvFormBidang.DataSource = null;
                    dgvFormBidang.DataSource = BidangContext.all();
                }



            }
            if (e.ColumnIndex == dgvFormBidang.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                int idBidangUbah = int.Parse(dgvFormBidang.Rows[e.RowIndex].Cells["id"].Value.ToString());

                using (addBidang editBidang = new addBidang(id_admin, idBidangUbah))
                {
                    addBidang formEditBidang = new addBidang(id_admin, idBidangUbah);
                    formEditBidang.ShowDialog();
                }

                dgvFormBidang.DataSource = null;
                dgvFormBidang.DataSource = BidangContext.all();

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
    }
}