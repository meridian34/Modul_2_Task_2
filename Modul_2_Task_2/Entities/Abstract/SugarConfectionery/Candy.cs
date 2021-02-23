using Modul_2_Task_2.Entities.Enum;

namespace Modul_2_Task_2.Entities.Abstract.SugarConfectionery
{
    public abstract class Candy : SugarConfectionery
    {
        public Candy(CandyTaste taste, string confectionName, string manufacturerName, int confectionWeight)
            : base(confectionName, manufacturerName, confectionWeight)
        {
            CandyTaste = taste;
        }

        public CandyTaste CandyTaste { get; set; }
    }
}
