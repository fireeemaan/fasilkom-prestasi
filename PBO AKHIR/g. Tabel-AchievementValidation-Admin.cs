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

        }

        public void setDataSource(DataTable dataTable)
        {
            dgvValidation.DataSource = null;
            dgvValidation.DataSource = dataTable;
        }

        private void dgvValidation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
