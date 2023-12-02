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
    public partial class Form_AchievementValidation_Admin : Form
    {
        long nim;
        string idPrestasi;
        public Form_AchievementValidation_Admin(string idPrestasi, long nim)
        {
            this.nim = nim;
            this.idPrestasi = idPrestasi;
            InitializeComponent();


            // Region
            DataTable dataRegion = RegionContext.all();

            DataTable dataBidang = BidangContext.all();

            // Tahapan
            DataTable dataTahapan = TahapanContext.all();

            // Dosen
            DataTable dataDosen = DosenContext.all();

            DataTable dataPrestasi = PrestasiContext.show(idPrestasi);
            tbxNamaLomba.Text = dataPrestasi.Rows[0]["nama_prestasi"].ToString();

            int id_bidang = int.Parse(dataPrestasi.Rows[0]["id_bidang"].ToString());
            tbxBidang.Text = dataBidang.Select($"id = {id_bidang}")[0]["bidang"].ToString();

            int id_region = int.Parse(dataPrestasi.Rows[0]["id_region"].ToString());
            tbxRegion.Text = dataRegion.Select($"id = {id_region}")[0]["region"].ToString();
        

            int id_tahapan = int.Parse(dataPrestasi.Rows[0]["id_tahapan"].ToString());
            tbxTahapan.Text = dataTahapan.Select($"id = {id_tahapan}")[0]["tahapan"].ToString();

            int id_dosen = int.Parse(dataPrestasi.Rows[0]["id_dosen"].ToString());
            tbxDosen.Text = dataDosen.Select($"id = {id_dosen}")[0]["nama"].ToString();

            string sertfikat = dataPrestasi.Rows[0]["sertifikat"].ToString();
            tbxSertifikat.Text = sertfikat;   

        

           

            
        }
        private void btnSaveValidation_Click(object sender, EventArgs e)
        {

        }


    }
}
