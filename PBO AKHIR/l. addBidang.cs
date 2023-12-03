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
        public addBidang()
        {


            InitializeComponent();
            DataTable dataBidang = BidangContext.all();
            btnEditBidang.Hide();

        }
        public addBidang(int id_bidang)
        {
            this.id_bidang = id_bidang;


            InitializeComponent();
            btnAddBidang.Hide();
            DataTable dataBidang = BidangContext.all();
            DataTable Bidang = BidangContext.show(id_bidang);
            tbxNamaBidang.Text = dataBidang.Select($"id = {id_bidang}")[0]["bidang"].ToString();

        }



        private void btnAddBidang_Click(object sender, EventArgs e)
        {
            var namaBidang = tbxNamaBidang.Text;
            M_Bidang bidangBaru = new M_Bidang
            {

                bidang = namaBidang
            };

            try
            {
                BidangContext.store(bidangBaru);
                MessageBox.Show("Data Berhasil Ditambah !");

                this.Close();
                Bidang bidang = new Bidang();
                bidang.Show();
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

        private void btnEditBidang_Click(object sender, EventArgs e)
        {
            var idBidang = tbxNamaBidang.Text;

            M_Bidang bidangBaru = new M_Bidang


            {
                id = id_bidang,
                bidang = idBidang
            };
            try
            {
                BidangContext.update(bidangBaru);
                this.Close();
                Bidang bidang = new Bidang();
                bidang.Show();
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
