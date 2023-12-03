using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;
using NpgsqlTypes;
using fasilkom_prestasi.App.Models;

namespace fasilkom_prestasi.App.Context
{
    internal class KonversiMatkulContext : DatabaseWrapper
    {
        private static string table = "\"konversiMatkul\"";


        public static DataTable all()
        {
            string query = $"SELECT * FROM {table}";
            DataTable dataKonversiMatkul = queryExecutor(query);

            return dataKonversiMatkul;
        }
        public static DataTable show(int id_konversi)
        {
            string query = $"SELECT {table}.id as ID, {table}.kd_matkul as \"Kode Matkul\", matkul.matkul FROM {table} JOIN matkul ON {table}.kd_matkul = matkul.kode WHERE id_konversi = @id_konversi";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_konversi", NpgsqlDbType.Integer) {Value = id_konversi}
            };

            DataTable dataKonversi = queryExecutor(query, parameters);
            return dataKonversi;

        }
        public static DataTable showData(string id_prestasi)
        {
            string query = $"SELECT * FROM {table} JOIN konversi on {table}.id_konversi = konversi.id WHERE konversi.id_prestasi = @id_prestasi AND konversi.status = 'Invalid'";

            NpgsqlParameter[] parameters =
            {
                    new NpgsqlParameter("@id_prestasi", NpgsqlDbType.Varchar) { Value = id_prestasi }
            };

            DataTable result = queryExecutor(query, parameters);
            return result;

        }


        public static int checkData(string id_prestasi)
        {
            string query = $"SELECT COUNT(*) FROM {table} JOIN konversi ON {table}.id_konversi = konversi.id WHERE konversi.id_prestasi = @id_prestasi AND konversi.status = 'Invalid'";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_prestasi", NpgsqlDbType.Varchar) { Value = id_prestasi }
            };

            int rowsCount = queryExecutorInt(query, parameters);
            return rowsCount;
        }


        public static void store(M_KonversiMatkul konversiMatkul)
        {
            string query = $"INSERT INTO {table}(id_konversi, kd_matkul, sks, semester) VALUES(@id_konversi, @kd_matkul, @sks, @semester)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id_konversi", NpgsqlDbType.Integer) {Value = konversiMatkul.id_konversi },
                new NpgsqlParameter("@kd_matkul", NpgsqlDbType.Varchar){Value = konversiMatkul.kd_matkul },
                new NpgsqlParameter("@sks", NpgsqlDbType.Integer){Value = konversiMatkul.sks},
                new NpgsqlParameter("@semester", NpgsqlDbType.Integer){Value = konversiMatkul.semester}
            };

            commandExecutor(query, parameters);
        }

    }
}
