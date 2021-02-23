using Modul_2_Task_2.Entities.Enum;
using Modul_2_Task_2.Entities.Abstract.SugarConfectionery;

namespace Modul_2_Task_2.Entities.Candies
{
    public class MonMilk : LiquorCandy
    {
        public MonMilk()
            : this("MonMilk", "Svitoch", 30)
        {
        }

        public MonMilk(string confectionName, string manufacturerName, int confectionWeight)
            : base(CandyTaste.Sweet, GlazeType.MilkChocolate, LiquorType.Milk, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
