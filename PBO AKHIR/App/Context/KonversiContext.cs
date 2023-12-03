using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NpgsqlTypes;
using fasilkom_prestasi.App.Core;
using System.Data;
using Npgsql;
using fasilkom_prestasi.App.Models;

namespace fasilkom_prestasi.App.Context
{
    internal class KonversiContext : DatabaseWrapper
    {
        private static string table = "konversi";

        public static int checkData(string id_prestasi)
        {
            string query = $"SELECT COUNT(*) FROM {table} WHERE id_prestasi = @id_prestasi AND status = 'Invalid'";
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_prestasi", NpgsqlDbType.Varchar) { Value = id_prestasi }
            };
            int rowsCount = queryExecutorInt(query, parameters);
            return rowsCount;
  
        }

        public static DataTable allSelected(long nim)
        {
            string query = $"SELECT {table}.id, prestasi.nama_prestasi, nilai.nilai, {table}.sks_used, {table}.status FROM {table} JOIN prestasi ON {table}.id_prestasi = prestasi.id JOIN nilai ON {table}.id_nilai = nilai.id WHERE nim = @nim";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nim", NpgsqlDbType.Bigint){Value = nim},
            };

            DataTable dataKonversi = queryExecutor(query, parameters);
            return dataKonversi;
        }
        public static DataTable allSelected(long nim, string id_prestasi)
        {
            string query = $"SELECT * FROM {table} WHERE nim = @nim AND id_prestasi = @id_prestasi AND status = 'Invalid'";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nim", NpgsqlDbType.Bigint){Value = nim},
                new NpgsqlParameter("@id_prestasi", NpgsqlDbType.Varchar){Value = id_prestasi}
            };

            DataTable dataKonversi = queryExecutor(query, parameters);
            return dataKonversi;
        }

        public static void updateStatus(M_Konversi konversi)
        {
            string query = $"UPDATE {table} SET status = @status WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter ("@id", NpgsqlDbType.Varchar) {Value = konversi.id},
                new NpgsqlParameter ("@status", NpgsqlDbType.Unknown) {Value = konversi.status},
            };
            commandExecutor(query, parameters);
        }


        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";

            DataTable dataKonversi = queryExecutor(query);
            return dataKonversi;
        }


        public static void store(M_Konversi konversi)
        {
            string query = $"INSERT INTO {table}(id_nilai, id_prestasi, nim) VALUES (@id_nilai, @id_prestasi, @nim)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_nilai", NpgsqlDbType.Integer){Value = konversi.id_nilai},
                new NpgsqlParameter("@id_prestasi", NpgsqlDbType.Varchar){Value = konversi.id_prestasi},
                new NpgsqlParameter("@nim", NpgsqlDbType.Bigint){Value = konversi.nim}
            };
            commandExecutor(query, parameters);
        }

        public static void destroy(long nim)
        {
            string query = $"DELETE FROM {table} WHERE status = @status AND nim = @nim";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@status", NpgsqlDbType.Unknown){Value = "Invalid"},
                new NpgsqlParameter("@nim", NpgsqlDbType.Bigint){Value = nim }

            };
            commandExecutor(query, parameters);
        }

    }
}
