using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;

namespace fasilkom_prestasi.App.Context
{
    internal class BidangContext : DatabaseWrapper
    {
        private static string table = "bidang";

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
                objects.Add(row["bidang"].ToString());
            }
            return objects.ToArray();
        }
        public static string getNames(int id)
        {
            string objects;

            string query = $"SELECT * FROM {table} WHERE id = {id}";
            DataTable dataTable = queryExecutor(query);


            return dataTable.Rows[0][$"{table}"].ToString();
        }
    }
}
