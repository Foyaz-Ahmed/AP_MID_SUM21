using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TaskApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please put your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please put your Date of Birth")]
        public string Dob { get; set; }
        [Required(ErrorMessage = "Please put your  Credit")]
        public int Credit { get; set; }
        [Required(ErrorMessage = "Please put your CGPA")]
        public double CGPA { get; set; }
        [Required(ErrorMessage = "Please put your Department Id")]
        public int Dept_id { get; set; }
        
    }
}