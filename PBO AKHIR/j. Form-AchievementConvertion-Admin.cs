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
    public partial class Form_ConvertionValidation_Admin : Form
    {
        long id;
        long id_admin;
        string idKonversi;
        public Form_ConvertionValidation_Admin(string idKonversi,long id, long id_admin)
        {
            this.id = id;
            this.id_admin = id_admin;
            this.idKonversi = idKonversi;
            InitializeComponent();


        }
    }
}
