using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HRMApplication.Models
{
    public class JoiningDateValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime _birthDate = Convert.ToDateTime(value);
            DateTime minDate = Convert.ToDateTime("01/01/2021");
            DateTime maxDate = Convert.ToDateTime("01/01/2022");

            if (_birthDate > minDate && _birthDate < maxDate)
                return ValidationResult.Success;
            else
                return new ValidationResult(ErrorMessage);
        }
    }
}