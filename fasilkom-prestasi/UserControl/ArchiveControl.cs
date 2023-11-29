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
    public partial class ArchiveControl : UserControl
    {
        

        public ArchiveControl()
        {
            InitializeComponent();
        }

        private Record record;

        public Record Record
        {
            get { return record; }
            set { record = value; }
        }

        public void setDataSource(DataTable dataTable)
        {
            dgvPrestasi.DataSource = dataTable;
        }

        private void btnAddAchievement_Click(object sender, EventArgs e)
        {
            record.BringToFrontAddAchievement();
        }
    }
}
