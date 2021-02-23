using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.FlourConfectionery
{
    public abstract class Cookie : FlourConfectionery
    {
        public Cookie(CookieType cookieType, string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
            CookieType = cookieType;
        }

        public CookieType CookieType { get; set; }
    }
}
