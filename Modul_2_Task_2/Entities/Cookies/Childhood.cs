using Modul_2_Task_2.Entities.Abstract.FlourConfectionery;

namespace Modul_2_Task_2.Entities.Cookies
{
    public class Childhood : LingeringCookies
    {
        public Childhood()
            : this("Detstvo", "AVK", 12)
        {
        }

        public Childhood(string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
