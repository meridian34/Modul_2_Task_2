using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.SugarConfectionery
{
    public abstract class GlazedCandy : Candy
    {
        public GlazedCandy(CandyTaste candyTaste, GlazeType glazeType, string confectionName, string manufacturerName, int confectionWeight)
            : base(candyTaste, confectionName, manufacturerName, confectionWeight)
        {
            GlazeType = glazeType;
        }

        public GlazeType GlazeType { get; set; }
    }
}
