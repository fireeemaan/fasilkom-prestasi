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
        public Bidang()
        {
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


        }

        private void btnAddAchievement_Click(object sender, EventArgs e)
        {
            this.Hide();


            addBidang bidang = new addBidang();
            bidang.Show();



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
                    catch
                    {
                        MessageBox.Show("Bidang yang ingin dihapus sedang dipakai di tabel yang lain");
                    }

                    dgvFormBidang.DataSource = null;
                    dgvFormBidang.DataSource = BidangContext.all();
                }

                
              
            }
            if (e.ColumnIndex == dgvFormBidang.Columns["editButton"].Index && e.RowIndex >= 0)
            {
                int idBidangUbah = int.Parse(dgvFormBidang.Rows[e.RowIndex].Cells["id"].Value.ToString());

                
                using (addBidang editBidang = new addBidang(idBidangUbah))
                {
                    this.Hide();
                    addBidang formEditBidang = new addBidang(idBidangUbah);
                    formEditBidang.Show();
                }
                dgvFormBidang.DataSource = null;
                dgvFormBidang.DataSource = BidangContext.all();

            }
        }
    }
}