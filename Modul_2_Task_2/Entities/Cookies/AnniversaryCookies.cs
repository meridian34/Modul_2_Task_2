using Modul_2_Task_2.Entities.Abstract.FlourConfectionery;

namespace Modul_2_Task_2.Entities.Cookies
{
    public class AnniversaryCookies : SugarCookies
    {
        public AnniversaryCookies()
            : this("Jubileinoe", "KhKK", 10)
        {
        }

        public AnniversaryCookies(string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
