using System;
using System.Data;
using System.Data.SqlClient;

namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=LAPTOP-9VG06RAO;Initial Catalog=DapperExampleDb;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connString);

            string sql = "";

            void CRUD()
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                conn.Execute(sql);
                conn.Close();
            }

        }

        

    }

    

}
