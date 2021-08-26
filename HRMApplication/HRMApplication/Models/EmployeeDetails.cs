using Microsoft.Office.Interop.Excel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HRMApplication.Models
{
    public class EmployeeDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime JoiningDate { get; set; }
        public IList<EmployeeDetails> details { get; set; }


    }
}