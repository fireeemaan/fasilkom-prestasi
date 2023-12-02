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
    public partial class Validation : Form
    {
        public Validation()
        {
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

                long nimValidasi = Convert.ToInt64(dgvValidation.Rows[e.RowIndex].Cells["nim"].Value);
                int prestasiValidasi = Convert.ToInt32(dgvValidation.Rows[e.RowIndex].Cells["id_prestasi"].Value);

                using (Form_AchievementValidation_Admin validasiPrestasi = new Form_AchievementValidation_Admin(prestasiValidasi,nimValidasi)) 
                {
                    this.Hide();
                    Form_AchievementValidation_Admin formValidasi = new Form_AchievementValidation_Admin(prestasiValidasi, nimValidasi);
                    formValidasi.ShowDialog();
                }
                dgvValidation.DataSource = null;
                dgvValidation.DataSource = PrestasiContext.showAll(2);

                
            }
        }
    }
}
