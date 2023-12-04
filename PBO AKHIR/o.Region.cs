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
        public Region()
        {
            InitializeComponent();

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
        }



        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            this.Hide();


            addRegion region = new addRegion();
            region.Show();
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
                }
                if (e.ColumnIndex == dgvFormRegion.Columns["editButton"].Index && e.RowIndex >= 0)
                {
                    int idRegionUbah = int.Parse(dgvFormRegion.Rows[e.RowIndex].Cells["id"].Value.ToString());


                    using (addRegion editRegion = new addRegion(idRegionUbah))
                    {
                        this.Hide();
                        addRegion formEditRegion = new addRegion(idRegionUbah);
                        formEditRegion.Show();
                    }
                    dgvFormRegion.DataSource = null;
                    dgvFormRegion.DataSource = RegionContext.all();

                }



            }
        }
    }
}
