using FacadePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacadePattern.Validations
{
    public class FormValidation
    {
        private Applicant _applicant;
        public FormValidation(Applicant applicant)
        {
            _applicant = applicant;
        }
        public bool IsFormValid()
        {
            return true;
        }
    }
}