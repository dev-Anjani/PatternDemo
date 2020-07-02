using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FactoryPattern.Helpers;

namespace FactoryPattern.Models
{
    public class Class1
    {
        [CustomValidation]
        public string Message { get; set; }
    }
}