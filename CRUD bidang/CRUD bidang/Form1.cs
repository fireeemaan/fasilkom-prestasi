using System.Data;

namespace CRUD_bidang
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable dbBidang = Context.all();
            List<string> dataBidang = new List<string>();
            for (int i = 0; i < dbBidang.Rows.Count; i++)
            {
                string namaBidang = dbBidang.Rows[i]["bidang"].ToString();

                dataBidang.Add(namaBidang);
            }
            cbx_bidang.DataSource = dataBidang;
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            string bidang = cbx_bidang.Text;
            int id_bidang = (int)Context.show(bidang).Rows[0]["id"];
            //selanjutnya mengirim ke tabel prestasi
        }
    }
}