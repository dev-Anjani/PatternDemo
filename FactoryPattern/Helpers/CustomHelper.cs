using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FactoryPattern.Helpers
{
    public static class CustomHelper
    {
        public static IHtmlString Image(this HtmlHelper helper, string src, string alt)
        {
            string imgFormat = $"<img src='{src}' alt='{alt}'></img>";
            MvcHtmlString str = new MvcHtmlString(imgFormat);
            return str;
        }
        public static IHtmlString ImageTag(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tag = new TagBuilder("img");
            tag.Attributes.Add("src", src);
            tag.Attributes.Add("alt", alt);

            return new MvcHtmlString(tag.ToString());
        }
    }
}