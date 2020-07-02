using FacadePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacadePattern.Validations
{
    public class BackgroundValidation
    {
        private Applicant _applicant;
        public BackgroundValidation(Applicant applicant)
        {
            _applicant = applicant;
        }

        public bool IsBackgroundVerified()
        {
            return true;
        }
    }
}