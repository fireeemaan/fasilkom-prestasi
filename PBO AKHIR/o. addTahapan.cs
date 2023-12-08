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
    public partial class addTahapan : Form
    {
        int id_tahapan;
        long id_admin;
        public addTahapan(long id_admin)
        {
            this.id_admin = id_admin;
            InitializeComponent();
            DataTable dataTahapan = TahapanContext.all();
            btnEditTahapan.Hide();
            this.id_admin = id_admin;
        }

        public addTahapan(long id_admin, int id_tahapan)
        {
            this.id_tahapan = id_tahapan;
            this.id_admin = id_admin;
            InitializeComponent();
            btnAddTahapan.Hide();
            DataTable dataTahapan = TahapanContext.all();
            DataTable Tahapan = TahapanContext.show(id_tahapan);
            tbxNamaTahapan.Text = dataTahapan.Select($"id = {id_tahapan}")[0]["tahapan"].ToString();
        }

        private void btnAddTahapan_Click(object sender, EventArgs e)
        {
            var namaTahapan = tbxNamaTahapan.Text;
            M_Tahapan tahapanBaru = new M_Tahapan
            {

                tahapan = namaTahapan
            };

            try
            {
                TahapanContext.store(tahapanBaru);
                MessageBox.Show("Data Berhasil Ditambah !");

                this.Close();
                Tahapan tahapan = new Tahapan(id_admin);
                tahapan.Show();
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

        private void btnEditTahapan_Click(object sender, EventArgs e)
        {
            var namaTahapan = tbxNamaTahapan.Text;
            M_Tahapan tahapanBaru = new M_Tahapan


            {
                id = id_tahapan,
                tahapan = namaTahapan
            };
            try
            {
                TahapanContext.update(tahapanBaru);
                MessageBox.Show("Data Berhasil diUbah !");
                this.Close();
                Tahapan tahapan = new Tahapan(id_admin);
                tahapan.Show();
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
