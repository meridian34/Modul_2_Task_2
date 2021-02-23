using Modul_2_Task_2.Entities.Abstract.FlourConfectionery;

namespace Modul_2_Task_2.Entities.Cookies
{
    public class SaltyCracker : Cracker
    {
        public SaltyCracker()
            : this("SolonTchak", "Zirka", 10)
        {
        }

        public SaltyCracker(string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
