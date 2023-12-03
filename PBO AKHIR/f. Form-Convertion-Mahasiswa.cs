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
        string id_konversi;
        string id_konversi_invalid;


        int sks_mk;
        int totalSKS;
        int maxKonversiSKS;



        public Form_Convertion_Mahasiswa(long nim, string idPrestasiKonversi, string idKonversiInvalid)
        {
            this.nim = nim;
            this.idPrestasi = idPrestasiKonversi;
            id_konversi_invalid = idKonversiInvalid;

            InitializeComponent();


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.Name = "deleteButton";
            deleteButton.UseColumnTextForButtonValue = true;
            dgvKonversiMatkul.Columns.Insert(0, deleteButton);


            DataTable dataKonversi = KonversiContext.allSelected(nim, idPrestasi);





            if (KonversiContext.checkData(idPrestasi) == 1)
            {
                id_konversi = dataKonversi.Rows[0]["id"].ToString();
            }


            dgvKonversiMatkul.DataSource = null;
            DataTable dataKonversiMatkul = KonversiMatkulContext.show(id_konversi);
            dgvKonversiMatkul.DataSource = dataKonversiMatkul;



            dgvKonversiMatkul.Columns["id"].Visible = false;

            DataTable dataMahasiswa = MahasiswaContext.show(nim);

            //Console.WriteLine(dataMahasiswa.Rows.Count);

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

            maxKonversiSKS = int.Parse(dataNilai.Rows[0]["max_sks"].ToString());

            List<int> sksList = new List<int>();


            foreach (DataRow row in dataKonversiMatkul.Rows)
            {
                sksList.Add(int.Parse(row["sks"].ToString()));
            }

            this.totalSKS = sksList.Sum();

            maxKonversiSKS -= totalSKS;


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

            try
            {
                if (dataKonversiMatkul.Select($"id_konversi = {id_konversi}") == null)
                {

                }
            }
            catch (Exception ex)
            {
                try
                {
                    KonversiContext.destroy(nim);
                }
                catch (Exception ex2)
                {

                }



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
            dgvKonversiMatkul.Columns["id"].Visible = false;



            KeyValuePair<int, string> selectedMatkul = (KeyValuePair<int, string>)cbxMatkulPilihan.SelectedItem;
            string namaMatkul = selectedMatkul.Value.ToString();

            DataTable dataProdiMatkul = prodiMatkulContext.all(id_prodi, id_bidang, semester, namaMatkul);

            string kdMatkul = dataProdiMatkul.Rows[0]["kd_matkul"].ToString();
            int semesterMK = int.Parse(dataProdiMatkul.Rows[0]["semester"].ToString());
            int sksMK = int.Parse(dataProdiMatkul.Rows[0]["sks"].ToString());
            sks_mk = sksMK;

            M_KonversiMatkul konversiMatkulBaru = new M_KonversiMatkul
            {
                id_konversi = id_konversi,
                kd_matkul = kdMatkul,
                semester = semesterMK,
                sks = sksMK
            };

            DataTable dataKonversiMatkul = KonversiMatkulContext.show(id_konversi);

            List<string> mkList = new List<string>();
            foreach (DataRow row in dataKonversiMatkul.Rows)
            {
                mkList.Add(row["kode_matkul"].ToString());
            }


            if (maxKonversiSKS > sksMK)
            {
                if (mkList.Contains(kdMatkul))
                {
                    MessageBox.Show("Mata kuliah sudah di pilih!");
                }
                else
                {
                    maxKonversiSKS -= sksMK;
                    KonversiMatkulContext.store(konversiMatkulBaru);
                }

            }
            else
            {
                MessageBox.Show("SKS mata kuliah melebihi maksimum konversi!");
            }



            dgvKonversiMatkul.DataSource = null;
            dgvKonversiMatkul.DataSource = KonversiMatkulContext.show(id_konversi);
            dgvKonversiMatkul.Columns["id"].Visible = false;

        }

        private void btnAddConvertion_Click(object sender, EventArgs e)
        {

            DataTable dataKonversiMatkul = KonversiMatkulContext.show(id_konversi);
            List<int> sksList = new List<int>();

            foreach (DataRow row in dataKonversiMatkul.Rows)
            {
                sksList.Add(int.Parse(row["sks"].ToString()));
            }

            this.totalSKS = sksList.Sum();

            M_Konversi updateStatus = new M_Konversi
            {
                id = id_konversi,
                status = "Process",
                sks_used = totalSKS
            };

            KonversiContext.updateStatus(updateStatus);

            this.Close();
            Konversi konversi = new Konversi(nim);
            konversi.Show();

        }

        private void dgvKonversiMatkul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKonversiMatkul.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {

                int idKonversiMatkulHapus = int.Parse(dgvKonversiMatkul.Rows[e.RowIndex].Cells["id"].Value.ToString());

                KonversiMatkulContext.destroy(idKonversiMatkulHapus);

                maxKonversiSKS += sks_mk;

                dgvKonversiMatkul.DataSource = null;
                dgvKonversiMatkul.DataSource = KonversiMatkulContext.show(id_konversi);
                dgvKonversiMatkul.Columns["id"].Visible = false;
            }
        }
    }
}
