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
    public partial class HomeGuide : Form
    {
        long nim;
        int userRole;

        public HomeGuide(int userRole, long nim)
        {
            InitializeComponent();
            this.nim = nim;
            this.userRole = userRole;
        }

        private void HomeGuide_Load(object sender, EventArgs e)
        {

        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            this.Hide();

            Record record = new Record(userRole, nim);
            record.Show();
        }
    }
}
