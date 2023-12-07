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
using fasilkom_prestasi.App.Core;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using fasilkom_prestasi.App.Models;
using fasilkom_prestasi.App.Model;
using Npgsql;

namespace fasilkom_prestasi
{
    public partial class Record : Form
    {
        int userRole;
        long nim;

        string idKonversiInvalid = null;

        public Record(int userRole, long nim)
        {
            this.nim = nim;

            this.userRole = userRole;

            InitializeComponent();

            // Set name & NIM
            DataTable dataUser = MahasiswaContext.show(nim);
            lblNamaMhs.Text = dataUser.Rows[0]["nama"].ToString();
            lblNIM.Text = nim.ToString();

            DataTable dataPrestasi = PrestasiContext.showAll(1, nim);

            dgvPrestasi.DataSource = dataPrestasi;

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


            DataGridViewButtonColumn convertButton = new DataGridViewButtonColumn();
            convertButton.HeaderText = "";
            convertButton.Text = "Convert";
            convertButton.Name = "convertButton";
            convertButton.UseColumnTextForButtonValue = true;

            dgvPrestasi.Columns.Insert(0, editButton);
            dgvPrestasi.Columns.Insert(1, deleteButton);
            dgvPrestasi.Columns.Insert(2, convertButton);

        }

        public Record(long nim)
        {
            this.nim = nim;
            InitializeComponent();

            // Set name & NIM
            DataTable dataUser = MahasiswaContext.show(nim);
            lblNamaMhs.Text = dataUser.Rows[0]["nama"].ToString();
            lblNIM.Text = nim.ToString();

            DataTable dataPrestasi = PrestasiContext.showAll(1, nim);

            dgvPrestasi.DataSource = dataPrestasi;

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


            DataGridViewButtonColumn convertButton = new DataGridViewButtonColumn();
            convertButton.HeaderText = "";
            convertButton.Text = "Convert";
            convertButton.Name = "convertButton";
            convertButton.UseColumnTextForButtonValue = true;

            dgvPrestasi.Columns.Insert(0, editButton);
            dgvPrestasi.Columns.Insert(1, deleteButton);
            dgvPrestasi.Columns.Insert(2, convertButton);
        }



        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAchievement_Click(object sender, EventArgs e)
        {
            this.Hide();


            DataTable dataPrestasi = PrestasiContext.showAll(1, nim);

            using (FormArchiveMahasiswa addAchievement = new FormArchiveMahasiswa(nim))
            {
                FormArchiveMahasiswa addAchievementPage = new FormArchiveMahasiswa(nim);
                addAchievementPage.Show();
            }
            dgvPrestasi.DataSource = null;
            dgvPrestasi.DataSource = PrestasiContext.showAll(1, nim);
        }

        private void Record_Load(object sender, EventArgs e)
        {

        }

        private void dgvPrestasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dataPrestasi = PrestasiContext.showAll(1, nim);

            if (e.ColumnIndex == dgvPrestasi.Columns["deleteButton"].Index && e.RowIndex >= 0)
            {

                string idPrestasiHapus = dgvPrestasi.Rows[e.RowIndex].Cells["id_prestasi"].Value.ToString();

                DialogResult message = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi Hapus", MessageBoxButtons.YesNo);
                if (message == DialogResult.Yes)
                {
                    PrestasiContext.destroy(idPrestasiHapus);

                    dgvPrestasi.DataSource = null;
                    dgvPrestasi.DataSource = PrestasiContext.showAll(1, nim);


                    DialogResult deleteMessage = MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK);

                }



            }

            if (e.ColumnIndex == dgvPrestasi.Columns["editButton"].Index && e.RowIndex >= 0)
            {

                string idPrestasiUbah = dgvPrestasi.Rows[e.RowIndex].Cells["id_prestasi"].Value.ToString();


                using (FormArchiveMahasiswa editPrestasi = new FormArchiveMahasiswa(nim, idPrestasiUbah))
                {
                    this.Hide();
                    FormArchiveMahasiswa formEditPrestasi = new FormArchiveMahasiswa(nim, idPrestasiUbah);
                    formEditPrestasi.Show();

                }
                dgvPrestasi.DataSource = null;
                dgvPrestasi.DataSource = PrestasiContext.showAll(1, nim);
            }

