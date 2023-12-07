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
    public partial class otherMenu : Form
    {
        long id_admin;
        public otherMenu(long id_admin)
        {
            this.id_admin = id_admin;
            InitializeComponent();
        }

        private void btnBidang_Click(object sender, EventArgs e)
        {
            this.Close();
            Bidang bidang = new Bidang(id_admin);
            bidang.Show();
        }

        private void btnConvertion_Click(object sender, EventArgs e)
        {
            this.Hide();
            KonversiAdmin konversi = new KonversiAdmin(id_admin);
            konversi.Show();
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Hide();
            Validation validation = new Validation(id_admin);
            validation.Show();
        }

        private void btnRegion_Click(object sender, EventArgs e)
        {
            this.Close();
            Region region = new Region(id_admin);
            region.Show();
        }

        private void btnTahapan_Click(object sender, EventArgs e)
        {
            this.Close();
            Tahapan tahapan = new Tahapan(id_admin);
            tahapan.Show();
        }
    }
}
