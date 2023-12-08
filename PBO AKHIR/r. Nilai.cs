using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fasilkom_prestasi.App.Context;

namespace fasilkom_prestasi
{
    public partial class Nilai : Form
    {
        long id_admin;
        public Nilai(long id_admin)
        {
            this.id_admin = id_admin;
            InitializeComponent();

            dgvNilai.DataSource = NilaiContext.all();

            dgvNilai.Columns["id"].Visible = false;

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

            dgvNilai.Columns.Insert(0, editButton);
            dgvNilai.Columns.Insert(1, deleteButton);
        }

        private void btnAddNilai_Click(object sender, EventArgs e)
        {

        }
    }
}
