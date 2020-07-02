using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FactoryPattern.Helpers
{
    public class CustomValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value!=null)
            {
                string msg = value.ToString();
                return ValidationResult.Success;
            }

            //ErrorMessage err = ErrorMessage ?? "Field must be validated"; 
            return new ValidationResult("Field must be validated");
        }
    }
}