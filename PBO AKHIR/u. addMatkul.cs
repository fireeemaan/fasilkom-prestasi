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
    public partial class addMatkul : Form
    {
        string kd_matkul;
        public addMatkul(string kdMatkul = null)
        {
            this.kd_matkul = kdMatkul;
            InitializeComponent();

            if (kdMatkul == null)
            {
                btnEditMatkul.Hide();
            }
            else
            {
                DataTable dataMatkul = MatkulContext.show(kd_matkul);
                tbxKodeMatkul.Text = dataMatkul.Rows[0]["kode"].ToString();
                tbxNamaMatkul.Text = dataMatkul.Rows[0]["matkul"].ToString();

                btnAddMatkul.Hide();
            }




        }

        private void btnAddMatkul_Click(object sender, EventArgs e)
        {
            var Kode = tbxKodeMatkul.Text;
            var Matkul = tbxNamaMatkul.Text;

            M_Matkul matkulBaru = new M_Matkul()
            {
                kode = Kode,
                matkul = Matkul
            };

            if (tbxKodeMatkul.Text != null && tbxNamaMatkul.Text != null)
            {
                MatkulContext.store(matkulBaru);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Tidak Boleh Kosong!", "Input Data Gagal");
            }

        }

        private void btnEditMatkul_Click(object sender, EventArgs e)
        {
            var Kode = tbxKodeMatkul.Text;
            var Matkul = tbxNamaMatkul.Text;

            M_Matkul matkulBaru = new M_Matkul()
            {
                kode = Kode,
                matkul = Matkul
            };

            if (tbxKodeMatkul.Text != null && tbxNamaMatkul.Text != null)
            {
                MatkulContext.update(matkulBaru, kd_matkul);
                this.Close();
            }
            else
            {
                MessageBox.Show("Data Tidak Boleh Kosong!", "Input Data Gagal");
            }
        }
    }
}
