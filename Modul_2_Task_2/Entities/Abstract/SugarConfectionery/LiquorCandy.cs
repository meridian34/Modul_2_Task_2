using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.SugarConfectionery
{
    public abstract class LiquorCandy : GlazedCandy
    {
        public LiquorCandy(CandyTaste candyTaste, GlazeType glazeType, LiquorType liquorType, string confectionName, string manufacturerName, int confectionWeight)
            : base(candyTaste, glazeType, confectionName, manufacturerName, confectionWeight)
        {
            LiquorType = liquorType;
        }

        public LiquorType LiquorType { get; set; }
    }
}
