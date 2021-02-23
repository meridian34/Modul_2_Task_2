using Modul_2_Task_2.Entities.Abstract.FlourConfectionery;

namespace Modul_2_Task_2.Entities.Cookies
{
    public class Maria : LingeringCookies
    {
        public Maria()
            : this("Maria", "Roshen", 8)
        {
        }

        public Maria(string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
