using fasilkom_prestasi.App.Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fasilkom_prestasi.App.Context
{
    internal class TahapanContext : DatabaseWrapper
    {
        private static string table = "tahapan";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable objects = queryExecutor(query);
            return objects;
        }

        public static object[] getNames()
        {
            List<string> objects = new List<string>();

            string query = $"SELECT * FROM {table}";
            DataTable dataTable = queryExecutor(query);

            foreach (DataRow row in dataTable.Rows)
            {
                objects.Add(row[$"{table}"].ToString());
            }
            return objects.ToArray();
        }
    }
}
