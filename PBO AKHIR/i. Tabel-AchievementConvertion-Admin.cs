using fasilkom_prestasi.App.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fasilkom_prestasi
{
    public partial class KonversiAdmin : Form
    {
        long id_admin;
        string id_prestasi;

        public KonversiAdmin(long id_admin)
        {
            this.id_admin = id_admin;
            InitializeComponent();

            dgvKonversi.DataSource = KonversiContext.all();

            DataGridViewButtonColumn validButton = new DataGridViewButtonColumn();
            validButton.HeaderText = "";
            validButton.Text = "Validasi";
            validButton.Name = "validButton";
            validButton.UseColumnTextForButtonValue = true;

            dgvKonversi.Columns.Insert(0, validButton);
        }

        private void KonversiAdmin_Load(object sender, EventArgs e)
        {

        }



        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Hide();
            Validation validation = new Validation(id_admin);
            validation.Show();
        }

        private void dgvKonversi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKonversi.Columns["validButton"].Index && e.RowIndex >= 0)
            {

                string idKonversi = dgvKonversi.Rows[e.RowIndex].Cells["id"].Value.ToString();
                string idPrestasi = dgvKonversi.Rows[e.RowIndex].Cells["id_prestasi"].Value.ToString();
                long nim = Convert.ToInt64(dgvKonversi.Rows[e.RowIndex].Cells["nim"].Value.ToString());


                /*string idAdmin = (dgvValidation.Rows[e.RowIndex].Cells["nama_admin"].Value.ToString());*/



                this.Hide();
                Form_ConvertionValidation_Admin formValidasi = new Form_ConvertionValidation_Admin(idKonversi, idPrestasi, nim);
                formValidasi.Show();

                dgvKonversi.DataSource = null;
                dgvKonversi.DataSource = KonversiContext.all();
            }
        }

        private void dgvKonversi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKonversi.Columns["dokumen"].Index && e.RowIndex >= 0)
            {


                string link = dgvKonversi.Rows[e.RowIndex].Cells["dokumen"].Value.ToString();


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
    }
}
