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
    public partial class Form_Convertion_Mahasiswa : Form
    {
        long nim;
        string idPrestasi;
        int semester;
        int id_prodi;

        public Form_Convertion_Mahasiswa(long nim, string idPrestasiKonversi)
        {
            this.nim = nim;
            this.idPrestasi = idPrestasiKonversi;

            InitializeComponent();

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
            int id_bidang = int.Parse(dataPrestasi.Rows[0]["id_bidang"].ToString());
            tbxBidang.Text = dataBidang.Select($"id = {id_bidang}")[0]["bidang"].ToString();

            // Tahapan
            DataTable dataTahapan = TahapanContext.all();
            int id_tahapan = int.Parse(dataPrestasi.Rows[0]["id_tahapan"].ToString());
            tbxTahapan.Text = dataTahapan.Select($"id = {id_tahapan}")[0]["tahapan"].ToString();

            // Nilai

            DataTable dataNilai = NilaiContext.getNilai(id_region, id_tahapan);
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
            this.Close();
            Record record = new Record(nim);
            record.Show();
        }

        private void Form_Convertion_Mahasiswa_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
