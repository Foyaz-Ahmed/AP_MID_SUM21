//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRMApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class Company
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Company()
        {
            this.Employees = new HashSet<Employee>();
        }
    
        public int ID { get; set; }

        [Required]
        [Remote(action: "isCompanyNameValidaiton", controller:"Company", ErrorMessage= "Company Name already exists")]
        [RegularExpression(@"^[a-zA-Z\s\.]+$", ErrorMessage = "Please Enter Valid Company Name")]
        public string C_Name { get; set; }

        [Required]
        [Remote(action: "isCompanyUrlValidaiton", controller: "Company", ErrorMessage = "Company Url already exists")]
        [Url]
        public string Url { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
