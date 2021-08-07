using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TaskApplication.Models;

namespace TaskApplication.Models.Database
{
    public class Admins
    {
        SqlConnection conn;

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }

        public Admin Check(Admin a)
        {
            Admin admin = null;
            string query = "select * from Admins Where Username = @Username and Password = @Password";
            SqlCommand cmd = new SqlCommand(query, conn);
            
            cmd.Parameters.AddWithValue("@Username", a.Username);
            cmd.Parameters.AddWithValue("@Password", a.Password);
            conn.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                admin = new Admin()
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Username = reader.GetString(reader.GetOrdinal("Username")),
                    Password = reader.GetString(reader.GetOrdinal("Password"))
                };
            }
          
            conn.Close();
            return admin;
        }


    }
}

       
