using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modul_2_Task_2.Entities.Enum;
using Modul_2_Task_2.Entities.Abstract.SugarConfectionery;

namespace Modul_2_Task_2.Entities
{
    public class Toffees : CaramelCandy
    {
        public Toffees()
            : this("Korovka", "AVK", 15)
        {
        }

        public Toffees(string confectionName, string manufacturerName, int confectionWeight)
            : base(CandyTaste.Sweet, CaramelType.Amorphous, confectionName, manufacturerName, confectionWeight)
        {
        }
    }
}