            if (e.ColumnIndex == dgvPrestasi.Columns["convertButton"].Index && e.RowIndex >= 0 && dgvPrestasi.Rows[e.RowIndex].Cells["validated"].Value.ToString() == "Validated")
            {

                string idConvertPrestasi = dgvPrestasi.Rows[e.RowIndex].Cells["id_prestasi"].Value.ToString();


                if (KonversiContext.checkDuplicate(nim, idConvertPrestasi, "Process") > 0)
                {
                    MessageBox.Show("PRESTASI yang sama sedang dalam proses konversi!", "Konversi Gagal!");
                }
                else if (KonversiContext.checkDuplicate(nim, idConvertPrestasi, "Success") > 0)
                {
                    MessageBox.Show("PRESTASI yang sama telah sukses di konversi!", "Konversi Gagal!");
                }
                else
                {
                    DataTable selectedDataPrestasi = PrestasiContext.show(idConvertPrestasi);
                    int idRegion = int.Parse(selectedDataPrestasi.Rows[0]["id_region"].ToString());
                    int idTahapan = int.Parse(selectedDataPrestasi.Rows[0]["id_tahapan"].ToString());

                    DataTable dataNilai = NilaiContext.getNilai(idRegion, idTahapan);
                    int idNilai = int.Parse(dataNilai.Rows[0]["id"].ToString());

                    DataTable dataKonversi = KonversiContext.all();

                    DataTable dataKonversiMatkul = KonversiMatkulContext.all();

                    M_Konversi konversiBaru = new M_Konversi
                    {
                        id_prestasi = idConvertPrestasi,
                        nim = this.nim,
                        id_nilai = idNilai
                    };

                    DataTable dataKonversiSelected = KonversiContext.allSelected(nim);

                    int rowsCountKonversi = KonversiContext.checkData(idConvertPrestasi);


                    if (KonversiContext.checkData(idConvertPrestasi) > 0)
                    {
                        if (KonversiMatkulContext.checkData(idConvertPrestasi) > 0)
                        {
                            DataTable dataKonversiInvalid = KonversiMatkulContext.showData(idConvertPrestasi);

                            string idKonversiInvalid = dataKonversiInvalid.Rows[0]["id"].ToString();
                        }
                    }
                    else
                    {
                        KonversiContext.store(konversiBaru);
                    }


                    this.Hide();
                    Form_Convertion_Mahasiswa formConvertPrestasi = new Form_Convertion_Mahasiswa(nim, idConvertPrestasi, idKonversiInvalid);
                    formConvertPrestasi.Show();

                    dgvPrestasi.DataSource = null;
                    dgvPrestasi.DataSource = PrestasiContext.showAll(1, nim);
                }


                

            }

            else if (e.ColumnIndex == dgvPrestasi.Columns["convertButton"].Index && e.RowIndex >= 0 && dgvPrestasi.Rows[e.RowIndex].Cells["validated"].Value.ToString() != "Validated")
            {
                MessageBox.Show("Prestasi Belum Di VALIDASI! Harap Menunggu Hingga Proses Validasi Selesai.");
            }

            dgvPrestasi.DataSource = null;
            dgvPrestasi.DataSource = PrestasiContext.showAll(1, nim);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeGuide homeGuide = new HomeGuide(1, nim);
            homeGuide.Show();
        }

        private void btnConvertion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Konversi konversi = new Konversi(nim);
            konversi.Show();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {

        }

        private void lblNamaMhs_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

            DialogResult message = MessageBox.Show("Apakah anda yakin ingin logout?", "Konfirmasi logout", MessageBoxButtons.YesNo);

            if (message == DialogResult.Yes)
            {
                this.Close();
                Login login = new Login();
                login.Show();
            }


        }
    }
}
