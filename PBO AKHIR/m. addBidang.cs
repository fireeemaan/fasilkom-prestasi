using fasilkom_prestasi.App.Context;
using fasilkom_prestasi.App.Model;
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

    public partial class addBidang : Form
    {

        int id_bidang;
        long id_admin;


        public addBidang(long id_admin)
        {
            this.id_admin = id_admin;

            InitializeComponent();
            DataTable dataBidang = BidangContext.all();
            btnEditBidang.Hide();

        }
        public addBidang(long id_admin, int id_bidang)
        {
            this.id_bidang = id_bidang;
            this.id_admin = id_admin;

            InitializeComponent();
            btnAddBidang.Hide();
            DataTable dataBidang = BidangContext.all();
            DataTable Bidang = BidangContext.show(id_bidang);
            tbxNamaBidang.Text = dataBidang.Select($"id = {id_bidang}")[0]["bidang"].ToString();

        }



        private void btnAddBidang_Click(object sender, EventArgs e)
        {


            try
            {
                var namaBidang = tbxNamaBidang.Text;
                M_Bidang bidangBaru = new M_Bidang
                {

                    bidang = namaBidang
                };
                BidangContext.store(bidangBaru);
                MessageBox.Show("Data Berhasil Ditambah !");

                this.Close();
                //Bidang bidang = new Bidang(id_admin);
                //bidang.Show();
            }
            catch
            {
                MessageBox.Show("Data Tidak Boleh Kosong!");
            }
        }

        private void btnEditBidang_Click(object sender, EventArgs e)
        {
            var namaBidang = tbxNamaBidang.Text;

            M_Bidang bidangBaru = new M_Bidang


            {
                id = id_bidang,
                bidang = namaBidang
            };
            try
            {
                BidangContext.update(bidangBaru);
                MessageBox.Show("Data Berhasil diUbah !");
                this.Close();
                //Bidang bidang = new Bidang(id_admin);
                //bidang.Show();
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
