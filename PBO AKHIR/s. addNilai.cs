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
    public partial class addNilai : Form
    {
        long id_admin;
        int id_nilai;
        public addNilai()
        {
            //this.id_admin = idAdmin;
            InitializeComponent();

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
            cbxRegion.SelectedIndex = -1;

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
            cbxTahapan.SelectedIndex = -1;

        }

        public addNilai(long idAdmin, int idNilai)
        {
            this.id_admin = idAdmin;
            this.id_nilai = idNilai;
            InitializeComponent();
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
    }
}
