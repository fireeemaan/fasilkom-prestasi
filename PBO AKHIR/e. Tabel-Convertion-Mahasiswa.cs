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
    public partial class Konversi : Form
    {
        long nim;

        public Konversi(long nim)
        {
            this.nim = nim;
            InitializeComponent();

            // Set name & NIM
            DataTable dataUser = MahasiswaContext.show(nim);
            lblNamaMhs.Text = dataUser.Rows[0]["nama"].ToString();
            lblNIM.Text = nim.ToString();



            DataGridViewButtonColumn detailButton = new DataGridViewButtonColumn();
            detailButton.HeaderText = "";
            detailButton.Text = "Detail";
            detailButton.Name = "detailButton";
            detailButton.UseColumnTextForButtonValue = true;

            dgvKonversi.Columns.Insert(0, detailButton);


            DataTable dataKonversi = KonversiContext.allSelected(nim);
            dgvKonversi.DataSource = dataKonversi;

            dgvKonversi.Columns["id"].Visible = false;


        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            this.Hide();
            Record record = new Record(nim);
            record.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeGuide homeGuide = new HomeGuide(1, nim);
            homeGuide.Show();
        }

        private void dgvKonversi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKonversi.Columns["detailButton"].Index && e.RowIndex >= 0)
            {
                DataTable dataKonversi = KonversiContext.allSelected(nim);



                string idKonversiDetail = dgvKonversi.Rows[e.RowIndex].Cells["id"].Value.ToString();
                DataTable dataPrestasi = PrestasiContext.showPrestasiKonversi(idKonversiDetail);

                string idPrestasi = dataPrestasi.Rows[0]["id"].ToString();


                this.Hide();
                Form_Convertion_Mahasiswa formKonversiMhs = new Form_Convertion_Mahasiswa(nim, idPrestasi, idKonversiDetail);
                formKonversiMhs.Show();




            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("Apakah anda yakin ingin logout?", "Konfirmasi logout", MessageBoxButtons.YesNo);

            if (message == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
