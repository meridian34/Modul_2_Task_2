using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.FlourConfectionery
{
    public abstract class Cracker : DryCookie
    {
        protected Cracker(string confectionName, string manufacturerName, int confectionWeight)
            : base(CookieClassification.Cracker, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
