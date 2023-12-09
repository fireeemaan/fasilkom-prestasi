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
    public partial class addMatkulKonversi : Form
    {
        int id_matkulKonversi;
        public addMatkulKonversi(int idMatkulKonversi = 0)
        {
            this.id_matkulKonversi = idMatkulKonversi;
            InitializeComponent();


            if (idMatkulKonversi == 0)
            {
                btnEditMatkulKonversi.Hide();
            }
            else
            {
                btnAddMatkulKonversi.Hide();
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


            DataTable dataProdi = ProdiContext.all();

            List<KeyValuePair<int, string>> prodi = new List<KeyValuePair<int, string>>();
            for (int i = 0; i < dataProdi.Rows.Count; i++)
            {
                int idProdi = Convert.ToInt32(dataProdi.Rows[i]["id"]);
                string namaProdi = dataProdi.Rows[i]["prodi"].ToString();

                prodi.Add(new KeyValuePair<int, string>(idProdi, namaProdi));

            }
            cbxProdi.DataSource = prodi;
            cbxProdi.ValueMember = "Key";
            cbxProdi.DisplayMember = "Value";

            DataTable dataMatkul = MatkulContext.all();

            List<KeyValuePair<string, string>> matkul = new List<KeyValuePair<string, string>>();
            for (int i = 0; i < dataMatkul.Rows.Count; i++)
            {
                string idMatkul = dataMatkul.Rows[i]["kode"].ToString();
                string namaMatkul = dataMatkul.Rows[i]["matkul"].ToString();

                matkul.Add(new KeyValuePair<string, string>(idMatkul, namaMatkul));

            }
            cbxMatkul.DataSource = matkul;
            cbxMatkul.ValueMember = "Key";
            cbxMatkul.DisplayMember = "Value";

            if (idMatkulKonversi == 0)
            {
                btnEditMatkulKonversi.Hide();
                cbxBidang.SelectedIndex = -1;
                cbxProdi.SelectedIndex = -1;
                cbxMatkul.SelectedIndex = -1;
            }
            else
            {
                DataTable dataMatkulKonversi = prodiMatkulContext.show(id_matkulKonversi);
                cbxBidang.SelectedValue = int.Parse(dataMatkulKonversi.Rows[0]["id_bidang"].ToString());
                cbxProdi.SelectedValue = int.Parse(dataMatkulKonversi.Rows[0]["id_prodi"].ToString());
                cbxMatkul.SelectedValue = dataMatkulKonversi.Rows[0]["kd_matkul"].ToString();
                tbxSemester.Text = dataMatkulKonversi.Rows[0]["semester"].ToString();
                tbxSKS.Text = dataMatkulKonversi.Rows[0]["sks"].ToString();


                btnAddMatkulKonversi.Hide();
            }

        }

        private void btnaddKonversiMatkul_Click(object sender, EventArgs e)
        {


            try
            {
                KeyValuePair<int, string> selectedBidang = (KeyValuePair<int, string>)cbxBidang.SelectedItem;
                var idBidang = selectedBidang.Key;
                KeyValuePair<int, string> selectedProdi = (KeyValuePair<int, string>)cbxProdi.SelectedItem;
                var idProdi = selectedProdi.Key;
                KeyValuePair<string, string> selectedMatkul = (KeyValuePair<string, string>)cbxMatkul.SelectedItem;
                var kdMatkul = selectedMatkul.Key;
                var Semester = int.Parse(tbxSemester.Text);
                var SKS = int.Parse(tbxSKS.Text);

                M_prodiMatkul konversiMatkulbaru = new M_prodiMatkul
                {
                    id_bidang = idBidang,
                    id_prodi = idProdi,
                    kd_matkul = kdMatkul,
                    semester = Semester,
                    sks = SKS
                };
                prodiMatkulContext.store(konversiMatkulbaru);
                MessageBox.Show("Data Berhasil Ditambah !");

                this.Close();

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Data Tidak Boleh Kosong!", "Input Data Gagal!");
            }
        }

        private void btnEditMatkulKonversi_Click(object sender, EventArgs e)
        {


            try
            {
                KeyValuePair<int, string> selectedBidang = (KeyValuePair<int, string>)cbxBidang.SelectedItem;
                var idBidang = selectedBidang.Key;
                KeyValuePair<int, string> selectedProdi = (KeyValuePair<int, string>)cbxProdi.SelectedItem;
                var idProdi = selectedProdi.Key;
                KeyValuePair<string, string> selectedMatkul = (KeyValuePair<string, string>)cbxMatkul.SelectedItem;
                var kdMatkul = selectedMatkul.Key;
                var Semester = int.Parse(tbxSemester.Text);
                var SKS = int.Parse(tbxSKS.Text);

                M_prodiMatkul konversiMatkulbaru = new M_prodiMatkul
                {
                    id = id_matkulKonversi,
                    id_bidang = idBidang,
                    id_prodi = idProdi,
                    kd_matkul = kdMatkul,
                    semester = Semester,
                    sks = SKS
                };
                prodiMatkulContext.update(konversiMatkulbaru);
                MessageBox.Show("Data Berhasil Diubah !");

                this.Close();

            }
            catch
            {
                MessageBox.Show("Data Tidak Boleh Kosong!", "Input Data Gagal!");
            }

        }
    }
}
