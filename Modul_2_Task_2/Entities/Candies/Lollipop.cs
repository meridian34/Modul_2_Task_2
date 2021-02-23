using Modul_2_Task_2.Entities.Enum;
using Modul_2_Task_2.Entities.Abstract.SugarConfectionery;

namespace Modul_2_Task_2.Entities
{
    public class Lollipop : CaramelCandy
    {
        public Lollipop()
            : this("Barbarian", "AVK", 20)
        {
        }

        public Lollipop(string confectionName, string manufacturerName, int confectionWeight)
            : base(CandyTaste.Sour, CaramelType.Crystalline, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
