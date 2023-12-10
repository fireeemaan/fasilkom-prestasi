using fasilkom_prestasi.App.Context;
using fasilkom_prestasi.App.Model;
using fasilkom_prestasi.App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        long id_admin;
        int id_bidang;
        int id_nilai;
        long nim;


        public Form_ConvertionValidation_Admin(string idKonversi, string idPrestasi, long nim, long idAdmin)
        {
            this.id = id;
            this.idKonversi = idKonversi;
            this.nim = nim;
            this.id_admin = idAdmin;
            InitializeComponent();

            // Set Data Admin
            DataTable datauser = AdminContext.show(id_admin);
            lblNamaAdmin.Text = datauser.Rows[0]["nama"].ToString();
            lblNIP.Text = id_admin.ToString();

            DataTable dataKonversiMatkul = KonversiMatkulContext.show(idKonversi);
            dgvMatkulKonversi.DataSource = dataKonversiMatkul;

            dgvMatkulKonversi.Columns["id"].Visible = false;


            DataTable dataPrestasi = PrestasiContext.show(idPrestasi);
            tbxNamaLomba.Text = dataPrestasi.Rows[0]["nama_prestasi"].ToString();


            DataTable dataRegion = RegionContext.all();
            int id_region = int.Parse(dataPrestasi.Rows[0]["id_region"].ToString());
            tbxRegion.Text = dataRegion.Select($"id = {id_region}")[0]["region"].ToString();


            DataTable dataBidang = BidangContext.all();
            id_bidang = int.Parse(dataPrestasi.Rows[0]["id_bidang"].ToString());
            tbxBidang.Text = dataBidang.Select($"id = {id_bidang}")[0]["bidang"].ToString();


            DataTable dataTahapan = TahapanContext.all();
            int id_tahapan = int.Parse(dataPrestasi.Rows[0]["id_tahapan"].ToString());
            tbxTahapan.Text = dataTahapan.Select($"id = {id_tahapan}")[0]["tahapan"].ToString();

            DataTable dataNilai = NilaiContext.getNilai(id_region, id_tahapan);
            id_nilai = int.Parse(dataNilai.Rows[0]["id"].ToString());

            tbxNilai.Text = dataNilai.Rows[0]["nilai"].ToString();

            DataTable dataKonversi = KonversiContext.show(idKonversi);

            tbxJumlahSKS.Text = dataKonversi.Rows[0]["sks_used"].ToString();
            string statusValidasi = dataKonversi.Rows[0]["status"].ToString();
            tbxLinkDok.Text = dataKonversi.Rows[0]["dokumen"].ToString();

            DataTable dataMahasiswa = MahasiswaContext.show(nim);

            tbxNama.Text = dataMahasiswa.Rows[0]["nama"].ToString();

            tbxNIM.Text = dataMahasiswa.Rows[0]["nim"].ToString();



            if (statusValidasi == "Success")
            {
                rbtnAccept.Checked = true;
            }
            else if (statusValidasi == "Rejected")
            {
                rbtnReject.Checked = true;
            }




        }




        private void btnAddConvertion_Click(object sender, EventArgs e)
        {
            string statusValidasi = "Process";


            // Bidang Selected ID
            if (rbtnReject.Checked)
            {
                statusValidasi = "Rejected";
            }
            else if (rbtnAccept.Checked)
            {
                statusValidasi = "Success";
            }

            M_Konversi updateKonversi = new M_Konversi()
            {
                id = idKonversi,
                status = statusValidasi,
                dokumen = tbxLinkDok.Text
            };



            try
            {
                KonversiContext.update(updateKonversi);
                MessageBox.Show("Data Berhasil Diubah");

                this.Close();
                KonversiAdmin konversiAdmin = new KonversiAdmin(id_admin);
                konversiAdmin.Show();
            }
            catch (Exception ex) { }
            {

            }






        }

        private void btnBackConvertion_Click(object sender, EventArgs e)
        {
            this.Hide();
            KonversiAdmin konversi = new KonversiAdmin(id_admin);
            konversi.Show();
        }

        private void dgvMatkulKonversi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvMatkulKonversi.Columns["dokumen"].Index && e.RowIndex >= 0)
            {
                MessageBox.Show("p");

                string link = dgvMatkulKonversi.Rows[e.RowIndex].Cells["dokumen"].Value.ToString();


                try
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = $"{link}",
                        UseShellExecute = true
                    };

                    Process.Start(psInfo);
                }


                catch (Exception ex)
                {
                    try
                    {
                        ProcessStartInfo psInfo = new ProcessStartInfo
                        {
                            FileName = $"https://{link}",
                            UseShellExecute = true
                        };

                        Process.Start(psInfo);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Link tidak valid!");
                    }


                }
            }
        }
    }
}
