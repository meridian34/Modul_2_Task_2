using Modul_2_Task_2.Entities.Enum;
using Modul_2_Task_2.Entities.Abstract.SugarConfectionery;

namespace Modul_2_Task_2.Entities.Candies
{
    public class GelatinCandy : JelliesCandy
    {
        public GelatinCandy()
            : this("Bee", "Roshen", 15)
        {
        }

        public GelatinCandy(string confectionName, string manufacturerName, int confectionWeight)
            : base(GelliesType.Gelatin, CandyTaste.SweetAndSour, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
