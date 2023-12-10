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
    public partial class addProdi : Form
    {
        long id_admin;
        int id_prodi;
        public addProdi(long id_admin)
        {

            this.id_admin = id_admin;
            InitializeComponent();
            DataTable dataProdi = ProdiContext.all();
            btnEditProdi.Hide();
            this.id_admin = id_admin;
        }

        public addProdi(long id_admin, int id_prodi)
        {

            this.id_prodi = id_prodi;
            this.id_admin = id_admin;
            InitializeComponent();
            btnAddProdi.Hide();
            DataTable dataProdi = ProdiContext.all();
            DataTable Prodi = ProdiContext.show(id_prodi);
            tbxNamaProdi.Text = dataProdi.Select($"id = {id_prodi}")[0]["prodi"].ToString();
        }




        private void btnAddProdi_Click(object sender, EventArgs e)
        {
            

            try
            {
                var namaProdi = tbxNamaProdi.Text;
                M_Prodi prodiBaru = new M_Prodi
                {

                    prodi = namaProdi
                };
                ProdiContext.store(prodiBaru);
                MessageBox.Show("Data Berhasil Ditambah !");

                this.Close();

            }
            catch
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Input Data Gagal");
            }
        }

        private void btnEditProdi_Click(object sender, EventArgs e)
        {
            
            try
            {
                var namaProdi = tbxNamaProdi.Text;
                M_Prodi prodiBaru = new M_Prodi


                {
                    id = id_prodi,
                    prodi = namaProdi
                };
                ProdiContext.update(prodiBaru);
                MessageBox.Show("Data Berhasil diUbah !");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Data Tidak Boleh Kosong", "Input Data Gagal");
            }
        }
    }
}
