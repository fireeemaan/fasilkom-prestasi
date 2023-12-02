using fasilkom_prestasi.App.Context;
using fasilkom_prestasi.App.Model;
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
    public partial class FormArchiveMahasiswa : Form
    {
        long nim;
        string idPrestasi;
        public FormArchiveMahasiswa(long nim, string idPrestasi = null)
        {
            this.idPrestasi = idPrestasi;
            this.nim = nim;


            InitializeComponent();

            if (idPrestasi != null)
            {
                this.idPrestasi = idPrestasi;
                btnAddAchievement.Hide();
                btnEditAchievement.Show();
            }
            else if (idPrestasi == null)
            {
                btnEditAchievement.Hide();
                btnAddAchievement.Show();
            }

            // Bidang
            DataTable dataBidang = BidangContext.all();

            List<KeyValuePair<int, string>> bidang = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dataBidang.Rows.Count; i++)
            {
                int idBidang = Convert.ToInt32(dataBidang.Rows[i]["id"]);
                string namaBidang = dataBidang.Rows[i]["bidang"].ToString();

                bidang.Add(new KeyValuePair<int, string>(idBidang, namaBidang));

            }
            cbxBidang.DataSource = bidang;
            cbxBidang.ValueMember = "Key";
            cbxBidang.DisplayMember = "Value";


            // Region
            DataTable dataRegion = RegionContext.all();

            List<KeyValuePair<int, string>> region = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dataRegion.Rows.Count; i++)
            {
                int idRegion = Convert.ToInt32(dataRegion.Rows[i]["id"]);
                string namaRegion = dataRegion.Rows[i]["region"].ToString();

                region.Add(new KeyValuePair<int, string>(idRegion, namaRegion));

            }
            cbxRegion.DataSource = region;
            cbxRegion.ValueMember = "Key";
            cbxRegion.DisplayMember = "Value";


            // Tahapan
            DataTable dataTahapan = TahapanContext.all();

            List<KeyValuePair<int, string>> tahapan = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dataTahapan.Rows.Count; i++)
            {
                int idTahapan = Convert.ToInt32(dataTahapan.Rows[i]["id"]);
                string namaTahapan = dataTahapan.Rows[i]["tahapan"].ToString();

                tahapan.Add(new KeyValuePair<int, string>(idTahapan, namaTahapan));

            }
            cbxTahapan.DataSource = tahapan;
            cbxTahapan.ValueMember = "Key";
            cbxTahapan.DisplayMember = "Value";


            // Dosen
            DataTable dataDosen = DosenContext.all();

            List<KeyValuePair<int, string>> dosen = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dataDosen.Rows.Count; i++)
            {
                int idDosen = Convert.ToInt32(dataDosen.Rows[i]["id"]);
                string namaDosen = dataDosen.Rows[i]["nama"].ToString();

                dosen.Add(new KeyValuePair<int, string>(idDosen, namaDosen));

            }
            cbxDosen.DataSource = dosen;
            cbxDosen.ValueMember = "Key";
            cbxDosen.DisplayMember = "Value";


            if (idPrestasi != null)
            {
                this.idPrestasi = idPrestasi;

                DataTable dataPrestasi = PrestasiContext.show(idPrestasi);
                tbxNamaLomba.Text = dataPrestasi.Rows[0]["nama_prestasi"].ToString();
                tbxSertifikat.Text = dataPrestasi.Rows[0]["sertifikat"].ToString();

                cbxBidang.SelectedValue = int.Parse(dataPrestasi.Rows[0]["id_bidang"].ToString());
                cbxRegion.SelectedValue = int.Parse(dataPrestasi.Rows[0]["id_region"].ToString());
                cbxTahapan.SelectedValue = int.Parse(dataPrestasi.Rows[0]["id_tahapan"].ToString());
                cbxDosen.SelectedValue = int.Parse(dataPrestasi.Rows[0]["id_dosen"].ToString());

            }
            else if (idPrestasi == null)
            {
                cbxBidang.SelectedIndex = -1;
                cbxRegion.SelectedIndex = -1;
                cbxTahapan.SelectedIndex = -1;
                cbxDosen.SelectedIndex = -1;
            }
        }



        private void btnAddAchievement_Click(object sender, EventArgs e)
        {
            var namaPrestasi = tbxNamaLomba.Text;
            var nim = 222410101000;
            var sertifikat = tbxSertifikat.Text;


            // Bidang Selected ID
            KeyValuePair<int, string> selectedBidang = (KeyValuePair<int, string>)cbxBidang.SelectedItem;
            var idBidang = selectedBidang.Key;
            // Region Selected ID
            KeyValuePair<int, string> selectedRegion = (KeyValuePair<int, string>)cbxRegion.SelectedItem;
            var idRegion = selectedRegion.Key;
            // Tahapan Selected ID
            KeyValuePair<int, string> selectedTahapan = (KeyValuePair<int, string>)cbxTahapan.SelectedItem;
            var idTahapan = selectedTahapan.Key;
            // Dosen Selected ID
            KeyValuePair<int, string> selectedDosen = (KeyValuePair<int, string>)cbxDosen.SelectedItem;
            var idDosen = selectedDosen.Key;

            M_Prestasi prestasiBaru = new M_Prestasi
            {
                nama_prestasi = namaPrestasi,
                id_mahasiswa = nim,
                sertifikat = sertifikat,
                id_bidang = idBidang,
                id_region = idRegion,
                id_tahapan = idTahapan,
                id_dosen = idDosen

            };

            try
            {
                PrestasiContext.store(prestasiBaru);
                MessageBox.Show("Data Berhasil Ditambahkan!");

                this.Close();
                Record record = new Record(nim);
                record.Show();
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

        private void btnBackAchievement_Click(object sender, EventArgs e)
        {
            this.Close();
            Record record = new Record(nim);
            record.Show();
        }

        private void btnEditAchievement_Click(object sender, EventArgs e)
        {
            var namaPrestasi = tbxNamaLomba.Text;
            var sertifikat = tbxSertifikat.Text;


            // Bidang Selected ID
            KeyValuePair<int, string> selectedBidang = (KeyValuePair<int, string>)cbxBidang.SelectedItem;
            var idBidang = selectedBidang.Key;
            // Region Selected ID
            KeyValuePair<int, string> selectedRegion = (KeyValuePair<int, string>)cbxRegion.SelectedItem;
            var idRegion = selectedRegion.Key;
            // Tahapan Selected ID
            KeyValuePair<int, string> selectedTahapan = (KeyValuePair<int, string>)cbxTahapan.SelectedItem;
            var idTahapan = selectedTahapan.Key;
            // Dosen Selected ID
            KeyValuePair<int, string> selectedDosen = (KeyValuePair<int, string>)cbxDosen.SelectedItem;
            var idDosen = selectedDosen.Key;

            M_Prestasi prestasiBaru = new M_Prestasi
            {
                id = idPrestasi,
                nama_prestasi = namaPrestasi,
                sertifikat = sertifikat,
                id_bidang = idBidang,
                id_region = idRegion,
                id_tahapan = idTahapan,
                id_dosen = idDosen
            };

            try
            {
                PrestasiContext.update(prestasiBaru);
                MessageBox.Show("Data Berhasil Diubah");

                this.Close();
                Record record = new Record(nim);
                record.Show();
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

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeGuide homeGuide = new HomeGuide(1, nim);
            homeGuide.ShowDialog();
        }
    }
}
