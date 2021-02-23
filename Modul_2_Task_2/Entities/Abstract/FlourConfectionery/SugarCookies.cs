namespace Modul_2_Task_2.Entities.Abstract.FlourConfectionery
{
    public abstract class SugarCookies : RegularCookies
    {
        public SugarCookies(string confectionName, string manufacturerName, int confectionWeight)
            : base(Enum.CookieClassification.SugarCookies, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
