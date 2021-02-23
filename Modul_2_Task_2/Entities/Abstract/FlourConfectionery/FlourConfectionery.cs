using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.FlourConfectionery
{
    public abstract class FlourConfectionery : Confection
    {
        public FlourConfectionery(string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
            FoundationConfectionery = FoundationConfectionery.Flour;
        }

        public FoundationConfectionery FoundationConfectionery { get; set; }
    }
}
