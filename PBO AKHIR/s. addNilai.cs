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
    public partial class addNilai : Form
    {
        long id_admin;
        int id_nilai;
        public addNilai(long idAdmin, int idNilai = 0)
        {
            this.id_admin = idAdmin;
            this.id_nilai = idNilai;
            InitializeComponent();


            if (id_nilai == 0)
            {
                cbtnStatus.Checked = true;
                cbtnStatus.AllowUncheck = false;
                btnEditNilai.Hide();
            }
            else
            {
                btnAddNilai.Hide();
            }


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


            if (id_nilai == 0)
            {
                cbxRegion.SelectedIndex = -1;
                cbxTahapan.SelectedIndex = -1;
            }
            else
            {
                DataTable dataNilai = NilaiContext.show(id_nilai);

                cbxNilai.SelectedItem = dataNilai.Rows[0]["nilai"].ToString();
                cbxRegion.SelectedValue = Convert.ToInt32(dataNilai.Rows[0]["id_region"].ToString());
                cbxTahapan.SelectedValue = Convert.ToInt32(dataNilai.Rows[0]["id_tahapan"].ToString());
                tbxMinSKS.Text = dataNilai.Rows[0]["min_sks"].ToString();
                tbxMaxSKS.Text = dataNilai.Rows[0]["max_sks"].ToString();
                cbtnStatus.Checked = Convert.ToBoolean(dataNilai.Rows[0]["isValid"]);
            }


        }


        private void tbxMinSKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbxMaxSKS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAddNilai_Click(object sender, EventArgs e)
        {
            var Nilai = cbxNilai.SelectedItem.ToString();
            var minSKS = Convert.ToInt32(tbxMinSKS.Text);
            var maxSKS = Convert.ToInt32(tbxMaxSKS.Text);
            bool IsValid = cbtnStatus.Checked;

            try
            {
                // Region Selected ID
                KeyValuePair<int, string> selectedRegion = (KeyValuePair<int, string>)cbxRegion.SelectedItem;
                var idRegion = selectedRegion.Key;
                // Tahapan Selected ID
                KeyValuePair<int, string> selectedTahapan = (KeyValuePair<int, string>)cbxTahapan.SelectedItem;
                var idTahapan = selectedTahapan.Key;

                M_Nilai nilaiBaru = new M_Nilai()
                {
                    nilai = Nilai,
                    min_sks = minSKS,
                    max_sks = maxSKS,
                    isValid = IsValid,
                    id_region = idRegion,
                    id_tahapan = idTahapan,
                };

                if (NilaiContext.checkDuplicate(nilaiBaru) > 0)
                {
                    MessageBox.Show("Terdapat NILAI dengan REGION dan TAHAPAN yang sama sedang aktif!", "Input Nilai Gagal!");
                }
                else
                {
                    NilaiContext.store(nilaiBaru);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Data Tidak Boleh Kosong!");
            }


        }

        private void btnEditNilai_Click(object sender, EventArgs e)
        {
            var Nilai = cbxNilai.SelectedItem.ToString();
            var minSKS = Convert.ToInt32(tbxMinSKS.Text);
            var maxSKS = Convert.ToInt32(tbxMaxSKS.Text);
            bool IsValid = cbtnStatus.Checked;


            // Region Selected ID
            KeyValuePair<int, string> selectedRegion = (KeyValuePair<int, string>)cbxRegion.SelectedItem;
            var idRegion = selectedRegion.Key;
            // Tahapan Selected ID
            KeyValuePair<int, string> selectedTahapan = (KeyValuePair<int, string>)cbxTahapan.SelectedItem;
            var idTahapan = selectedTahapan.Key;

            M_Nilai nilaiBaru = new M_Nilai()
            {
                id = id_nilai,
                nilai = Nilai,
                min_sks = minSKS,
                max_sks = maxSKS,
                isValid = IsValid,
                id_region = idRegion,
                id_tahapan = idTahapan,
            };

            if (NilaiContext.checkDuplicate(nilaiBaru) > 0)
            {
                if (cbtnStatus.Checked)
                {
                    MessageBox.Show("Terdapat NILAI dengan REGION dan TAHAPAN yang sama sedang aktif!", "Input Nilai Gagal!");
                }
                else if (!cbtnStatus.Checked)
                {
                    NilaiContext.update(nilaiBaru);
                    this.Close();
                }
            }
            else
            {
                NilaiContext.update(nilaiBaru);
                this.Close();
            }
        }
    }
}
