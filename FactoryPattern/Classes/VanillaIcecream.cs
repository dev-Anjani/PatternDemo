using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryPattern.Classes
{
    public class VanillaIcecream : IIcecream
    {
        public double GetPrice()
        {
            return 40.0;
        }
    }
}