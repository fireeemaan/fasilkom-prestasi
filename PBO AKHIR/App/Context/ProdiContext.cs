using fasilkom_prestasi.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Context
{
    internal class ProdiContext : DatabaseWrapper
    {
        private static string table = "prodi";
        public static DataTable all()
        {
            string query = $"SELECT * FROM {table} ORDER BY id ASC";
            DataTable objects = queryExecutor(query);
            return objects;
        }
    }
}
