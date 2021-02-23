using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_2_Task_2.Entities.Abstract.FlourConfectionery
{
    public abstract class RegularCookies : Cookie
    {
        public RegularCookies(Enum.CookieClassification cookieClassification, string confectionName, string manufacturerName, int confectionWeight)
            : base(Enum.CookieType.RegularCookies, confectionName, manufacturerName, confectionWeight)
        {
            CookieClassification = cookieClassification;
        }

        public Enum.CookieClassification CookieClassification { get; set; }
    }
}
