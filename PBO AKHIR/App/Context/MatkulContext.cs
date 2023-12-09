using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;
using fasilkom_prestasi.App.Models;
using Npgsql;
using NpgsqlTypes;

namespace fasilkom_prestasi.App.Context
{

    internal class MatkulContext : DatabaseWrapper
    {
        private static string table = "matkul";

        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";

            DataTable dataMatkul = queryExecutor(query);
            return dataMatkul;
        }

        public static DataTable show(string idMK)
        {
            string query = $"SELECT * FROM {table} WHERE kode = @idMK";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idMK", NpgsqlDbType.Varchar){Value = idMK}
            };

            DataTable dataMatkul = queryExecutor(query, parameters); 
            return dataMatkul;
        }

        public static void update(M_Matkul dataMatkul, string kodeMK)
        {
            string query = $"UPDATE {table} SET kode = @kode, matkul = @matkul WHERE kode = @kodeUbah";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kode", NpgsqlDbType.Varchar) {Value = dataMatkul.kode},
                new NpgsqlParameter("@matkul", NpgsqlDbType.Varchar) {Value = dataMatkul.matkul},
                new NpgsqlParameter("@kodeUbah", NpgsqlDbType.Varchar) {Value = kodeMK}
            };

            commandExecutor(query, parameters);
        }

        public static void store(M_Matkul dataMatkul)
        {
            string query = $"INSERT INTO {table}(kode, matkul) VALUES(@kode, @matkul)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@kode", NpgsqlDbType.Varchar) {Value = dataMatkul.kode},
                new NpgsqlParameter("@matkul", NpgsqlDbType.Varchar) {Value = dataMatkul.matkul}
            };
            commandExecutor(query , parameters);
        }

        public static void destroy(string kodeMK)
        {
            string query = $"DELETE FROM {table} WHERE kode = @idHapus";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@idHapus", NpgsqlDbType.Varchar) {Value = kodeMK}
            };
            commandExecutor(query, parameters);
        }


        
    }
}
