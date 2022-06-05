using DapperEssay;
using System;
using System.Collections.Generic;
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

            void CRUD(DynamicParameters dynamic=null)
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                conn.Execute(sql,dynamic,commandType:CommandType.Text);
                conn.Close();
            }

            IEnumerable<User> users = new List<User>();

            users = conn.Query<User>("Select * from [User]");

            foreach (var item in users)
            {
                Console.WriteLine(item.Name);
            }

        }

        

    }

    

}
