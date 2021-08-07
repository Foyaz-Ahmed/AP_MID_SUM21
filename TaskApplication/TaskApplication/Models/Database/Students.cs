using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TaskApplication.Models;


namespace TaskApplication.Models.Database
{
    public class Students
    {
        SqlConnection conn;
        

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student s)
        {
            
            string query = "Insert into Students values(@name,@dob,@credit,@cgpa,@dept_id)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", s.Name);
            cmd.Parameters.AddWithValue("@dob", s.Dob);
            cmd.Parameters.AddWithValue("@credit", s.Credit);
            cmd.Parameters.AddWithValue("@cgpa", s.CGPA);
            cmd.Parameters.AddWithValue("dept_id", s.Dept_id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
       
        }
        public List<Student> GetAll()
        {
            List<Student> students = new List<Student>(); 
            string query = "select * from Students";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            { 
                
                Student s= new Student() 
                {
                    
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetString(reader.GetOrdinal("Dob")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),
                    
                    
                    
                };
                students.Add(s);
            }
            conn.Close();
            return students;
        }

        public Student Get(int id)
        {
            Student s = null;
            string query = $"select * from Students Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                s = new Student()
                {

                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Dob = reader.GetString(reader.GetOrdinal("Dob")),
                    Credit = reader.GetInt32(reader.GetOrdinal("Credit")),
                    CGPA = reader.GetDouble(reader.GetOrdinal("CGPA")),
                    Dept_id = reader.GetInt32(reader.GetOrdinal("Dept_id")),

                };
            }
            conn.Close();
            return s;
        }
        public void Update(Student s)
        {
            string query = $"Update Students Set Name ='{s.Name}',Dob = '{s.Dob}', Credit = '{s.Credit}', CGPA = '{s.CGPA}', Dept_id = '{s.Dept_id}' where Id = {s.Id} ";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
       
        public void delete(int id)
        {
            string query = $"DELETE FROM Students Where Id={id}";
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}