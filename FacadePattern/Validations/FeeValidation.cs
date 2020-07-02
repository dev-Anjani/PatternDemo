using FacadePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacadePattern.Validations
{
    public class FeeValidation
    {
        private Applicant _applicant;
        public FeeValidation(Applicant applicant)
        {
            _applicant = applicant;
        }

        public bool IsFeeReceived()
        {
            return true;
        }
    }
}