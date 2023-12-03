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
    public partial class KonversiAdmin : Form
    {
        long id_admin;
        string id_prestasi;

        public KonversiAdmin(long id_admin)
        {
            this.id_admin = id_admin;
            InitializeComponent();

            dgvKonversiMatkul.DataSource = KonversiMatkulContext.all();

            DataGridViewButtonColumn validButton = new DataGridViewButtonColumn();
            validButton.HeaderText = "";
            validButton.Text = "Validasi";
            validButton.Name = "validButton";
            validButton.UseColumnTextForButtonValue = true;

            dgvKonversiMatkul.Columns.Insert(0, validButton);
        }

        private void KonversiAdmin_Load(object sender, EventArgs e)
        {

        }


        private void dgvValidation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvKonversiMatkul.Columns["validButton"].Index && e.RowIndex >= 0)
            {

                long konversiValidasi = Convert.ToInt64(dgvKonversiMatkul.Rows[e.RowIndex].Cells["id"].Value.ToString());
                string idkonversiValidasi = dgvKonversiMatkul.Rows[e.RowIndex].Cells["id_konversi"].Value.ToString();
                /*string idAdmin = (dgvValidation.Rows[e.RowIndex].Cells["nama_admin"].Value.ToString());*/


                using (Form_ConvertionValidation_Admin validasiPrestasi = new Form_ConvertionValidation_Admin(idkonversiValidasi, konversiValidasi))
                {
                    this.Hide();
                    Form_ConvertionValidation_Admin formValidasi = new Form_ConvertionValidation_Admin(idkonversiValidasi, konversiValidasi);
                    formValidasi.ShowDialog();
                }
                dgvKonversiMatkul.DataSource = null;
                dgvKonversiMatkul.DataSource = KonversiContext.all();
            }
        }

        private void btnAchievements_Click(object sender, EventArgs e)
        {
            this.Hide();
            Validation validation = new Validation(id_admin);
            validation.ShowDialog();
        }
    }
}
