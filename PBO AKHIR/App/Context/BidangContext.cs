using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;
using fasilkom_prestasi.App.Model;
using fasilkom_prestasi.App.Models;
using Npgsql;
using NpgsqlTypes;

namespace fasilkom_prestasi.App.Context
{
    internal class BidangContext : DatabaseWrapper
    {
        private static string table = "bidang";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table} ORDER BY id ASC";
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

        public static void store(M_Bidang bidangBaru)
        {
            string query = $"INSERT INTO {table}(bidang) VALUES(@bidang)";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@bidang", NpgsqlDbType.Varchar){Value = bidangBaru.bidang},

            };

            commandExecutor(query, parameters);
        }

        public static void destroy(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id sort by {table}.id ASC";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) {Value = id},
            };

            commandExecutor(query, parameters);
        }

        public static DataTable show(int id)
        {
            string query = $"SELECT * FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
            };
            DataTable dataBidang = queryExecutor(query, parameters);
            return dataBidang;

        }

        public static void update(M_Bidang bidangEdit)
        {
            string query = $"UPDATE {table} SET bidang = @bidang WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer){Value = bidangEdit.id },
                new NpgsqlParameter("@bidang", NpgsqlDbType.Varchar) { Value = bidangEdit.bidang }

            };
            commandExecutor(query, parameters);
        }   
        
    }
}
