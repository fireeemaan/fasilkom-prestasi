using fasilkom_prestasi.App.Context;
using fasilkom_prestasi.App.Models;
using Npgsql;
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
    public partial class addRegion : Form
    {
        int id_region;
        public addRegion()
        {
            InitializeComponent();

            DataTable dataBidang = RegionContext.all();
            btnEditRegion.Hide();
        }

        public addRegion(int id_region)
        {
            this.id_region = id_region;


            InitializeComponent();
            btnAddRegion.Hide();
            DataTable dataRegiong = RegionContext.all();
            DataTable Region = RegionContext.show(id_region);
            tbxNamaRegion.Text = dataRegiong.Select($"id = {id_region}")[0]["region"].ToString();

        }

        

        private void btnEditRegion_Click(object sender, EventArgs e)
        {

            var namaRegion = tbxNamaRegion.Text;

            M_Region regionBaru = new M_Region
            {
                region = namaRegion
            };

            try
            {
                RegionContext.store(regionBaru);
                MessageBox.Show("Data Berhasil Ditambah !");

                this.Close();
                Region region = new Region();
                region.Show();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error! : {ex}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! : {ex}");
            }
        }

        private void btnAddRegion_Click(object sender, EventArgs e)
        {
            var namaRegion = tbxNamaRegion.Text;
            M_Region regionBaru = new M_Region
            {
                region = namaRegion
            };

            try
            {
                RegionContext.store(regionBaru);
                MessageBox.Show("Data Berhasil Ditambah !");

                this.Close();
                Region region = new Region();
                region.Show();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error! : {ex}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error! : {ex}");
            }
        }
    }
}
