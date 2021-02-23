using Modul_2_Task_2.Entities.Abstract.FlourConfectionery;

namespace Modul_2_Task_2.Entities.Cookies
{
    public class CheckerboardCookie : SugarCookies
    {
        public CheckerboardCookie()
            : this("Shahmatnoe", "PoltavaK", 10)
        {
        }

        public CheckerboardCookie(string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
