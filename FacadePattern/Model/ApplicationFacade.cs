using FacadePattern.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FacadePattern.Model
{
    public class ApplicationFacade
    {
        private Applicant _applicant;
        private BackgroundValidation _backgroundValidation;
        private FeeValidation _feeValidation;
        private FormValidation _formValidation;

        public ApplicationFacade(Applicant applicant)
        {
            _applicant = applicant;
            _backgroundValidation = new BackgroundValidation(applicant);
            _feeValidation = new FeeValidation(applicant);
            _formValidation = new FormValidation(applicant);
        }
        public bool IsValidationDone()
        {
            bool status = false;
            if (_backgroundValidation.IsBackgroundVerified() &&
                _feeValidation.IsFeeReceived() &&
                _formValidation.IsFormValid())
            {
                status = true;
            }
            return status;
        }

    }
}