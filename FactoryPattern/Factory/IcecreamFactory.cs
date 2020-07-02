using FactoryPattern.Classes;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryPattern.Factory
{
    public class IcecreamFactory : IIcecreamFactory
    {
        public IIcecream GetIcecream(string type)
        {
            if (type == "Choco")
            {
                return new ChocoIcecream();
            }
            else if (type.Contains("Van"))
            {
                return new VanillaIcecream();
            }
            throw new ArgumentException("Item Invalid");
        }
    }
}