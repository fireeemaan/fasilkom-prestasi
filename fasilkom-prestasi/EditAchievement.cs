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
    public partial class EditAchievement : Form
    {
        int idPrestasi;
        public EditAchievement(int id)
        {
            this.idPrestasi = id;

            InitializeComponent();

            DataTable dataPrestasi = PrestasiContext.show(id);
            tbxNamaLomba.Text = dataPrestasi.Rows[0]["nama_prestasi"].ToString();
            tbxSertifikat.Text = dataPrestasi.Rows[0]["sertifikat"].ToString();

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





        }
    }
}
