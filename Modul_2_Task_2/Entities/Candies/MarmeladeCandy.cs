using Modul_2_Task_2.Entities.Enum;
using Modul_2_Task_2.Entities.Abstract.SugarConfectionery;

namespace Modul_2_Task_2.Entities.Candies
{
    public class MarmeladeCandy : JelliesCandy
    {
        public MarmeladeCandy()
            : this("Dream", "AVK", 25)
        {
        }

        public MarmeladeCandy(string confectionName, string manufacturerName, int confectionWeight)
            : base(GelliesType.Marmalade, CandyTaste.SweetAndSour, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
