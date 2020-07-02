using FacadePattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FacadePattern
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Applicant applicant = new Applicant() { Name = "Anjani" };
            ApplicationFacade facade = new ApplicationFacade(applicant);
            facade.IsValidationDone();
        }
    }
}