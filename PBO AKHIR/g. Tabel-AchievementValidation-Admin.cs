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
using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace fasilkom_prestasi
{
    public partial class Validation : Form
    {

        long id_admin;
        public Validation(long id_admin)
        {
            this.id_admin = id_admin;
            InitializeComponent();
            dgvValidation.DataSource = PrestasiContext.showAll(2);


            DataGridViewButtonColumn validButton = new DataGridViewButtonColumn();
            validButton.HeaderText = "";
            validButton.Text = "Validasi";
            validButton.Name = "validButton";
            validButton.UseColumnTextForButtonValue = true;




            dgvValidation.Columns.Insert(0, validButton);

        }

        public void setDataSource(DataTable dataTable)
        {
            dgvValidation.DataSource = null;
            dgvValidation.DataSource = dataTable;
        }

        private void dgvValidation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvValidation.Columns["validButton"].Index && e.RowIndex >= 0)
            {

                long nimValidasi = Convert.ToInt64(dgvValidation.Rows[e.RowIndex].Cells["nim"].Value.ToString());
                string prestasiValidasi = dgvValidation.Rows[e.RowIndex].Cells["id_prestasi"].Value.ToString();
                /*string idAdmin = (dgvValidation.Rows[e.RowIndex].Cells["nama_admin"].Value.ToString());*/


                using (Form_AchievementValidation_Admin validasiPrestasi = new Form_AchievementValidation_Admin(prestasiValidasi, nimValidasi, id_admin))
                {
                    this.Hide();
                    Form_AchievementValidation_Admin formValidasi = new Form_AchievementValidation_Admin(prestasiValidasi, nimValidasi, id_admin);
                    formValidasi.Show();
                }
                dgvValidation.DataSource = null;
                dgvValidation.DataSource = PrestasiContext.showAll(2);


            }





        }

        private void dgvValidation_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvValidation.Columns["surat_tugas"].Index && e.RowIndex >= 0)
            {


                string link = dgvValidation.Rows[e.RowIndex].Cells["surat_tugas"].Value.ToString();


                try
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = $"{link}",
                        UseShellExecute = true
                    };

                    Process.Start(psInfo);
                }


                catch (Exception ex)
                {
                    try
                    {
                        ProcessStartInfo psInfo = new ProcessStartInfo
                        {
                            FileName = $"https://{link}",
                            UseShellExecute = true
                        };

                        Process.Start(psInfo);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Link tidak valid!");
                    }


                }
            }
            if (e.ColumnIndex == dgvValidation.Columns["sertifikat"].Index && e.RowIndex >= 0)
            {


                string link = dgvValidation.Rows[e.RowIndex].Cells["sertifikat"].Value.ToString();


                try
                {
                    ProcessStartInfo psInfo = new ProcessStartInfo
                    {
                        FileName = $"{link}",
                        UseShellExecute = true
                    };

                    Process.Start(psInfo);
                }


                catch (Exception ex)
                {
                    try
                    {
                        ProcessStartInfo psInfo = new ProcessStartInfo
                        {
                            FileName = $"https://{link}",
                            UseShellExecute = true
                        };

                        Process.Start(psInfo);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Link tidak valid!");
                    }


                }
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnValidShow_Click(object sender, EventArgs e)
        {

            dgvValidation.DataSource = null;

            dgvValidation.DataSource = PrestasiContext.showsorted("Valid");



        }

        private void btnInvalidShow_Click(object sender, EventArgs e)
        {
            dgvValidation.DataSource = null;

            dgvValidation.DataSource = PrestasiContext.showsorted("Invalid");
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {

            dgvValidation.DataSource = null;

            dgvValidation.DataSource = PrestasiContext.showAll(2);
        }

        private void btnConvertion_Click(object sender, EventArgs e)
        {
            this.Close();
            KonversiAdmin konversi = new KonversiAdmin(id_admin);
            konversi.Show();
        }
    }
}
