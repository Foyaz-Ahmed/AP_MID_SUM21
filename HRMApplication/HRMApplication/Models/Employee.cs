namespace HRMApplication.Models
{
    using DataAnnotationMVC.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Employee
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z\s\.]+$", ErrorMessage = "Please Enter Valid Name")]
        [StringLength(20, ErrorMessage = "Name length can't be more than 20.")]
        public string Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email")]
        [Remote(action: "isCompanyEmailValidaiton", controller: "Employee", ErrorMessage = "Email already exists")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please Enter Valid Email")]
        public string Email { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        [Range(21, 30, ErrorMessage = "Age must be from 21 to 30 years")]
        public int Age { get; set; }

        [Required]
        [Range(15000, 100000, ErrorMessage = "Salary must be from 15000 to 100000 years")]
        public double Salary { get; set; }

        [Required(ErrorMessage = "Please Select Joining Date")]
        [DataType(DataType.Date, ErrorMessage = "Joining Date should be in dd/mm/yyyy format")]
        [JoiningDateValidation(ErrorMessage = "Joining date Should be this year")]
        public System.DateTime JoiningDate { get; set; }



        [Required(ErrorMessage = "Date of birth required")]
        [DataType(DataType.Date, ErrorMessage = "Date of birth should be in dd/mm/yyyy format")]
        //[DataType(DataType.Date)]
        [ValidateBirthDate(ErrorMessage = "DOB Should be between 01-01-1991 & 01-01-1999")]
        public System.DateTime DOB { get; set; }

        [Required]
        [Range(1, 50000, ErrorMessage = "Department ID must be from 1 to 50000")]
        public int Dept_ID { get; set; }


        [Required]
        [Range(1, 50000, ErrorMessage = "Company ID must be from 1 to 50000")]
        public int Comp_ID { get; set; }

        [Required]
        [Range(1, 50000, ErrorMessage = "Designation ID Required")]
        public int Desig_ID { get; set; }


        [Required]
        [RegularExpression(@"^([A-Za-z]+)$", ErrorMessage = "Please Enter Valid Status")]
        public string Status { get; set; }

        public virtual Company Company { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
    }
}
