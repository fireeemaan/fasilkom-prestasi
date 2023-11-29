using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fasilkom_prestasi.App.Context;

namespace fasilkom_prestasi
{
    public partial class AddAchievementControl : UserControl
    {
        public AddAchievementControl()
        {
            InitializeComponent();
        }

        private Record record;

        public Record Record
        {
            get { return record; }
            set { record = value; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setCombo(object[] cbx1, object[] cbx2, object[] cbx3, object[] cbx4)
        {
            cbxBidang.Items.AddRange(cbx1);
            cbxRegion.Items.AddRange(cbx2);
            cbxTahapan.Items.AddRange(cbx3);
            cbxDosen.Items.AddRange(cbx4);
        }

        private void btnBackAchievement_Click(object sender, EventArgs e)
        {
            record.BringToFrontArchive();
        }
    }
}
