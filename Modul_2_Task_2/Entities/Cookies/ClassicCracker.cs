using Modul_2_Task_2.Entities.Abstract.FlourConfectionery;

namespace Modul_2_Task_2.Entities.Cookies
{
    public class ClassicCracker : Cracker
    {
        public ClassicCracker()
            : this("Crack", "MDK", 8)
        {
        }

        public ClassicCracker(string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
