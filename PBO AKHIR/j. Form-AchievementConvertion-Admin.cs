using fasilkom_prestasi.App.Context;
using fasilkom_prestasi.App.Model;
using fasilkom_prestasi.App.Models;
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
    public partial class Form_ConvertionValidation_Admin : Form
    {
        long id;
        string idKonversi;
        public Form_ConvertionValidation_Admin(string idKonversi, long id)
        {
            this.id = id;
            this.idKonversi = idKonversi;
            InitializeComponent();

            // Prestasi
            DataTable dataPrestasi = PrestasiContext.show(idPrestasi);
            tbxNamaLomba.Text = dataPrestasi.Rows[0]["nama_prestasi"].ToString();

            //Region
            DataTable dataRegion = RegionContext.all();
            int id_region = int.Parse(dataPrestasi.Rows[0]["id_region"].ToString());
            tbxRegion.Text = dataRegion.Select($"id = {id_region}")[0]["region"].ToString();

            // Bidang
            DataTable dataBidang = BidangContext.all();
            id_bidang = int.Parse(dataPrestasi.Rows[0]["id_bidang"].ToString());
            tbxBidang.Text = dataBidang.Select($"id = {id_bidang}")[0]["bidang"].ToString();

            // Tahapan
            DataTable dataTahapan = TahapanContext.all();
            int id_tahapan = int.Parse(dataPrestasi.Rows[0]["id_tahapan"].ToString());
            tbxTahapan.Text = dataTahapan.Select($"id = {id_tahapan}")[0]["tahapan"].ToString();

            // Nilai

            DataTable dataNilai = NilaiContext.getNilai(id_region, id_tahapan);
            id_nilai = int.Parse(dataNilai.Rows[0]["id"].ToString());


        }




        private void btnAddConvertion_Click(object sender, EventArgs e)
        {
            string statusValidasi = "Process";


            // Bidang Selected ID
            if (rbtnInvalid.Checked)
            {
                statusValidasi = "Validated";
            }
            else if (rbtnInvalid.Checked)
            {
                statusValidasi = "Invalid";
            }
        }
    }
}
