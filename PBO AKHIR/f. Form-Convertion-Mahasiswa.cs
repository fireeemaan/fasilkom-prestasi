using fasilkom_prestasi.App.Context;
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
    public partial class Form_Convertion_Mahasiswa : Form
    {
        long nim;
        string idPrestasi;
        int semester;
        int id_prodi;
        int id_bidang;
        int id_nilai;
        int id_konversi;
        int id_konversi_invalid;



        public Form_Convertion_Mahasiswa(long nim, string idPrestasiKonversi, int idKonversiInvalid)
        {
            this.nim = nim;
            this.idPrestasi = idPrestasiKonversi;
            id_konversi_invalid = idKonversiInvalid;

            InitializeComponent();

            DataTable dataKonversi = KonversiContext.allSelected(nim);

            if (KonversiContext.checkData(idPrestasi) == 1)
            {
                id_konversi = int.Parse(dataKonversi.Rows[0]["id"].ToString());
            }



            dgvKonversiMatkul.DataSource = KonversiMatkulContext.show(id_konversi_invalid);
            dgvKonversiMatkul.Columns["id"].Visible = false;

            DataTable dataMahasiswa = MahasiswaContext.show(nim);

            Console.WriteLine(dataMahasiswa.Rows.Count);

            semester = int.Parse(dataMahasiswa.Rows[0]["semester"].ToString());
            id_prodi = int.Parse(dataMahasiswa.Rows[0]["id_prodi"].ToString());

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

            tbxNilai.Text = dataNilai.Rows[0]["nilai"].ToString();

            // Kuota SKS
            tbxSKS.Text = dataNilai.Rows[0]["max_sks"].ToString();


            // Mata Kuliah


            DataTable dataProdiMatkul = prodiMatkulContext.all(id_prodi, id_bidang, semester);

            List<KeyValuePair<int, string>> matkul = new List<KeyValuePair<int, string>>();

            for (int i = 0; i < dataProdiMatkul.Rows.Count; i++)
            {
                int idProdiMatkul = Convert.ToInt32(dataProdiMatkul.Rows[i]["id"]);
                string namaMatkul = dataProdiMatkul.Rows[i]["matkul"].ToString();

                matkul.Add(new KeyValuePair<int, string>(idProdiMatkul, namaMatkul));

            }


            cbxMatkulPilihan.DataSource = matkul;
            cbxMatkulPilihan.ValueMember = "Key";
            cbxMatkulPilihan.DisplayMember = "Value";

        }

        private void btnBackConvertion_Click(object sender, EventArgs e)
        {

            DataTable dataKonversiMatkul = KonversiMatkulContext.all();

            if (dataKonversiMatkul.Select($"id_konversi = {id_konversi}") == null)
            {
                KonversiContext.destroy(nim);
            }


            this.Close();
            Record record = new Record(nim);
            record.Show();
        }

        private void Form_Convertion_Mahasiswa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnAddMK_Click(object sender, EventArgs e)
        {

            DataTable dataProdiMatkul = prodiMatkulContext.all(id_prodi, id_bidang, semester);

            KeyValuePair<int, string> selectedMatkul = (KeyValuePair<int, string>)cbxMatkulPilihan.SelectedItem;
            string kdMatkul = dataProdiMatkul.Rows[0]["kd_matkul"].ToString();
            int semesterMK = int.Parse(dataProdiMatkul.Rows[0]["semester"].ToString());
            int sksMK = int.Parse(dataProdiMatkul.Rows[0]["sks"].ToString());

            M_KonversiMatkul konversiMatkulBaru = new M_KonversiMatkul
            {
                id_konversi = id_konversi,
                kd_matkul = kdMatkul,
                semester = semesterMK,
                sks = sksMK
            };

            KonversiMatkulContext.store(konversiMatkulBaru);

            dgvKonversiMatkul.DataSource = null;
            dgvKonversiMatkul.DataSource = KonversiMatkulContext.show(id_konversi);
            dgvKonversiMatkul.Columns["id"].Visible = false;

        }
    }
}
