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
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
            sidePanel.Height = btnRecord.Height;

            archiveControl1.Record = this;
            Controls.Add(archiveControl1);

            addAchievementControl1.Record = this;
            Controls.Add(addAchievementControl1);

            object[] bidang = BidangContext.getNames();
            object[] region = RegionContext.getNames();
            object[] tahapan = TahapanContext.getNames();
            object[] dosen = DosenContext.getNames();
            addAchievementControl1.setCombo(bidang, region, tahapan, dosen);
        }

        private void archiveControl1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = PrestasiContext.showAll(1);

            archiveControl1.setDataSource(dataTable);
        }

        private void Record_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnRecord.Height;
            sidePanel.Top = btnRecord.Top;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btnHome.Height;
            sidePanel.Top = btnHome.Top;
        }

        public void BringToFrontArchive()
        {
            archiveControl1.BringToFront();
        }

        public void BringToFrontAddAchievement()
        {
            addAchievementControl1.BringToFront();
        }

    }
}
