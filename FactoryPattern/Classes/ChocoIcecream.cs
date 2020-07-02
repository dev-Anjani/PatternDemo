using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryPattern.Classes
{
    public class ChocoIcecream : IIcecream
    {
        public double GetPrice()
        {
            return 50.5;
        }
    }
}