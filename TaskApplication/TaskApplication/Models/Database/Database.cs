using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TaskApplication.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }
        public Admins Admins { get; set; }

        public Database()
        {
            string connString = @"Server=(LocalDB)\MSSQLLocalDB;Database=UMS;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);

            Admins = new Admins(conn);
        }
    }
}