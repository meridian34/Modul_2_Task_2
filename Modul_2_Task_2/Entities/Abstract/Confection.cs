using System;
using System.Collections.Generic;
using System.Text;

namespace Modul_2_Task_2.Entities.Abstract
{
    public abstract class Confection
    {
        public Confection(string confectionName, string manufacturerName, int confectionWeight)
        {
            Name = confectionName;
            Manufacturer = manufacturerName;
            ConfectionWeight = confectionWeight;
        }

        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public int ConfectionWeight { get; set; }
    }
}
