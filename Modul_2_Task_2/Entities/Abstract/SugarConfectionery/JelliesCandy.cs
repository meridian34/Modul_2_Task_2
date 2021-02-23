using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.SugarConfectionery
{
    public abstract class JelliesCandy : NonGlazedCandy
    {
        public JelliesCandy(GelliesType gelliesType, CandyTaste candyTaste, string confectionName, string manufacturerName, int confectionWeight)
            : base(candyTaste,  NonGlazeCandyType.Gelatin, confectionName, manufacturerName, confectionWeight)
        {
            GelliesType = gelliesType;
        }

        public GelliesType GelliesType { get; set; }
    }
}
