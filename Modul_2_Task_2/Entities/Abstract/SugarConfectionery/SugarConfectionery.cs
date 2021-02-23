using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.SugarConfectionery
{
    public abstract class SugarConfectionery : Confection
    {
        public SugarConfectionery(string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
            FoundationConfectionery = FoundationConfectionery.Sugar;
        }

        public FoundationConfectionery FoundationConfectionery { get; set; }
    }
}
