using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;

namespace fasilkom_prestasi.App.Context
{

    internal class MatkulContext : DatabaseWrapper
    {
        private static string table = "matkul";

        public static DataTable all(int id_prodi, int id_bidang)
        {
            string query = $"SELECT * FROM {table} WHERE ";
        }
    }
}
