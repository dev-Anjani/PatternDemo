using FactoryPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryPattern.Factory
{
    public interface IIcecreamFactory
    {
        IIcecream GetIcecream(string type);
    }
}