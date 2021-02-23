using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.SugarConfectionery
{
    public abstract class CaramelCandy : NonGlazedCandy
    {
        public CaramelCandy(CandyTaste candyTaste, CaramelType caramelType, string confectionName, string manufacturerName, int confectionWeight)
            : base(candyTaste, NonGlazeCandyType.Caramel, confectionName, manufacturerName, confectionWeight)
        {
            CaramelType = caramelType;
        }

        public CaramelType CaramelType { get; set; }
    }
}
