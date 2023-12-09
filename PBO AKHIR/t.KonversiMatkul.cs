using fasilkom_prestasi.App.Context;
using fasilkom_prestasi.App.Models;
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
    public partial class KonversiMatkul : Form
    {
        public KonversiMatkul()
        {
            InitializeComponent();
            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.all();

            DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
            editButton.HeaderText = "";
            editButton.Text = "Edit";
            editButton.Name = "editButton";
            editButton.UseColumnTextForButtonValue = true;


            DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
            deleteButton.HeaderText = "";
            deleteButton.Text = "Delete";
            deleteButton.Name = "deleteButton";
            deleteButton.UseColumnTextForButtonValue = true;

            dgvFormMatkulKonversi.Columns.Insert(0, editButton);
            dgvFormMatkulKonversi.Columns.Insert(1, deleteButton);
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;

            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }



        private void dgvFormMatkulKonversi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddMatkulKonversi_Click(object sender, EventArgs e)
        {
            using (addMatkulKonversi MatkulKonversiBaru = new addMatkulKonversi())
            {
                addMatkulKonversi addMatkulKonversi = new addMatkulKonversi();
                addMatkulKonversi.ShowDialog();
            }
            dgvFormMatkulKonversi.DataSource = null;
            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.all();
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;

            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnSistemInformasi_Click(object sender, EventArgs e)
        {
            dgvFormMatkulKonversi.DataSource = null;

            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.showsorted("Sistem Informasi");
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnTeknologiInformasi_Click(object sender, EventArgs e)
        {
            dgvFormMatkulKonversi.DataSource = null;

            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.showsorted("Teknologi Informasi");
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnInformatika_Click(object sender, EventArgs e)
        {
            dgvFormMatkulKonversi.DataSource = null;

            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.showsorted("Informatika");
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dgvFormMatkulKonversi.DataSource = null;

            dgvFormMatkulKonversi.DataSource = prodiMatkulContext.all();
            dgvFormMatkulKonversi.Columns["matkul"].Width = 300;
            dgvFormMatkulKonversi.Columns[0].Width = 100;
            dgvFormMatkulKonversi.Columns[1].Width = 100;
            dgvFormMatkulKonversi.Columns["id"].Visible = false;
        }
    }
}
