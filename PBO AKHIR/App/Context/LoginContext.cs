using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fasilkom_prestasi.App.Core;
using Npgsql;
using NpgsqlTypes;

namespace fasilkom_prestasi.App.Context
{
    internal class LoginContext : DatabaseWrapper
    {
        private static string table = "credentials";

        public static DataTable show(long username)
        {
            string query = $"SELECT * FROM {table} WHERE username = @username";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@username", NpgsqlDbType.Bigint) { Value = username }

            };
            DataTable dataCredentials = queryExecutor(query, parameters);
            return dataCredentials;
        }

        public static long login(long username, string password)
        {
            try
            {
                
                string query = $"SELECT COUNT(*) FROM {table} WHERE username =:username AND password =:password";
                NpgsqlParameter[] parameters =
                {
                    new NpgsqlParameter("username",NpgsqlDbType.Bigint){Value=username},
                    new NpgsqlParameter("password",NpgsqlDbType.Varchar){Value=password}
                };

                return commandExecutor2(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show( "EROR : "+ ex);
                return 0;
            }

        }
    }
}
