namespace Modul_2_Task_2.Entities.Abstract.FlourConfectionery
{
    public class LingeringCookies : RegularCookies
    {
        public LingeringCookies(string confectionName, string manufacturerName, int confectionWeight)
            : base(Enum.CookieClassification.LingeringCookies, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
