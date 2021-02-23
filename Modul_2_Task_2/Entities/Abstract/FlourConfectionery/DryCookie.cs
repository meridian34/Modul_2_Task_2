using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.FlourConfectionery
{
    public abstract class DryCookie : Cookie
    {
        public DryCookie(CookieClassification cookieClassification, string confectionName, string manufacturerName, int confectionWeight)
            : base(CookieType.DryBiscuits, confectionName, manufacturerName, confectionWeight)
        {
            CookieClassification = cookieClassification;
        }

        public CookieClassification CookieClassification { get; set; }
    }
}
