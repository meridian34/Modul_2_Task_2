using Modul_2_Task_2.Entities.Enum;
using Modul_2_Task_2.Entities.Abstract.SugarConfectionery;

namespace Modul_2_Task_2.Entities.Candies
{
    public class VobroCheriCandy : LiquorCandy
    {
        public VobroCheriCandy()
            : this("VobroCheri", "Roshen", 25)
        {
        }

        public VobroCheriCandy(string confectionName, string manufacturerName, int confectionWeight)
            : base(CandyTaste.SweetAndSour, GlazeType.Chocolate, LiquorType.Cherry, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
