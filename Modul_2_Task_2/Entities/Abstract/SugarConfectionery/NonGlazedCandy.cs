using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.SugarConfectionery
{
    public abstract class NonGlazedCandy : Candy
    {
        public NonGlazedCandy(CandyTaste candyTaste, NonGlazeCandyType candyType, string confectionName, string manufacturerName, int confectionWeight)
            : base(candyTaste, confectionName, manufacturerName, confectionWeight)
        {
            NonGlazeCandyType = candyType;
        }

        public NonGlazeCandyType NonGlazeCandyType { get; set; }
    }
}
