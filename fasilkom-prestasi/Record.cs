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
using Krypton.Toolkit;

namespace fasilkom_prestasi
{
    public partial class Record : Form
    {
        public Record()
        {
            InitializeComponent();
            sidePanel.Height = btnRecord.Height;

            DataTable dataTable = PrestasiContext.showAll(2);
            dgvPrestasi.DataSource = dataTable;


            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "Edit";
            editButton.Text = "Edit";
            editButton.Name = "editButton";
            editButton.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.Name = "deleteButton";
            deleteButton.UseColumnTextForButtonValue = true;

            dgvPrestasi.Columns.Add(editButton);
            dgvPrestasi.Columns.Add(deleteButton);



        }

        private void archiveControl1_Load(object sender, EventArgs e)
        {
            DataTable dataTable = PrestasiContext.showAll(1);

        }

        private void Record_Load(object sender, EventArgs e)
        {
            DataTable dataTable = PrestasiContext.showAll(1);
            dgvPrestasi.DataSource = null;
            dgvPrestasi.DataSource = dataTable;
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

        private void btnAddAchievement_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (AddAchievement addAchievement = new AddAchievement())
            {
                AddAchievement addAchievementPage = new AddAchievement();
                addAchievementPage.ShowDialog();
            }
            dgvPrestasi.DataSource = null;
            dgvPrestasi.DataSource = PrestasiContext.showAll(1);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
