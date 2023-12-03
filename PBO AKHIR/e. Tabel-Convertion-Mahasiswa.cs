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

            DataTable dataKonversi = KonversiContext.allSelected(nim);
            dgvKonversi.DataSource = dataKonversi;

            dgvKonversi.Columns["id"].Visible = false;


        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            this.Hide();
            Record record = new Record(nim);
            record.ShowDialog();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeGuide homeGuide = new HomeGuide(1, nim);
            homeGuide.ShowDialog();
        }
    }
}
